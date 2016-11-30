/*
 *
 * Tradovate API, Samples.
 *
*/

using System;
using System.Linq;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class Accounting
    {
        public static Account GetAccount(int myUserId)
        {
            var apiInstance = new AccountingApi();
            var result = apiInstance.GetAllAccounts();
            Console.WriteLine($"Accounts: {result.Count}");
            var account = result.First(x => x.UserId == myUserId);
            Console.WriteLine($"Account: {account}");
            return account;
        }

        public static void ShowAccountActivities(Account account)
        {
            Console.WriteLine($"ShowAccountActivities for {account.Name} account");
            var accountingApi = new AccountingApi();
            foreach (var cashBalance in accountingApi.GetOwnedCashBalances(account.Id))
            {
                Console.WriteLine(cashBalance);
            }
            var marginSnapshot = accountingApi.GetMarginSnapshot(account.Id);
            Console.WriteLine(marginSnapshot);
            var balanceSnapshot = accountingApi.GetCashBalanceSnapshot(new GetCashBalanceSnapshot(account.Id));
            Console.WriteLine(balanceSnapshot);
            var ordersApi = new OrdersApi();
            var orders = ordersApi.GetOwnedOrders(account.Id);
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
            var accountOrders = orders.ToDictionary(x => x.Id);
            var fills = ordersApi.GetAllFills().Where(fill => accountOrders.ContainsKey(fill.OrderId));
            foreach (var fill in fills)
            {
                Console.WriteLine(fill);
            }
            var positionsApi = new PositionsApi();
            foreach (var position in positionsApi.GetOwnedPositions(account.Id))
            {
                Console.WriteLine(position);
            }
        }

        public static void StartRealtimeUpdates()
        {
            var apiInstance = new UsersApi();
            var syncRequest = new SyncRequest();
            var result = apiInstance.SyncRequest(syncRequest);
            Console.WriteLine($"Initial data sync response: ${result}");
        }
    }
}
