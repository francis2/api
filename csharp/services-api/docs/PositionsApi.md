# Tradovate.Services.Api.PositionsApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindPosition**](PositionsApi.md#findposition) | **GET** /position/find | 
[**GetAllFillPairs**](PositionsApi.md#getallfillpairs) | **GET** /fillPair/list | 
[**GetAllPositions**](PositionsApi.md#getallpositions) | **GET** /position/list | 
[**GetFillPair**](PositionsApi.md#getfillpair) | **GET** /fillPair/item | 
[**GetFillPairs**](PositionsApi.md#getfillpairs) | **GET** /fillPair/items | 
[**GetOwnedFillPairs**](PositionsApi.md#getownedfillpairs) | **GET** /fillPair/deps | 
[**GetOwnedFillPairsBatch**](PositionsApi.md#getownedfillpairsbatch) | **GET** /fillPair/ldeps | 
[**GetOwnedPositions**](PositionsApi.md#getownedpositions) | **GET** /position/deps | 
[**GetOwnedPositionsBatch**](PositionsApi.md#getownedpositionsbatch) | **GET** /position/ldeps | 
[**GetPosition**](PositionsApi.md#getposition) | **GET** /position/item | 
[**GetPositions**](PositionsApi.md#getpositions) | **GET** /position/items | 


<a name="findposition"></a>
# **FindPosition**
> Position FindPosition (string name)



Retrieves an entity of Position type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FindPositionExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();
            var name = name_example;  // string | 

            try
            {
                Position result = apiInstance.FindPosition(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.FindPosition: " + e.Message );
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

[**Position**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallfillpairs"></a>
# **GetAllFillPairs**
> List<FillPair> GetAllFillPairs ()



Retrieves all entities of FillPair type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllFillPairsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();

            try
            {
                List&lt;FillPair&gt; result = apiInstance.GetAllFillPairs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetAllFillPairs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FillPair>**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallpositions"></a>
# **GetAllPositions**
> List<Position> GetAllPositions ()



Retrieves all entities of Position type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllPositionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();

            try
            {
                List&lt;Position&gt; result = apiInstance.GetAllPositions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetAllPositions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Position>**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfillpair"></a>
# **GetFillPair**
> FillPair GetFillPair (int? id)



Retrieves an entity of FillPair type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetFillPairExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();
            var id = 56;  // int? | 

            try
            {
                FillPair result = apiInstance.GetFillPair(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetFillPair: " + e.Message );
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

[**FillPair**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfillpairs"></a>
# **GetFillPairs**
> List<FillPair> GetFillPairs (List<int?> ids)



Retrieves multiple entities of FillPair type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetFillPairsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;FillPair&gt; result = apiInstance.GetFillPairs(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetFillPairs: " + e.Message );
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

[**List<FillPair>**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedfillpairs"></a>
# **GetOwnedFillPairs**
> List<FillPair> GetOwnedFillPairs (int? masterid)



Retrieves all entities of FillPair type related to Position entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedFillPairsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();
            var masterid = 56;  // int? | id of Position entity

            try
            {
                List&lt;FillPair&gt; result = apiInstance.GetOwnedFillPairs(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetOwnedFillPairs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of Position entity | 

### Return type

[**List<FillPair>**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedfillpairsbatch"></a>
# **GetOwnedFillPairsBatch**
> List<FillPair> GetOwnedFillPairsBatch (List<int?> masterids)



Retrieves all entities of FillPair type related to multiple entities of Position type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedFillPairsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();
            var masterids = new List<int?>(); // List<int?> | ids of Position entities

            try
            {
                List&lt;FillPair&gt; result = apiInstance.GetOwnedFillPairsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetOwnedFillPairsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of Position entities | 

### Return type

[**List<FillPair>**](FillPair.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedpositions"></a>
# **GetOwnedPositions**
> List<Position> GetOwnedPositions (int? masterid)



Retrieves all entities of Position type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedPositionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();
            var masterid = 56;  // int? | id of Account entity

            try
            {
                List&lt;Position&gt; result = apiInstance.GetOwnedPositions(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetOwnedPositions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of Account entity | 

### Return type

[**List<Position>**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedpositionsbatch"></a>
# **GetOwnedPositionsBatch**
> List<Position> GetOwnedPositionsBatch (List<int?> masterids)



Retrieves all entities of Position type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedPositionsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();
            var masterids = new List<int?>(); // List<int?> | ids of Account entities

            try
            {
                List&lt;Position&gt; result = apiInstance.GetOwnedPositionsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetOwnedPositionsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of Account entities | 

### Return type

[**List<Position>**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getposition"></a>
# **GetPosition**
> Position GetPosition (int? id)



Retrieves an entity of Position type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetPositionExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();
            var id = 56;  // int? | 

            try
            {
                Position result = apiInstance.GetPosition(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetPosition: " + e.Message );
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

[**Position**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpositions"></a>
# **GetPositions**
> List<Position> GetPositions (List<int?> ids)



Retrieves multiple entities of Position type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetPositionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PositionsApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Position&gt; result = apiInstance.GetPositions(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PositionsApi.GetPositions: " + e.Message );
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

[**List<Position>**](Position.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

