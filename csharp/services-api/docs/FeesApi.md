# Tradovate.Services.Api.FeesApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindMarketDataSubscriptionExchangeScope**](FeesApi.md#findmarketdatasubscriptionexchangescope) | **GET** /marketDataSubscriptionExchangeScope/find | 
[**FindMarketDataSubscriptionPlan**](FeesApi.md#findmarketdatasubscriptionplan) | **GET** /marketDataSubscriptionPlan/find | 
[**FindTradovateSubscriptionPlan**](FeesApi.md#findtradovatesubscriptionplan) | **GET** /tradovateSubscriptionPlan/find | 
[**GetAllMarketDataSubscriptionExchangeScopes**](FeesApi.md#getallmarketdatasubscriptionexchangescopes) | **GET** /marketDataSubscriptionExchangeScope/list | 
[**GetAllMarketDataSubscriptionPlans**](FeesApi.md#getallmarketdatasubscriptionplans) | **GET** /marketDataSubscriptionPlan/list | 
[**GetAllTradovateSubscriptionPlans**](FeesApi.md#getalltradovatesubscriptionplans) | **GET** /tradovateSubscriptionPlan/list | 
[**GetMarketDataSubscriptionExchangeScope**](FeesApi.md#getmarketdatasubscriptionexchangescope) | **GET** /marketDataSubscriptionExchangeScope/item | 
[**GetMarketDataSubscriptionExchangeScopes**](FeesApi.md#getmarketdatasubscriptionexchangescopes) | **GET** /marketDataSubscriptionExchangeScope/items | 
[**GetMarketDataSubscriptionPlan**](FeesApi.md#getmarketdatasubscriptionplan) | **GET** /marketDataSubscriptionPlan/item | 
[**GetMarketDataSubscriptionPlans**](FeesApi.md#getmarketdatasubscriptionplans) | **GET** /marketDataSubscriptionPlan/items | 
[**GetTradovateSubscriptionPlan**](FeesApi.md#gettradovatesubscriptionplan) | **GET** /tradovateSubscriptionPlan/item | 
[**GetTradovateSubscriptionPlans**](FeesApi.md#gettradovatesubscriptionplans) | **GET** /tradovateSubscriptionPlan/items | 
[**SuggestMarketDataSubscriptionExchangeScopes**](FeesApi.md#suggestmarketdatasubscriptionexchangescopes) | **GET** /marketDataSubscriptionExchangeScope/suggest | 
[**SuggestMarketDataSubscriptionPlans**](FeesApi.md#suggestmarketdatasubscriptionplans) | **GET** /marketDataSubscriptionPlan/suggest | 
[**SuggestTradovateSubscriptionPlans**](FeesApi.md#suggesttradovatesubscriptionplans) | **GET** /tradovateSubscriptionPlan/suggest | 


<a name="findmarketdatasubscriptionexchangescope"></a>
# **FindMarketDataSubscriptionExchangeScope**
> MarketDataSubscriptionExchangeScope FindMarketDataSubscriptionExchangeScope (string name)



Retrieves an entity of MarketDataSubscriptionExchangeScope type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FindMarketDataSubscriptionExchangeScopeExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var name = name_example;  // string | 

            try
            {
                MarketDataSubscriptionExchangeScope result = apiInstance.FindMarketDataSubscriptionExchangeScope(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.FindMarketDataSubscriptionExchangeScope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**MarketDataSubscriptionExchangeScope**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findmarketdatasubscriptionplan"></a>
# **FindMarketDataSubscriptionPlan**
> MarketDataSubscriptionPlan FindMarketDataSubscriptionPlan (string name)



Retrieves an entity of MarketDataSubscriptionPlan type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FindMarketDataSubscriptionPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var name = name_example;  // string | 

            try
            {
                MarketDataSubscriptionPlan result = apiInstance.FindMarketDataSubscriptionPlan(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.FindMarketDataSubscriptionPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**MarketDataSubscriptionPlan**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtradovatesubscriptionplan"></a>
# **FindTradovateSubscriptionPlan**
> TradovateSubscriptionPlan FindTradovateSubscriptionPlan (string name)



Retrieves an entity of TradovateSubscriptionPlan type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FindTradovateSubscriptionPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var name = name_example;  // string | 

            try
            {
                TradovateSubscriptionPlan result = apiInstance.FindTradovateSubscriptionPlan(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.FindTradovateSubscriptionPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**TradovateSubscriptionPlan**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallmarketdatasubscriptionexchangescopes"></a>
# **GetAllMarketDataSubscriptionExchangeScopes**
> List<MarketDataSubscriptionExchangeScope> GetAllMarketDataSubscriptionExchangeScopes ()



Retrieves all entities of MarketDataSubscriptionExchangeScope type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllMarketDataSubscriptionExchangeScopesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();

            try
            {
                List&lt;MarketDataSubscriptionExchangeScope&gt; result = apiInstance.GetAllMarketDataSubscriptionExchangeScopes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetAllMarketDataSubscriptionExchangeScopes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MarketDataSubscriptionExchangeScope>**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallmarketdatasubscriptionplans"></a>
# **GetAllMarketDataSubscriptionPlans**
> List<MarketDataSubscriptionPlan> GetAllMarketDataSubscriptionPlans ()



Retrieves all entities of MarketDataSubscriptionPlan type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllMarketDataSubscriptionPlansExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();

            try
            {
                List&lt;MarketDataSubscriptionPlan&gt; result = apiInstance.GetAllMarketDataSubscriptionPlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetAllMarketDataSubscriptionPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MarketDataSubscriptionPlan>**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalltradovatesubscriptionplans"></a>
# **GetAllTradovateSubscriptionPlans**
> List<TradovateSubscriptionPlan> GetAllTradovateSubscriptionPlans ()



Retrieves all entities of TradovateSubscriptionPlan type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllTradovateSubscriptionPlansExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();

            try
            {
                List&lt;TradovateSubscriptionPlan&gt; result = apiInstance.GetAllTradovateSubscriptionPlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetAllTradovateSubscriptionPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TradovateSubscriptionPlan>**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketdatasubscriptionexchangescope"></a>
# **GetMarketDataSubscriptionExchangeScope**
> MarketDataSubscriptionExchangeScope GetMarketDataSubscriptionExchangeScope (int? id)



Retrieves an entity of MarketDataSubscriptionExchangeScope type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetMarketDataSubscriptionExchangeScopeExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var id = 56;  // int? | 

            try
            {
                MarketDataSubscriptionExchangeScope result = apiInstance.GetMarketDataSubscriptionExchangeScope(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetMarketDataSubscriptionExchangeScope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

[**MarketDataSubscriptionExchangeScope**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketdatasubscriptionexchangescopes"></a>
# **GetMarketDataSubscriptionExchangeScopes**
> List<MarketDataSubscriptionExchangeScope> GetMarketDataSubscriptionExchangeScopes (List<int?> ids)



Retrieves multiple entities of MarketDataSubscriptionExchangeScope type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetMarketDataSubscriptionExchangeScopesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;MarketDataSubscriptionExchangeScope&gt; result = apiInstance.GetMarketDataSubscriptionExchangeScopes(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetMarketDataSubscriptionExchangeScopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<int?>**](int?.md)|  | 

### Return type

[**List<MarketDataSubscriptionExchangeScope>**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketdatasubscriptionplan"></a>
# **GetMarketDataSubscriptionPlan**
> MarketDataSubscriptionPlan GetMarketDataSubscriptionPlan (int? id)



Retrieves an entity of MarketDataSubscriptionPlan type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetMarketDataSubscriptionPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var id = 56;  // int? | 

            try
            {
                MarketDataSubscriptionPlan result = apiInstance.GetMarketDataSubscriptionPlan(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetMarketDataSubscriptionPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

[**MarketDataSubscriptionPlan**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketdatasubscriptionplans"></a>
# **GetMarketDataSubscriptionPlans**
> List<MarketDataSubscriptionPlan> GetMarketDataSubscriptionPlans (List<int?> ids)



Retrieves multiple entities of MarketDataSubscriptionPlan type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetMarketDataSubscriptionPlansExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;MarketDataSubscriptionPlan&gt; result = apiInstance.GetMarketDataSubscriptionPlans(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetMarketDataSubscriptionPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<int?>**](int?.md)|  | 

### Return type

[**List<MarketDataSubscriptionPlan>**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettradovatesubscriptionplan"></a>
# **GetTradovateSubscriptionPlan**
> TradovateSubscriptionPlan GetTradovateSubscriptionPlan (int? id)



Retrieves an entity of TradovateSubscriptionPlan type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetTradovateSubscriptionPlanExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var id = 56;  // int? | 

            try
            {
                TradovateSubscriptionPlan result = apiInstance.GetTradovateSubscriptionPlan(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetTradovateSubscriptionPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

[**TradovateSubscriptionPlan**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettradovatesubscriptionplans"></a>
# **GetTradovateSubscriptionPlans**
> List<TradovateSubscriptionPlan> GetTradovateSubscriptionPlans (List<int?> ids)



Retrieves multiple entities of TradovateSubscriptionPlan type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetTradovateSubscriptionPlansExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;TradovateSubscriptionPlan&gt; result = apiInstance.GetTradovateSubscriptionPlans(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.GetTradovateSubscriptionPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<int?>**](int?.md)|  | 

### Return type

[**List<TradovateSubscriptionPlan>**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggestmarketdatasubscriptionexchangescopes"></a>
# **SuggestMarketDataSubscriptionExchangeScopes**
> List<MarketDataSubscriptionExchangeScope> SuggestMarketDataSubscriptionExchangeScopes (string t, int? l)



Retrieves entities of MarketDataSubscriptionExchangeScope type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SuggestMarketDataSubscriptionExchangeScopesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;MarketDataSubscriptionExchangeScope&gt; result = apiInstance.SuggestMarketDataSubscriptionExchangeScopes(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.SuggestMarketDataSubscriptionExchangeScopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **t** | **string**| Text | 
 **l** | **int?**| Max number of entities | 

### Return type

[**List<MarketDataSubscriptionExchangeScope>**](MarketDataSubscriptionExchangeScope.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggestmarketdatasubscriptionplans"></a>
# **SuggestMarketDataSubscriptionPlans**
> List<MarketDataSubscriptionPlan> SuggestMarketDataSubscriptionPlans (string t, int? l)



Retrieves entities of MarketDataSubscriptionPlan type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SuggestMarketDataSubscriptionPlansExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;MarketDataSubscriptionPlan&gt; result = apiInstance.SuggestMarketDataSubscriptionPlans(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.SuggestMarketDataSubscriptionPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **t** | **string**| Text | 
 **l** | **int?**| Max number of entities | 

### Return type

[**List<MarketDataSubscriptionPlan>**](MarketDataSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggesttradovatesubscriptionplans"></a>
# **SuggestTradovateSubscriptionPlans**
> List<TradovateSubscriptionPlan> SuggestTradovateSubscriptionPlans (string t, int? l)



Retrieves entities of TradovateSubscriptionPlan type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SuggestTradovateSubscriptionPlansExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new FeesApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;TradovateSubscriptionPlan&gt; result = apiInstance.SuggestTradovateSubscriptionPlans(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeesApi.SuggestTradovateSubscriptionPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **t** | **string**| Text | 
 **l** | **int?**| Max number of entities | 

### Return type

[**List<TradovateSubscriptionPlan>**](TradovateSubscriptionPlan.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

