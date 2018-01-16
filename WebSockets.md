# Overview

The current version of our WebSocket-based protocol is inherited from [SockJS protocol](http://sockjs.github.io/sockjs-protocol/sockjs-protocol-0.3.3.html#section-42) that was used in earlier versions.

# URL

URL for Websocket should be composed as wss://[API].tradovate.com/v1/websocket
Possible values for [API] can be found here: https://github.com/tradovate/api/blob/master/Access.md#overview

# Server frames

The server can send the next type of frames (from SockJS documentation):

```
o - Open frame. Every time a new session is established, the server must immediately send the open frame. This is required, as some protocols (mostly polling) can't distinguish between a properly established connection and a broken one - we must convince the client that it is indeed a valid url and it can be expecting further messages in the future on that url.

h - Heartbeat frame. Most loadbalancers have arbitrary timeouts on connections. In order to keep connections from breaking, the server must send a heartbeat frame every now and then. The typical delay is 25 seconds and should be configurable.

a - Array of json-encoded messages. For example: a["message"].

c - Close frame. This frame is send to the browser every time the client asks for data on closed connection. This may happen multiple times. Close frame contains a code and a string explaining a reason of closure, like: c[3000,"Go away!"].
```

Tradovate uses 'a' frames as a backbone for own message protocol.

Like these two frames:
```
a[{"s":200,"i":23,"d":{"id":65543,"name":"CLZ6","contractMaturityId":6727}}]
a[{"e":"props","d":{"entityType":"order","eventType":"Created","entity":{"id":210518,"accountId":25,"contractId":560901,"timestamp":"2016-11-04T00:02:36.626Z","action":"Sell","ordStatus":"PendingNew","admin":false}}}]
```

Each item of the array is an JSON object that represents a message.
There are two categories of messages: server events and responses for client request.

## Event message

An event message has the next structure:

```
{
  "e":"props",
  "d":{
    "entityType":"order",
    "eventType":"Created",
    "entity":{
      "id":210518,
      "accountId":25,
      "contractId":560901,
      "timestamp":"2016-11-04T00:02:36.626Z",
      "action":"Sell",
      "ordStatus":"PendingNew",
      "admin":false
    }
  }
}
```

"e" field specifies an event kind:
- "props": this is a notification that some entity was created, updated or deleted. "d" field specifies details of the event with the next structure:
  * "entityType" field
  * "entity" field. JSON structure of object specified in this field is identical to JSON of entity that accessible via corresponding REST API request like *entityType*/item. For example, if entityType=account, JSON can be found in the [response specification of account/item call](https://swagger.tradovate.com/#!/Accounting/get_account_item)
  * "eventType" field with options "Created", "Updated" or "Deleted"
- "shutdown": a notification before graceful shutdown of connection. "d" field specifies details:
  * "reasonCode" field with options "Maintenance", "ConnectionQuotaReached", "IPQuotaReached"
  * "reason" field is optional and may contain a readable explanation
- "md" and "chart": these notifications are used by market data feed services only, the description of "d" field is [here](MarketData.md)

## Response message

A response message is intended to mimic REST API responses and has the next structure:

```
{
  "i":26,
  "s":200,
  "d":{
    "id":478866,
    "name":"6EZ6",
    "contractMaturityId":23574
  }
}
```
- "i" field is a id of corresponding client request (see "Client requests" below)
- "s" field is a HTTP status code of response
- "d" field is a content of response. If HTTP status is 2xx, this field contains JSON response as defined in Swagger specification of the corresponding request. Otherwise, "d" is a string representation of error text.

# Client requests

SockJS doesn't define framing for client requests and we use our message protocol as regular text frames.

Each frame sent by client contains exactly one request. The frame consists of four fields:
- an endpoint name as defined in [Swagger specification](https://swagger.tradovate.com)
- a unique integer id of the request. The id should be unique in the scope of the current connection. This id will be used as a reference by server in the response messages (see "Response message" above)
- an optional field with parameters that identical to query parameters of REST API
- an optional field that is identical to a body parameter of REST API

Fields are separated by \n ("new line") character.

An example of request without query and body

```
executionReport/list
4

```

An example of request with a query parameter

```
tradingPermission/ldeps
8
masterids=1
```

An example of request with a body

```
contract/rollcontract
33

{"name":"YMZ6","forward":true,"ifExpired":true}
```

## Authorization

Because WebSocket is a permanent connection, it is enough to authorize the connection just once.
We use a special request with "authorize" endpoint and an access token in body.

```
authorize
2

uST01MhJMF3cR3lCs-gdQ9W0AzomYLaqsWcZ_GYgAspPRf-ZS-Wb7q3sW3pUafTm90ba4
```

Successful response for it should have status = 200 like that:

```
a[{"s":200,"i":2}]
```

## Client heartbeats

Even WebSockets have built-in pings, a client is responsible to send heartbeats every 2.5 seconds to avoid closing by server due to inactivity. Heartbeat should be a frame with "[]" (empty array) text.

## Reference implementation

[Here](csharp/services-api/src/Tradovate.Services/Client/WebSocketClient.cs) is a reference C# implementation.
