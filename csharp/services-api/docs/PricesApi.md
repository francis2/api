# Tradovate.Services.Api.PricesApi

All URIs are relative to *https://live-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AlterHistogramSubscription**](PricesApi.md#alterhistogramsubscription) | **POST** /md/alterhistogramsubscription | 
[**AlterQuoteSubscription**](PricesApi.md#alterquotesubscription) | **POST** /md/alterquotesubscription | 
[**CancelChart**](PricesApi.md#cancelchart) | **POST** /md/cancelchart | 
[**GetChart**](PricesApi.md#getchart) | **POST** /md/getchart | 
[**SubscribeDOM**](PricesApi.md#subscribedom) | **POST** /md/subscribedom | 


<a name="alterhistogramsubscription"></a>
# **AlterHistogramSubscription**
> MarketDataSubscriptionResult AlterHistogramSubscription (AlterHistogramSubscription body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlterHistogramSubscriptionExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PricesApi();
            var body = new AlterHistogramSubscription(); // AlterHistogramSubscription | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.AlterHistogramSubscription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.AlterHistogramSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlterHistogramSubscription**](AlterHistogramSubscription.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="alterquotesubscription"></a>
# **AlterQuoteSubscription**
> MarketDataSubscriptionResult AlterQuoteSubscription (AlterQuoteSubscription body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AlterQuoteSubscriptionExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PricesApi();
            var body = new AlterQuoteSubscription(); // AlterQuoteSubscription | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.AlterQuoteSubscription(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.AlterQuoteSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlterQuoteSubscription**](AlterQuoteSubscription.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelchart"></a>
# **CancelChart**
> MarketDataSubscriptionResult CancelChart (CancelChart body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CancelChartExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PricesApi();
            var body = new CancelChart(); // CancelChart | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.CancelChart(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.CancelChart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CancelChart**](CancelChart.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchart"></a>
# **GetChart**
> ChartSubscriptionResult GetChart (GetChart body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetChartExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PricesApi();
            var body = new GetChart(); // GetChart | 

            try
            {
                ChartSubscriptionResult result = apiInstance.GetChart(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.GetChart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetChart**](GetChart.md)|  | 

### Return type

[**ChartSubscriptionResult**](ChartSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribedom"></a>
# **SubscribeDOM**
> MarketDataSubscriptionResult SubscribeDOM (SubscribeDOM body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SubscribeDOMExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new PricesApi();
            var body = new SubscribeDOM(); // SubscribeDOM | 

            try
            {
                MarketDataSubscriptionResult result = apiInstance.SubscribeDOM(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.SubscribeDOM: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscribeDOM**](SubscribeDOM.md)|  | 

### Return type

[**MarketDataSubscriptionResult**](MarketDataSubscriptionResult.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

