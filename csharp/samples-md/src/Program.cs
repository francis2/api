/* 
 * 
 * Tradovate API, MarketData Samples
 *
*/

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Tradovate.MarketData
{
    class Program
    {
        static void Main(string[] args)
        {
            var Username = args[0];
            var Password = args[1];

            var accessTokenResponse = GetAccessToken("https://live-api-d.tradovate.com/v1", Username, Password);
            var AccessToken = accessTokenResponse.AccessToken;
            var UserId = accessTokenResponse.UserId ?? 0;

            ConsumingQuotes(AccessToken);
            ConsumingDOM(AccessToken);
            ConsumingHistograms(AccessToken);
            ConsumingCharts(AccessToken);
        }

        static void ConsumingQuotes(string accessToken)
        {
            var scenario = new Scenario("Consuming quotes")
                .InitializeAPI(
                    () =>
                    {
                        var cfg = new Configuration(new ApiClient());
                        cfg.ApiKey.Add("Authorization", accessToken);
                        cfg.ApiKeyPrefix.Add("Authorization", "Bearer");

                        return new PricesApi(cfg);
                    })
                .InitializeClient(
                    init: () => new WSClient("https://md-api-d.tradovate.com/v1"),
                    opened: (sender, e) =>
                    {
                        Log.Write("WebSocket opened.");
                    },
                    closed: (sender, e) =>
                    {
                        Log.Write("WebSocket closed.");
                    })
                .Request("Subscribe for ESM7 quotes",
                    init: () =>
                    {
                        // The contract ESM7 is specified by contract symbol
                        return new AlterQuoteSubscription("ESM7", new List<string> { MDEntryType.Bid, MDEntryType.Offer });
                    },
                    sender: (api, request) => api.AlterQuoteSubscriptionAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    },
                    dataHandler: message =>
                    {
                        switch (message.e)
                        {
                            case "md":
                                Log.Write("MD event:");
                                var json = message.d as JObject;
                                var data = json.ToObject<QuotesData>();
                                data?.Quotes?.ForEach(quote =>
                                {
                                    // TODO: Why data contains more entries than requested? 
                                    Log.Write($"  CONTRACT: {quote.ContractId}");
                                    Log.Write($"  TIMESTAMP: {quote.Timestamp}");
                                    Log.Write($"  BID: {quote.Entries.Bid}");
                                    Log.Write($"  OFFER: {quote.Entries.Offer}");
                                });
                                break;
                        }
                    })
                .ProcessingWhile(TimeSpan.FromSeconds(15))
                .Request("Alter subscribtion filter for ESM7 quotes",
                    init: () =>
                    {
                        // The contract ESM7 is specified by contract ID
                        return new AlterQuoteSubscription("1062123", new List<string> { MDEntryType.Bid, MDEntryType.Offer, MDEntryType.Trade });
                    },
                    sender: (api, request) => api.AlterQuoteSubscriptionAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    },
                    dataHandler: message =>
                    {
                        switch (message.e)
                        {
                            case "md":
                                Log.Write("MD event:");
                                var json = message.d as JObject;
                                var data = json.ToObject<QuotesData>();
                                data?.Quotes?.ForEach(quote =>
                                {
                                    Log.Write($"  CONTRACT: {quote.ContractId}");
                                    Log.Write($"  TIMESTAMP: {quote.Timestamp}");
                                    Log.Write($"  BID: {quote.Entries.Bid}");
                                    Log.Write($"  OFFER: {quote.Entries.Offer}");
                                    Log.Write($"  TRADE: {quote.Entries.Trade}");
                                });
                                break;
                        }
                    })
                .ProcessingWhile(TimeSpan.FromSeconds(15))
                .Request("Unsubscribe from ESM7 quotes",
                    init: () =>
                    {
                        // Specify empty filter to unsubscribe from a quote
                        return new AlterQuoteSubscription("1062123", new List<string>());
                    },
                    sender: (api, request) => api.AlterQuoteSubscriptionAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    });

            scenario.Run();
        }

        static void ConsumingDOM(string accessToken)
        {
            var scenario = new Scenario("Consuming DOM")
                .InitializeAPI(
                    () =>
                    {
                        var cfg = new Configuration();
                        cfg.ApiKey.Add("Authorization", accessToken);
                        cfg.ApiKeyPrefix.Add("Authorization", "Bearer");

                        return new PricesApi(cfg);
                    })
                .InitializeClient(
                    init: () => new WSClient("https://md-api-d.tradovate.com/v1"),
                    opened: (sender, e) =>
                    {
                        Log.Write("WebSocket opened.");
                    },
                    closed: (sender, e) =>
                    {
                        Log.Write("WebSocket closed.");
                    })
                .Request("Subscribe for ESM7 DOM",
                    init: () =>
                    {
                        // The contract ESM7 is specified by contract symbol
                        // TODO: For what reason entry type filter is required for DOM? 
                        return new SubscribeDOM("ESM7", new List<string> { MDEntryType.Bid, MDEntryType.Offer });
                    },
                    sender: (api, request) => api.SubscribeDOMAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    },
                    dataHandler: message =>
                    {
                        switch (message.e)
                        {
                            case "md":
                                Log.Write("MD event:");
                                var json = message.d as JObject;
                                var data = json.ToObject<DOMData>();
                                data?.Doms?.ForEach(dom =>
                                {
                                    Log.Write($"  CONTRACT: {dom.ContractId}");
                                    Log.Write($"  TIMESTAMP: {dom.Timestamp}");
                                    Log.Write("  BIDS:");
                                    Console.WriteLine(string.Join("\n", dom.Bids.Select(x => $"  {x}")));
                                    Log.Write("  OFFERS:");
                                    Console.WriteLine(string.Join("\n", dom.Offers.Select(x => $"  {x}")));
                                });
                                break;
                        }
                    })
                .ProcessingWhile(TimeSpan.FromSeconds(15))
                .Request("Unsubscribe from ESM7 DOM",
                    init: () =>
                    {
                        // Specify empty filter to unsubscribe from the DOM
                        return new SubscribeDOM("1062123", new List<string>());
                    },
                    sender: (api, request) => api.SubscribeDOMAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    });

            scenario.Run();
        }

        static void ConsumingHistograms(string accessToken)
        {
            var scenario = new Scenario("Consuming histograms")
                .InitializeAPI(
                    () =>
                    {
                        var cfg = new Configuration();
                        cfg.ApiKey.Add("Authorization", accessToken);
                        cfg.ApiKeyPrefix.Add("Authorization", "Bearer");

                        return new PricesApi(cfg);
                    })
                .InitializeClient(
                    init: () => new WSClient("https://md-api-d.tradovate.com/v1"),
                    opened: (sender, e) =>
                    {
                        Log.Write("WebSocket opened.");
                    },
                    closed: (sender, e) =>
                    {
                        Log.Write("WebSocket closed.");
                    })
                .Request("Subscribe for ESM7 histograms",
                    init: () => new AlterHistogramSubscription("ESM7", Subscribe: true),
                    sender: (api, request) => api.AlterHistogramSubscriptionAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    },
                    dataHandler: message =>
                    {
                        switch (message.e)
                        {
                            case "md":
                                Log.Write("MD event:");
                                var json = message.d as JObject;
                                var data = json.ToObject<HistogramData>();
                                data?.Histograms?.ForEach(histogram =>
                                {
                                    Log.Write($"  CONTRACT: {histogram.ContractId}");
                                    Log.Write($"  TIMESTAMP: {histogram.Timestamp}");
                                    Log.Write($"  REFRESH: {histogram.Refresh}");
                                    Log.Write($"  TRADE DATE: {histogram.TradeDate}");
                                    Log.Write($"  BASE: {histogram._Base}");

                                    var items = histogram.Items as JObject;
                                    if (items != null)
                                    {
                                        Log.Write("  ITEMS:");
                                        var pairs = items.ToObject<SortedDictionary<int, int>>();
                                        Console.WriteLine(string.Join("\n", pairs.Select(x => $"  {x}")));
                                    }
                                });
                                break;
                        }
                    })
                .ProcessingWhile(TimeSpan.FromSeconds(15))
                .Request("Unsubscribe from ESM7 histograms",
                    init: () => new AlterHistogramSubscription("1062123", Subscribe: false),
                    sender: (api, request) => api.AlterHistogramSubscriptionAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    });

            scenario.Run();
        }

        static void ConsumingCharts(string accessToken)
        {
            var scenario = new Scenario("Consuming charts")
                .InitializeAPI(
                    () =>
                    {
                        var cfg = new Configuration();
                        cfg.ApiKey.Add("Authorization", accessToken);
                        cfg.ApiKeyPrefix.Add("Authorization", "Bearer");

                        return new PricesApi(cfg);
                    })
                .InitializeClient(
                    init: () => new WSClient("https://md-api-d.tradovate.com/v1"),
                    opened: (sender, e) =>
                    {
                        Log.Write("WebSocket opened.");
                    },
                    closed: (sender, e) =>
                    {
                        Log.Write("WebSocket closed.");
                    })
                .Request("Get chart for ESM7",
                    init: () =>
                    {
                        var description = new ChartDescription(ChartDescription.UnderlyingTypeEnum.MinuteBar, 15, ChartDescription.ElementSizeUnitEnum.UnderlyingUnits);
                        var timeRange = new ChartTimeRange(AsMuchAsElements: 66);
                        return new GetChart("ESM7", description, timeRange);
                    },
                    sender: (api, request) => api.GetChartAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    },
                    dataHandler: message =>
                    {
                        switch (message.e)
                        {
                            case "chart":
                                Log.Write("CHART event:");
                                var json = message.d as JObject;
                                var data = json.ToObject<ChartData>();
                                data?.Charts?.ForEach(chart =>
                                {
                                    Log.Write($"  ID: {chart.Id}");
                                    Log.Write($"  S: {chart.S}");
                                    Log.Write($"  TD: {chart.Td}");
                                    if (chart.Bars != null)
                                    {
                                        Log.Write("  BARS:");
                                        Console.WriteLine(string.Join("\n", chart.Bars.Select(x => $"  {x}")));
                                    }
                                });
                                break;
                        }
                    })
                .ProcessingWhile(TimeSpan.FromSeconds(15))
                .Request("Cancel chart for ESM7",
                    init: () => new CancelChart(1062123),
                    sender: (api, request) => api.CancelChartAsyncWithHttpInfo(request),
                    responseHandler: (request, response) =>
                    {
                        Log.Write($"{request} -> {response.Data}");
                    });

            scenario.Run();
        }

        static AccessTokenResponse GetAccessToken(string basePath, string username, string password)
        {
            var apiInstance = new AuthenticationApi(basePath);
            var body = new AccessTokenRequest(Name: username, Password: password, AppId: "Tradovate.MarketData.SampleApp", AppVersion: "0.1.0");
            AccessTokenResponse result = apiInstance.AccessTokenRequest(body);
            Debug.WriteLine(result);
            return result;
        }
    }
}
