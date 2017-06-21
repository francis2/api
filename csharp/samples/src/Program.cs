/*
 *
 * Tradovate API, Samples
 *
*/

using System;
using System.Threading;
using System.Threading.Tasks;
using Tradovate.Services.Client;
using Tradovate.Services.Model;
using Tradovate.Services.Api;

namespace Tradovate
{
    class Program
    {
        static string AccessToken;
        static int MyUserId;
        static string MyUsername, MyPassword;
        static string DemoUrl, LiveUrl;

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please specify username and password as arguments");
                return;
            }

            MyUsername = args[0];
            MyPassword = args[1];
            var password = args[1];
            LiveUrl = "https://live-api-d.tradovate.com/v1";
            DemoUrl = "https://demo-api-d.tradovate.com/v1";

            var accessTokenResponse = Authentication.GetAccessToken(LiveUrl, MyUsername, password);
            AccessToken = accessTokenResponse.AccessToken;
            MyUserId = accessTokenResponse.UserId ?? 0;

            // RestApiExample();
            TradingViaWebSocketExample();
            // AccountRiskLimits();

            // Authenticated user should be "OrganizationAdmin" to successfully proceed the next samples
            // Please uncomment the next line
            // OrganizationExample();

            Thread.Sleep(3000);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void WebsocketClient_DataUpdated(object sender, DataUpdate e)
        {
            Console.WriteLine(e.ToString());
            if (e.Entity is ExecutionReport)
            {
                Trading.ShowOrderDetails(e.Entity as ExecutionReport);
            }
            else if (e.Entity is Order)
            {
                Trading.ShowOrderDetails(e.Entity as Order);
            }
            if (e.Entity is CommandReport)
            {
                Trading.ShowOrderDetails(e.Entity as CommandReport);
            }
        }

        private static void WebsocketClient_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("WebsocketClient_Closed");
        }

        private static void RestApiExample()
        {
            // Via REST API
            Console.WriteLine("CALLING SERVICES VIA REST API");
            Configuration.Default = new Configuration(new ApiClient(DemoUrl));
            Configuration.Default.ApiKey.Add("Authorization", AccessToken);
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var account = Accounting.GetAccount(MyUserId);
            Accounting.ShowAccountActivities(account);

            var feesApi = new FeesApi();
            var availablePlans = feesApi.GetAllTradovateSubscriptionPlans();
            foreach (var plan in availablePlans)
            {
                Console.WriteLine(plan);
            }
        }

        static WebSocketClient InitializeWebSocket(bool liveEnvironment)
        {
            Configuration.Default = new Configuration(new ApiClient());
            Configuration.Default.ApiKey.Add("Authorization", AccessToken);
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");
            WebSocketClient websocketClient = new WebSocketClient(liveEnvironment ? LiveUrl : DemoUrl);
            Configuration.Default.ApiClient.RestClient = websocketClient;
            return websocketClient;
        }

        private static void TradingViaWebSocketExample()
        {
            Console.WriteLine("\nCALLING SERVICES VIA WEBSOCKET");
            WebSocketClient websocketClient = InitializeWebSocket(false);
            websocketClient.DataUpdated += WebsocketClient_DataUpdated;
            websocketClient.Closed += WebsocketClient_Closed;
            websocketClient.Opened += (sender, e) =>
            {
                Console.WriteLine("WebsocketClient_Opened");
                Task.Run(() =>
                {
                    Accounting.StartRealtimeUpdates();

                    Accounting.PrepopulateCache();
                    ContractLibrary.PrepopulateCache();

                    Thread.Sleep(3000);
                    var symbol = "ESH7";
                    Log.Write($"SHOW {symbol} SPECIFICATIONS");
                    ContractLibrary.ContractSpec(symbol);

                    Thread.Sleep(3000);
                    var account = Accounting.GetAccount(0);
                    var orderQty = 1;
                    Log.Write($"PLACE BUY {orderQty} {symbol} MKT ORDER");
                    Trading.PlaceOrder(account, PlaceOrder.ActionEnum.Buy, orderQty, symbol, PlaceOrder.OrderTypeEnum.Market);

                    Thread.Sleep(3000);
                    Log.Write($"PLACE SELL {orderQty} {symbol} MKT ORDER");
                    Trading.PlaceOrder(account, PlaceOrder.ActionEnum.Sell, orderQty, symbol, PlaceOrder.OrderTypeEnum.Market);

                    Thread.Sleep(300000);
                    websocketClient.Close();
                });
            };
            Thread.Sleep(13000);
        }

        private static void OrganizationExample()
        {
            Configuration.Default = new Configuration(new ApiClient(LiveUrl));
            Configuration.Default.ApiKey.Add("Authorization", AccessToken);
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var randomId = (new Random()).Next();
            var newUsername = $"{MyUsername}_{randomId}";
            var password = $"{MyUsername}+{randomId}+A";
            Console.WriteLine($"Creating a user {newUsername} for our organization (should be done in LIVE environment)");
            var newUser = Organization.CreateUser(newUsername, password);

            Organization.ChangePassword(newUser.Id.Value, password + "+", MyPassword);

            var membershipPlan = "GLABRYBA_PLAN";
            Console.WriteLine($"Assigning membership plan {membershipPlan} to {newUser.Name}");
            Organization.AssignPracticeTradovatePlan(newUser, membershipPlan);

            Console.WriteLine("Switching to DEMO environment");
            Configuration.Default = new Configuration(new ApiClient(DemoUrl));
            Configuration.Default.ApiKey.Add("Authorization", AccessToken);
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var accountName = $"APITEST{randomId}";
            Console.WriteLine($"Creating a practice account {accountName} and granting permissions to {newUser.Name}");
            var account = Organization.CreatePracticeAccount(accountName, 50000.0, newUser);
            Console.WriteLine($"Practice account created with ID=${account.Id}. Adding initial risk limits (max overall exposure = 3)");
            Risks.SetMaxOverallPositionLimit(account, 3);
            Risks.SetDailyLossLimit(account, 1000.0);
            var account2 = Organization.CreatePracticeAccount("DUP" + accountName, 50000.0, newUser);
            Console.WriteLine($"Practice account created with ID=${account2.Id}. Adding initial risk limits (max overall exposure = 3)");
            Risks.SetMaxOverallPositionLimit(account2, 3);
            Risks.SetDailyLossLimit(account2, 1000.0);
        }

        private static void AccountRiskLimits()
        {
            Configuration.Default = new Configuration(new ApiClient(DemoUrl));
            Configuration.Default.ApiKey.Add("Authorization", AccessToken);
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var account = Accounting.GetAccount(MyUserId);

            Console.WriteLine("\nSHOWING ACCOUNT RISK LIMITS");
            Risks.ShowRiskLimits(account);
            Risks.SetMaxOverallPositionLimit(account, 9);
            Risks.SetDailyLossLimit(account, 1210.0);
        }
    }
 }
