/*
 *
 * Tradovate API, Samples.
 * Organization-related operations
 *
*/

using System;
using System.Linq;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class Organization
    {
        public static User CreateUser(string username, string password)
        {
            var usersApi = new UsersApi();
            var request = new SignUpOrganizationMember(Name: username, 
                Email: $"fake+{username}@tradovate.com", 
                Password: password, 
                FirstName: "John", 
                LastName: "Uppee");
            var response = usersApi.SignUpOrganizationMember(request);
            Console.WriteLine(response);
            if (response.UserId != null)
            {
                var createdUser = usersApi.GetUser(response.UserId);
                Console.WriteLine(createdUser);
                return createdUser;
            }
            else
            {
                return null;
            }
        }

        public static TradovateSubscription AssignPracticeTradovatePlan(User newUser, string membershipPlan)
        {
            var feesApi = new FeesApi();
            var availablePlans = feesApi.GetAllTradovateSubscriptionPlans();
            foreach (var plan in availablePlans)
            {
                Console.WriteLine(plan);
            }
            var organizationPlans = availablePlans.Where(x => x.OrganizationId != null);
            var practicePlan = organizationPlans.First(x => x.Name == membershipPlan);
            var usersApi = new UsersApi();
            var response = usersApi.AddTradovateSubscription(new AddTradovateSubscription(TradovateSubscriptionPlanId: practicePlan.Id, UserId: newUser.Id));
            Console.WriteLine(response);
            return response.TradovateSubscription;
        }

        public static Account CreatePracticeAccount(string accountName, double initialBalance, User grantTo)
        {
            var accountingApi = new AccountingApi();
            var templateAccount = accountingApi.GetAllAccounts().First();
            var usersApi = new UsersApi();
            var openDemoAccountResponse = usersApi.OpenDemoAccount(new OpenDemoAccount(templateAccount.Id, accountName, initialBalance));
            Console.WriteLine(openDemoAccountResponse);
            if (openDemoAccountResponse.AccountId != null)
            {
                var practiceAccount = accountingApi.GetAccount(openDemoAccountResponse.AccountId);
                Console.WriteLine(practiceAccount);
                var tradingPermissionResponse = usersApi.RequestTradingPermission(new RequestTradingPermission(AccountId: practiceAccount.Id,
                    CtaContact: "John Uppee",
                    CtaEmail: grantTo.Email));
                Console.WriteLine(tradingPermissionResponse);
                if (tradingPermissionResponse.ErrorText != null)
                {
                    throw new Exception($"Failed granting trading permissions: {tradingPermissionResponse.ErrorText}");
                }
                return practiceAccount;
            }
            else
                return null;
        }
    }
}
