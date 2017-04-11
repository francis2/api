using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tradovate.Services.Api;
using Tradovate.Services.Client;

namespace Tradovate.MarketData
{
    class Scenario
    {
        public Scenario(string description)
        {
            Description = description;
            Log.Write($"Created scenario '{Description}'");
        }

        public PricesApi Api { get; private set; }
        public WSClient Client
        {
            get
            {
                return (WSClient)Api.Configuration.ApiClient.RestClient;
            }
            set
            {
                Api.Configuration.ApiClient.RestClient = value;
            }
        }
        public string Description { get; private set; }

        public Scenario InitializeAPI(Func<PricesApi> action)
        {
            Api = action();
            Log.Write("API initialized.");
            return this;
        }

        public Scenario InitializeClient(Func<WSClient> init, EventHandler opened, EventHandler closed)
        {
            Items.Add(new InitializeClient(init, opened, closed));
            return this;
        }

        public Scenario ProcessingWhile(TimeSpan duration)
        {
            Items.Add(new ProcessingWhile(duration));
            return this;
        }

        public Scenario Request<TRequest, TResponseResult>(string description,
            Func<TRequest> init,
            Func<PricesApi, TRequest, Task<ApiResponse<TResponseResult>>> sender,
            Action<TRequest, ApiResponse<TResponseResult>> responseHandler,
            WSClient.IncomingMessageEventHandler dataHandler = null)
            where TRequest : class
            where TResponseResult : class
        {
            Items.Add(new Request<TRequest, TResponseResult>(description, init, sender, responseHandler, dataHandler));
            return this;
        }

        private readonly List<ScenarioItem> Items = new List<ScenarioItem>();

        public void Run()
        {
            Log.Write($"Running scenario '{Description}'");

            foreach (var item in Items)
            {
                try
                {
                    item.Execute(this);
                }
                catch (Exception e)
                {
                    Log.Write($" The scenario aborted, EXCEPTION: {e}");
                    break;
                }
            }

            if (Client != null)
            {
                var completion = new TaskCompletionSource<int>();
                Client.Closed += (sender, e) => completion.SetResult(0);

                Log.Write("Closing WebSocket...");
                Client.Close();

                completion.Task.Wait();
            }

            Console.WriteLine();
            Log.Write($"Scenario '{Description}' finished.");
            Console.WriteLine("Press any key to exit the scenario.");
            Console.ReadKey();
        }
    }

    abstract class ScenarioItem
    {
        public abstract void Execute(Scenario owner);
    }

    class ProcessingWhile : ScenarioItem
    {
        public TimeSpan Duration { get; private set; }

        public ProcessingWhile(TimeSpan duration)
        {
            Duration = duration;
        }

        public override void Execute(Scenario owner)
        {
            Log.Write($"Processing while {Duration.TotalSeconds} seconds...");
            Task.Delay(Duration).Wait();
        }
    }

    class InitializeClient : ScenarioItem
    {
        public InitializeClient(Func<WSClient> init, EventHandler opened, EventHandler closed)
        {
            Init = init;
            Opened = opened;
            Closed = closed;
        }

        public Func<WSClient> Init { get; private set; }
        public EventHandler Opened { get; private set; }
        public EventHandler Closed { get; private set; }

        public override void Execute(Scenario owner)
        {
            owner.Client = Init();
            owner.Client.Closed += Closed;

            var completion = new TaskCompletionSource<int>();
            owner.Client.Opened += (sender, e) =>
            {
                Opened?.Invoke(sender, e);
                completion.SetResult(0);
            };

            Log.Write("WebSocket Client initialized, waiting for WebSocket gets opened...");
            completion.Task.Wait();
        }
    }

    class Request<TRequest, TResponseResult> : ScenarioItem
        where TRequest : class
        where TResponseResult : class
    {
        public string Description { get; private set; }
        public Func<TRequest> Init { get; private set; }
        public Func<PricesApi, TRequest, Task<ApiResponse<TResponseResult>>> Sender { get; private set; }
        public Action<TRequest, ApiResponse<TResponseResult>> ResponseHandler { get; private set; }
        public WSClient.IncomingMessageEventHandler DataHandler { get; private set; }

        public Request(string description,
            Func<TRequest> init,
            Func<PricesApi, TRequest, Task<ApiResponse<TResponseResult>>> sender,
            Action<TRequest, ApiResponse<TResponseResult>> responseHandler,
            WSClient.IncomingMessageEventHandler dataHandler)
        {
            Description = description;
            Init = init;
            Sender = sender;
            ResponseHandler = responseHandler;
            DataHandler = dataHandler;
        }

        public override void Execute(Scenario owner)
        {
            Log.Write($"Executing request '{Description}'...");
            var request = Init();
            var task = Sender(owner.Api, request);
            owner.Client.IncomingMessage = DataHandler;
            task.Wait();
            ResponseHandler(request, task.Result);
        }
    }
}
