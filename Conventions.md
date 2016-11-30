# Overview

Tradovate API is a low-level HTTP-based API that you can use to query data,
submit orders, create alerts, receive notifications - almost everything that is
available in Tradovate Trader.

# How it's Structured

Tradovate API can be split to two parts: a set of endpoints to query data and
endpoints to modify (or submit) data. With rare exceptions, endpoint's paths consist of two parts:
entity name and operations. For example, `/account/find` or `/order/cancelorder`.

Tradovate API exposes data with fine granularity to avoid limiting how applications would like
to compose them. It is a responsibility of client applications to request all needed
dependencies and join them. We recommend to cache and reuse received data to avoid h


# Query data

Query operations should use GET HTTP method if called via REST API.

## By ID
All entities that can be requested via API has a unique ID. `item` is an operation
that can be used to get an entity by ID like `/<entity>/item` with `id` as a parameter.
For example,

```
curl -X GET --header 'Accept: application/json' 'https://demo-api-d.tradovate.com/v1/order/item?id=1000'
```

Such methods are translated to .NET reference API in the form `apiInstance.Get<Entity>(id)`:

```c#
  Account result = apiInstance.GetAccount(1000);
```

## All entities at once
The most entities can be loaded as all currently available at once with `list`
operation without parameters. For example,

```
curl -X GET --header 'Accept: application/json' 'https://demo-api-d.tradovate.com/v1/fill/list'
```
```c#
  List<Account> result = apiInstance.GetAllFills();
```

## Via master-details dependency
`deps` operation is intended to load only dependent or owned entities for another entity.
`masterid` parameter should be an ID of `master` entity. For example, all positions
that owned by an account with ID=123:

```
curl -X GET --header 'Accept: application/json' 'https://demo-api-d.tradovate.com/v1/position/deps?masterid=123'
```
```c#
  List<Position> result = apiInstance.GetOwnedPositions(accountId);
```

## By name
Some entities like accounts, products, contracts, currencies have names. Here is
an example of `find` operation with `name` parameter to find a product "ES":

```
curl -X GET --header 'Accept: application/json' 'https://demo-api-d.tradovate.com/v1/product/find?name=ES'
```
```c#
  Product result = apiInstance.FindProduct("ES");
```

## Batch loading
Tradovate API exposes endpoints to load multiple entities in batch. It is more efficiently to
replace multiple `item` operations for the same entity with one `items` operation and pass `ids` parameter
as comma-separated list of id. Note: a number of loaded entities can be less than a number of ids and
a sequence of entities can be different than a sequence of ids.

```
curl -X GET --header 'Accept: application/json' 'https://demo-api-d.tradovate.com/v1/contract/items?ids=840972%2C840944'
```
```c#
  var ids = new List<int?>();
  ...
  List<Contract> result = apiInstance.GetContracts(ids);
```

Similar batching can be applied to `deps` operations: it is faster to run `ldeps`
operation with `masterids` parameter.

# Submit data

For REST API, HTTP POST should be used to submit data. Data should be formatted as a valid JSON
and passed in body.

Naming convention of these operations do not have any general rule and a name of each
operation reflects semantic behind it. For example, `/order/placeorder` is used to create an order and `/order/liquidateposition` - to cancel all orders and exit an specified position. C# sample is [here](https://github.com/tradovate/api/blob/master/csharp/services-api/docs/OrdersApi.md#placeorder)


# Error handling
Tradovate API uses two ways to pass errors to client side: via HTTP status codes
or via custom errorText fields in some endpoints.

HTTP codes are used mostly in situations when required data or an operation is
unavailable (404) or inaccessible (401 or 403).

errorText field in responses is used for business level rejects with textual explanation
of reason.
