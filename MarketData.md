# Overview

Tradovate Market Data API provides an access to market data such as quotes, DOM, charts and histograms.

The API uses JSON format to pass request parameters and response/data message payload.

Request/response exchange and data messages are transmitted via [Tradovate WebSocket-based protocol](WebSockets.md).

Demonstration C# sample of using Tradovate Market Data API is available in VS solution [here](csharp/services-api).

# Typical Use Case

A typical scenario of using Market Data API consists of the following steps:

- **Get an access token using credentials.**

  Client [obtains](Access.md#get-an-access-token-using-credentials) an [access token](Access.md#access-tokens) from Tradovate server.

- **Open a WebSocket and authorize.**

  Client opens a WebSocket to Tradovate URL [https://md-api.tradovate.com](https://md-api.tradovate.com) and performs [authorization procedure](WebSockets.md#authorization).

- **Create request parameters.**

  Request parameters are an object in JSON format.

  Each request requires `symbol` parameter that specifies the contract for which market data are requested. Contract can be specified either by contract symbol or by contract ID:

  ```js
  {
    "symbol":"ESM7" // Contract is specified by contract symbol
    ...
  }
  // or
  {
    "symbol":123456 // Contract is specified by contract ID
    ...
  }
  ```

  Requests may have additional parameters, which are described in the corresponding sections.

- **Subscribe for market data.**

  Client creates request parameters, specifies request endpoint such as `md/subscribeQuote` and [sends the request](WebSockets.md#client-requests) to Tradovate server.

  Tradovate server sends back a [response message](WebSockets.md#response-message):

  - If a response has an error, client can perform [error handling](Conventions.md#error-handling).

  - If a response is successful, the corresponding subscription is activated and client is going to be provided by market data. Client is responsible to track the contracts for which subscriptions are activated (to properly unsubscribe ). Client can have a single subscription of each type (quotes, DOM, etc) per contract, so no explicit subscription ID is provided.

- **Handle market data.**

  Market data arrive from Tradovate server to client asynchronously as [event messages](WebSockets.md#event-message) of `md` or `chart` types, for example:

  ```js
  {
    "e":"md",
    "d": {
      "quotes": [
        {
          "timestamp":"2017-04-13T04:59:06.588Z",
          "contractId":123456,
          "entries": {
            "Bid": { "price":18405, "size":7 },
            "TotalTradeVolume": { "size":4118 },
            "Offer": { "price":18410, "size":12 },
            "LowPrice": { "price":18355 },
            "Trade": { "price":18405, "size":2 },
            "OpenInterest": { "size":40702 },
            "OpeningPrice": { "price":18515 },
            "HighPrice": { "price":18520 },
            "SettlementPrice": { "price":18520 }
          }
        }
      ]
    }
  }
  ```

- **Unsubscribe from market data.**

  Client creates request parameters, specifies request endpoint such as `md/unsubscribeQuote` and [sends the request](WebSockets.md#client-requests) to Tradovate server.

  Tradovate server sends back a [response message](WebSockets.md#response-message):

  - If a response has an error, client can perform [error handling](Conventions.md#error-handling).

  - If a response is successful, the corresponding subscription is deactivated and no market data are provided to client anymore.

- **Close WebSocket.**

  Client closes a WebSocket. When WebSocket is closed, all active subscriptions are deactivated.


# Request Reference

## *Subscribe Quote*

**Endpoint**: `md/subscribeQuote`

**Parameters**:

```js
{ "symbol": "ESM7" | 123456 }
```

**Data message**

```js
{
  "e":"md",
  "d": {
    "quotes": [ // "quotes" may contain multiple quote objects
      {
        "timestamp":"2017-04-13T04:59:06.588Z",
        "contractId":123456, // ID of the quote contract
        "entries": {
          // Any of entries may absent if no data available for them.
          // Either "price" or "size" field (but not both) may absent in any entries.
          "Bid": { "price":18405, "size":7 },
          "TotalTradeVolume": { "price":18405, "size":7 },
          "Offer": { "price":18410, "size":12 },
          "LowPrice": { "price":18405, "size":7 },
          "Trade": { "price":18405, "size":2 },
          "OpenInterest": { "price":18405, "size":7 },
          "OpeningPrice": { "price":18405, "size":7 },
          "HighPrice": { "price":18405, "size":7 },
          "SettlementPrice": { "price":18405, "size":7 },
          "EmptyBook": { "price":18405, "size":7 }
        }
      }
    ]
  }
}
```

## *Unsubscribe Quote*

**Endpoint**: `md/unsubscribeQuote`

**Parameters**:

```js
{ "symbol": "ESM7" | 123456 }
```


## *Subscribe DOM*

**Endpoint**: `md/subscribeDOM`

**Parameters**:

```js
{ "symbol": "ESM7" | 123456 }
```

**Data message**

```js
{
  "e":"md",
  "d": {
    "doms": [ // "doms" may contain multiple DOM objects
      {
        "contractId":123456, // ID of the DOM contract
        "timestamp":"2017-04-13T11:33:57.488Z",
        "bids": [ // Actual depth of "bids" may varies depending on available data
          {"price":2335.25,"size":33},
          ...
          {"price":2333,"size":758}
        ],
        "offers": [ // Actual depth of "offers" may varies depending on available data
          {"price":2335.5,"size":255},
          ...
          {"price":2337.75,"size":466}
        ]
      }
    ]
  }
}
```


## *Unsubscribe DOM*

**Endpoint**: `md/unsubscribeDOM`

**Parameters**:

```js
{ "symbol": "ESM7" | 123456 }
```


## *Subscribe Histogram*

**Endpoint**: `md/subscribeHistogram`

**Parameters**:

```js
{ "symbol": "ESM7" | 123456 }
```

**Data message**

```js
{
  "e":"md",
  "d": {
    "histograms": [ // "histograms" may contain multiple histogram objects
      {
        "contractId":123456, // ID of the histogram contract
        "timestamp":"2017-04-13T11:33:57.412Z",
        "tradeDate": {
          "year":2017,
          "month":4,
          "day":13
        },
        "base":2338.75,
        "items": { // Actual number of histogram items may depend on data
          "-14":5906,
          ...
          "2":1234,
        },
        "refresh":false
      }
    ]
  }
}
```


## *Unsubscribe Histogram*

**Endpoint**: `md/unsubscribeHistogram`

**Parameters**:

```js
{ "symbol": "ESM7" | 123456 }
```



## *Subscribe Chart*

**Endpoint**: `md/getChart`

**Parameters**:

```js
{
  "symbol":"ESM7" | 123456,
  "chartDescription": {
    "underlyingType":"MinuteBar", // Available values: Tick, DailyBar, MinuteBar, Custom, DOM
    "elementSize":15,
    "elementSizeUnit":"UnderlyingUnits", // Available values: Volume, Range, UnderlyingUnits, Renko, MomentumRange, PointAndFigure, OFARange
    "withHistogram": true | false
  },
  "timeRange": {
    // All fields in "timeRange" are optional, but at least one is required
    "closestTimestamp":"2017-04-13T11:33Z",
    "closestTickId":123,
    "asFarAsTimestamp":"2017-04-13T11:33Z",
    "asMuchAsElements":66
  },
}
```

**Data message**

```js
{
  "e":"chart",
  "d": {
    "charts": [ // "charts" may contain multiple chart objects
      {
        "id":9,
        "td":20170413, // Trade date as a number with value YYYYMMDD
        "bars": [ // "bars" may contain multiple bar objects
          {
            "timestamp":"2017-04-13T11:00:00.000Z",
            "open":2334.25,
            "high":2334.5,
            "low":2333,
            "close":2333.75,
            "upVolume":4712,
            "downVolume":201,
            "upTicks":1333,
            "downTicks":82,
            "bidVolume":2857,
            "offerVolume":2056
          }
        ]
      }
    ]
  }
}
```

## *Unsubscribe Chart*

**Endpoint**: `md/cancelChart`

**Parameters**:

```js
{ "symbol": 123456 }
```
