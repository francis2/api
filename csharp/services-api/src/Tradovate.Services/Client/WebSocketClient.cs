/* 
 * 
 * Tradovate API, Websocket implementation
 *
*/

using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
using RestSharp;
using WebSocket4Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tradovate.Services.Client
{
    public class DataUpdate
    {
        public readonly string ModificationType;
        public readonly string EntityType;
        public readonly object Entity;
        public DataUpdate(string modificationType, string entityType, object entity)
        {
            this.ModificationType = modificationType;
            this.EntityType = entityType;
            this.Entity = entity;
        }

        public override string ToString()
        {
            return $"DataUpdate: {ModificationType}, {Entity}";
        }
    }

    public class IncomingMessage
    {
        public string e;
        public int i;
        public int s;
        public object d;
    }

    public partial class WebSocketClient : RestClient
    {
        private int requestCounter = 0;
        private WebSocket webSocket;
        private string accessToken;
        private ConcurrentDictionary<int, TaskCompletionSource<IRestResponse>> pendingRequests = new ConcurrentDictionary<int, TaskCompletionSource<IRestResponse>>();

        public event EventHandler Opened;
        public event EventHandler Authorized;
        public event EventHandler Closed;
        public event EventHandler<DataUpdate> DataUpdated;

        public WebSocketClient(string uri)
        {
            uri = uri.Replace("https:", "wss:") + "/websocket";
            webSocket = new WebSocket(uri);
            webSocket.EnableAutoSendPing = false;
            webSocket.NoDelay = true;
            webSocket.MessageReceived += WebSocket_MessageReceived;
            webSocket.Closed += WebSocket_Closed;
            webSocket.Error += WebSocket_Error;
            webSocket.Open();
            ScheduleHeartbeats();
        }

        public void Close()
        {
            webSocket.Close();
        }

        public void Dispose()
        {
            webSocket.Dispose();
        }

        private async void ScheduleHeartbeats()
        {
            await Task.Delay(2500);
            if (webSocket.State == WebSocketState.Open)
            {
                Log.Write("HEARTBEAT: SEND");
                webSocket.Send("[]");
                ScheduleHeartbeats();
            }
        }

        private void WebSocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            Log.Write($"ERROR: {e}");
        }

        private void WebSocket_Closed(object sender, EventArgs e)
        {
            var promises = pendingRequests.Values.ToArray();
            pendingRequests.Clear();
            foreach (var promise in promises)
            {
                promise.TrySetCanceled();
            }
            Closed?.Invoke(this, EventArgs.Empty);
        }

        private void WebSocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var frame = e.Message;
            Log.Write($"RECVD: {frame}");
            if(frame == "o")
            {
                Opened?.Invoke(this, EventArgs.Empty);
            }
            else if (frame == "h") {
                // Hearbeat
            }
            else if (frame == "c")
            {
                webSocket.Close();
            }
            else if (frame[0] == 'a')
            {
                var json = frame.Substring(1);
                var messages = JsonConvert.DeserializeObject<IncomingMessage[]>(json);
                foreach (var message in messages)
                {
                    if(message.e != null)
                    {
                        switch(message.e)
                        {
                            case "shutdown":
                                Console.WriteLine($"Server is going to close this connection: {message.d}");
                                break;
                            case "props":
                                string eventType = "", entityType = "";
                                object entity = null;
                                foreach (var prop in (message.d as JContainer).Values<JProperty>())
                                {
                                    switch (prop.Name)
                                    {
                                        case "eventType":
                                            eventType = prop.Value.ToString();
                                            break;
                                        case "entityType":
                                            entityType = prop.Value.ToString();
                                            break;
                                        case "entity":
                                            entity = prop.Value;
                                            break;
                                        default:
                                            Log.Write($"Unrecognized event property: {prop}");
                                            break;
                                    }
                                }
                                if (entity != null)
                                {
                                    try
                                    {
                                        var typeName = entityType[0].ToString().ToUpper() + entityType.Substring(1);
                                        typeName = $"Tradovate.Services.Model.{typeName}";
                                        var type = Type.GetType(typeName, true);
                                        entity = JsonConvert.DeserializeObject(entity.ToString(), type);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.Error.WriteLine($"Cannot deserialize event's entity: {entityType}, {entity}, {ex}");
                                    }
                                }
                                DataUpdated?.Invoke(this, new DataUpdate(eventType, entityType, entity));
                                break;
                        }
                    }
                    else
                    {
                        TaskCompletionSource<IRestResponse> promise;
                        if(pendingRequests.TryRemove(message.i, out promise))
                        {
                            var response = new RestResponse();
                            response.StatusCode = (System.Net.HttpStatusCode)message.s;
                            response.Content = message.d?.ToString();
                            if (response.Content != null)
                            {
                                response.ContentLength = response.Content.Length;
                            }
                            if (message.s / 100 == 2)
                            {
                                response.ResponseStatus = ResponseStatus.Completed;
                            }
                            else
                            {
                                response.ResponseStatus = ResponseStatus.Error;
                            }
                            promise.TrySetResult(response);
                        }
                    }
                }
            }
        }

        public override IRestResponse Execute(IRestRequest request)
        {
            var task = ExecuteTaskAsync(request);
            task.Wait(request.Timeout - 1);
            return task.Result;
        }

        private Task<IRestResponse> DoExecuteTaskAsync(string endpoint, string queryParams, string body)
        {
            var id = Interlocked.Increment(ref requestCounter);
            var frame = $"{endpoint}\n{id}\n{queryParams}\n{body}";
            var promise = new TaskCompletionSource<IRestResponse>();
            pendingRequests.TryAdd(id, promise);
            webSocket.Send(frame);
            Log.Write($"SENT: {frame.Replace("\n", "\\n")}");
            return promise.Task;
        }

        private Task<IRestResponse> DoExecuteTaskAsync(IRestRequest request)
        {
            var endpoint = request.Resource.Substring(1);
            var bodyParameter = request.Parameters.FirstOrDefault(x => x.Type == ParameterType.RequestBody);
            var body = "";
            if (bodyParameter != null)
            {
                body = bodyParameter.Value.ToString();
            }
            var queryParameters = request.Parameters.Where(x => x.Type == ParameterType.QueryString).Select(x => x.Name + "=" + x.Value.ToString());
            return DoExecuteTaskAsync(endpoint, string.Join("&", queryParameters), body);
        }

        public override Task<IRestResponse> ExecuteTaskAsync(IRestRequest request)
        {
            Task<IRestResponse> authorizeTask = null;
            if (accessToken == null) {
                var authorizationHeader = request.Parameters.FirstOrDefault(x => x.Type == ParameterType.HttpHeader && x.Name == "Authorization");
                if (authorizationHeader != null)
                {
                    accessToken = authorizationHeader.Value.ToString().Replace("Bearer ", "");
                    authorizeTask = DoExecuteTaskAsync("authorize", "", accessToken);
                }
            }
            if (authorizeTask != null)
            {
                return authorizeTask.ContinueWith<IRestResponse>(authorizeResponse =>
                {
                    if (authorizeResponse.Result.ResponseStatus == ResponseStatus.Completed)
                    {
                        Authorized?.Invoke(this, EventArgs.Empty);
                        var call = DoExecuteTaskAsync(request);
                        call.Wait(request.Timeout - 1);
                        return call.Result;
                    }
                    else
                    {
                        return authorizeResponse.Result;
                    }
                });
            }
            else
            {
                return DoExecuteTaskAsync(request);
            }
        }
    }
}
