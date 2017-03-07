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
            Log.Write($"Accounts: {result.Count}");
            var account = result.First(x => x.Active == true && (myUserId == 0 || x.UserId == myUserId));
            Log.Write($"Account: {account}");
            return account;
        }

        public static void ShowAccountActivities(Account account)
        {
            Log.Write($"ShowAccountActivities for {account.Name} account");
            var accountingApi = new AccountingApi();
            foreach (var cashBalance in accountingApi.GetOwnedCashBalances(account.Id))
            {
                Log.Write(cashBalance);
            }
            var marginSnapshot = accountingApi.GetMarginSnapshot(account.Id);
            Log.Write(marginSnapshot);
            var balanceSnapshot = accountingApi.GetCashBalanceSnapshot(new GetCashBalanceSnapshot(account.Id));
            Log.Write(balanceSnapshot);
            var ordersApi = new OrdersApi();
            var orders = ordersApi.GetOwnedOrders(account.Id);
            foreach (var order in orders)
            {
                Log.Write(order);
            }
            var accountOrders = orders.ToDictionary(x => x.Id);
            var fills = ordersApi.GetAllFills().Where(fill => accountOrders.ContainsKey(fill.OrderId));
            foreach (var fill in fills)
            {
                Log.Write(fill);
            }
            var positionsApi = new PositionsApi();
            foreach (var position in positionsApi.GetOwnedPositions(account.Id))
            {
                Log.Write(position);
            }
        }

        public static void StartRealtimeUpdates()
        {
            var apiInstance = new UsersApi();
            var syncRequest = new SyncRequest();
            var result = apiInstance.SyncRequest(syncRequest);
            Log.Write($"Initial data sync response");
        }

        public static void PrepopulateCache()
        {
            // Cache pre-populating can save some latency at trading time
            Log.Write("PRE-POPULATING ACCOUNT INFO");
            var apiInstance = new AccountingApi();
            apiInstance.GetAllTradingPermissions();
        }
    }
}
