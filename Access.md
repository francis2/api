# Overview

Users access the API using client libraries, by making REST requests, or establishing a WebSocket connection.

To access a server, you need to know the location of the server and have credentials to access it. Typically, credentials are automatically set-up when you open a demo account via signup process of regular Tradovate web-site or an application. In future, we intended to open access via OAuth process to help building third-party applications.

We are going to keep locations of Tradovate services without changes as for the development environment as well for the production one.

Development environment:
- live-api-d.tradovate.com: for testing on Live only functionality;
- demo-api-d.tradovate.com: for testing on simulation engine;
- md-api-d.tradovate.com: for testing a market data feed;
- rpt-live-api-d.tradovate.com and rpt-demo-api-d.tradovate.com: to access trading reports.

Production environment: we will provide the most up-to-date locations to production as soon as you are ready to go there.

# Directly accessing the REST API

We support a relaxed version of REST API. We recommend to use GET or POST methods for particular endpoints, but do not force the rule.

All responses are JSON encoded. Request's parameters can be as JSON encoded ones as well as query parameters.

# Access Tokens
Before a client can access a protected resource, it must obtain an access token. The client can either directly exchange its own credentials to an access token, either utilize Google or Facebook social logins. In future, we are going to complete OAuth2 protocol for using by third-party applications without direct access to customer's credentials.

The client uses the "Bearer" authentication scheme to transmit the access token in "Authorization" request header field.

## Get an access token using credentials

```
curl -X POST --header 'Content-Type: application/json' --header 'Accept: application/json' -d '{ \
   "name": "MyUsername", \
   "password": "Secret2Some-", \
   "appId": "SampleApp", \
   "appVersion": "0.7" \
 }' 'https://live-api-d.tradovate.com/v1/auth/accesstokenrequest'

 {
   "accessToken": "ag_8a97la5-T6PqMfUhu-NReEUxW4cFq_dxw-jx6SUWeqqgF6YQ5BIRZK7-rKl0zxXeOUWAYpSZLzFsv11sNlMVza1NDGuKETtTCayV7oIhWpsmg7KSpidMYPBg_J05rC_9vobaw-jA1JuCgrlman_L5G2KCl0choVttLNw",
   "expirationTime": "2016-11-04T12:29:14.514Z",
   "userStatus": "Active",
   "userId": 90,
   "name": "MyUsername"
 }
```

[Try it!](https://swagger.tradovate.com/#!/Authentication/post_auth_accesstokenrequest)

## Social Login with a Google token

Sample TBD

## Use the access token

```
curl -X GET --header 'Accept: application/json' --header 'Authorization: Bearer ag_8a97la5-T6PqMfUhu-NReEUxW4cFq_dxw-jx6SUWeqqgF6YQ5BIRZK7-rKl0zxXeOUWAYpSZLzFsv11sNlMVza1NDGuKETtTCayV7oIhWpsmg7KSpidMYPBg_J05rC_9vobaw-jA1JuCgrlman_L5G2KCl0choVttLNw' 'https://live-api-d.tradovate.com/v1/account/list'

[
  {
    "id": 33,
    "name": "V0314",
    "userId": 90,
    "accountType": "Customer",
    "active": true,
    "clearingHouseId": 1,
    "riskCategoryId": 5,
    "autoLiqProfileId": 1,
    "marginAccountType": "Speculator",
    "legalStatus": "Individual"
  }
]
```

[Try it!](https://swagger.tradovate.com/#!/Accounting/get_account_list)

Note: currently, social logins are not allowed for customers with live accounts.

# Streaming via WebSocket

WebSockets make it possible to open an interactive communication session. With this API, you can send messages to a server and receive event-driven responses without having to poll the server for a reply.
Our protocol over WebSocket uses the same semantics for requests as REST API with some full-duplex extensions. [Here](WebSockets.md) we describe the protocol in details.


# Request rate limits and "time penalty"

We have several limitations for a number of client requests during a time interval. We count a total number of all incoming requests toward hour, minute and second interval. As soon as a limit hit, our server stops handling requests for a period of time and responds on each new request with 429 status code (Too Many Requests).Generally, the limits are high enough to hit them during normal operations.

Some rarely used operations have additional, tight enough constraints. Such operations like requesting an access token, sign up, changing a password or contact information are not supposed for frequent use. If a client reaches that limit, the response is a JSON with fields "p-ticket" and "p-time": it tells the client that the request was not handled and the server imposed a time penalty on the request, the client can retry the call in "p-time" seconds and should include "p-ticket" as an additional parameter of the request.

# Connection limits

We have a limit for a number of simultaneous client connections for one customer and for a number of simultaneously used IP addresses.
Please contact Customer Service to get to know the current limits.

When a customer reaches a limit of connections, the server disconnects the oldest ones.
