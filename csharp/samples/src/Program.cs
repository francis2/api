/* 
 * 
 * Tradovate API, Samples
 *
*/

using System;
using System.Threading;
using System.Threading.Tasks;
using Tradovate.Services.Client;

namespace Tradovate
{
    class Program
    {
        static string AccessToken;
        static int MyUserId;
        static string MyUsername;
        static string DemoUrl, LiveUrl;

        static void Main(string[] args)
        {
            MyUsername = "APISample01";
            var password = "ApiSample+01";
            LiveUrl = "https://live-api-d.tradovate.com/v1";
            DemoUrl = "https://demo-api-d.tradovate.com/v1";

            var accessTokenResponse = Authentication.GetAccessToken(LiveUrl, MyUsername, password);
            AccessToken = accessTokenResponse.AccessToken;
            MyUserId = accessTokenResponse.UserId ?? 0;

            RestApiExample();
            TradingRelatedExample();
            AccountRiskLimits();

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
        }

        private static void TradingRelatedExample()
        {
            Console.WriteLine("\nCALLING SERVICES VIA WEBSOCKET");
            Configuration.Default = new Configuration(new ApiClient());
            Configuration.Default.ApiKey.Add("Authorization", AccessToken);
            Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");
            WebSocketClient websocketClient = new WebSocketClient(DemoUrl);
            Configuration.Default.ApiClient.RestClient = websocketClient;
            websocketClient.DataUpdated += WebsocketClient_DataUpdated;
            websocketClient.Closed += WebsocketClient_Closed;
            websocketClient.Opened += (sender, e) =>
            {
                Console.WriteLine("WebsocketClient_Opened");
                Task.Run(() =>
                {
                    Accounting.StartRealtimeUpdates();

                    Thread.Sleep(3000);
                    Console.WriteLine("SHOW ESZ6 SPECIFICATIONS");
                    ContractLibrary.ContractSpec("ESZ6");

                    Thread.Sleep(3000);
                    var account = Accounting.GetAccount(MyUserId);
                    Console.WriteLine("PLACE BUY 1 ESZ6 MKT ORDER");
                    Trading.PlaceOrder(account, Services.Model.PlaceOrder.ActionEnum.Buy, 1, "ESZ6", Services.Model.PlaceOrder.OrderTypeEnum.Market);

                    Thread.Sleep(3000);
                    Console.WriteLine("PLACE SELL 1 ESZ6 MKT ORDER");
                    Trading.PlaceOrder(account, Services.Model.PlaceOrder.ActionEnum.Sell, 1, "ESZ6", Services.Model.PlaceOrder.OrderTypeEnum.Market);
                    Thread.Sleep(3000);
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
            var password = $"{MyUsername}+{randomId}";
            Console.WriteLine($"Creating a user {newUsername} for our organization (should be done in LIVE environment)");
            var newUser = Organization.CreateUser(newUsername, password);

            var membershipPlan = "TST_PRACTICE";
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
