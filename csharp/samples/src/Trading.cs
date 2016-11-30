/*
 *
 * Tradovate API, Samples.
 * Order placement
 *
*/

using System;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class Trading
    {
        public static async void PlaceOrder(Account account, PlaceOrder.ActionEnum action, int orderQty, string symbol, PlaceOrder.OrderTypeEnum orderType, double? price = null, double? stopPrice = null)
        {
            var ordersApi = new OrdersApi();
            var request = new PlaceOrder(AccountSpec: account.Name, 
                Action: action, 
                Symbol: symbol, 
                OrderQty: orderQty, 
                OrderType: orderType, 
                Price: price, 
                StopPrice: stopPrice, 
                TimeInForce: Services.Model.PlaceOrder.TimeInForceEnum.Day, Text: "Sample");
            var response = await ordersApi.PlaceOrderAsync(request);
            Console.WriteLine($"{request} -> {response}");
        }
    }
}
