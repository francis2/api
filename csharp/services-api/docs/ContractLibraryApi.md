# Tradovate.Services.Api.ContractLibraryApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindContract**](ContractLibraryApi.md#findcontract) | **GET** /contract/find | 
[**FindContractGroup**](ContractLibraryApi.md#findcontractgroup) | **GET** /contractGroup/find | 
[**FindCurrency**](ContractLibraryApi.md#findcurrency) | **GET** /currency/find | 
[**FindExchange**](ContractLibraryApi.md#findexchange) | **GET** /exchange/find | 
[**FindProduct**](ContractLibraryApi.md#findproduct) | **GET** /product/find | 
[**GetAllContractGroups**](ContractLibraryApi.md#getallcontractgroups) | **GET** /contractGroup/list | 
[**GetAllCurrencies**](ContractLibraryApi.md#getallcurrencies) | **GET** /currency/list | 
[**GetAllCurrencyRates**](ContractLibraryApi.md#getallcurrencyrates) | **GET** /currencyRate/list | 
[**GetAllExchanges**](ContractLibraryApi.md#getallexchanges) | **GET** /exchange/list | 
[**GetAllProducts**](ContractLibraryApi.md#getallproducts) | **GET** /product/list | 
[**GetContract**](ContractLibraryApi.md#getcontract) | **GET** /contract/item | 
[**GetContractGroup**](ContractLibraryApi.md#getcontractgroup) | **GET** /contractGroup/item | 
[**GetContractGroups**](ContractLibraryApi.md#getcontractgroups) | **GET** /contractGroup/items | 
[**GetContractMaturities**](ContractLibraryApi.md#getcontractmaturities) | **GET** /contractMaturity/items | 
[**GetContractMaturity**](ContractLibraryApi.md#getcontractmaturity) | **GET** /contractMaturity/item | 
[**GetContracts**](ContractLibraryApi.md#getcontracts) | **GET** /contract/items | 
[**GetCurrencies**](ContractLibraryApi.md#getcurrencies) | **GET** /currency/items | 
[**GetCurrency**](ContractLibraryApi.md#getcurrency) | **GET** /currency/item | 
[**GetCurrencyRate**](ContractLibraryApi.md#getcurrencyrate) | **GET** /currencyRate/item | 
[**GetCurrencyRates**](ContractLibraryApi.md#getcurrencyrates) | **GET** /currencyRate/items | 
[**GetExchange**](ContractLibraryApi.md#getexchange) | **GET** /exchange/item | 
[**GetExchanges**](ContractLibraryApi.md#getexchanges) | **GET** /exchange/items | 
[**GetOwnedContractMaturities**](ContractLibraryApi.md#getownedcontractmaturities) | **GET** /contractMaturity/deps | 
[**GetOwnedContractMaturitiesBatch**](ContractLibraryApi.md#getownedcontractmaturitiesbatch) | **GET** /contractMaturity/ldeps | 
[**GetOwnedContracts**](ContractLibraryApi.md#getownedcontracts) | **GET** /contract/deps | 
[**GetOwnedContractsBatch**](ContractLibraryApi.md#getownedcontractsbatch) | **GET** /contract/ldeps | 
[**GetOwnedCurrencyRates**](ContractLibraryApi.md#getownedcurrencyrates) | **GET** /currencyRate/deps | 
[**GetOwnedCurrencyRatesBatch**](ContractLibraryApi.md#getownedcurrencyratesbatch) | **GET** /currencyRate/ldeps | 
[**GetOwnedProductSessions**](ContractLibraryApi.md#getownedproductsessions) | **GET** /productSession/deps | 
[**GetOwnedProductSessionsBatch**](ContractLibraryApi.md#getownedproductsessionsbatch) | **GET** /productSession/ldeps | 
[**GetOwnedProducts**](ContractLibraryApi.md#getownedproducts) | **GET** /product/deps | 
[**GetOwnedProductsBatch**](ContractLibraryApi.md#getownedproductsbatch) | **GET** /product/ldeps | 
[**GetProduct**](ContractLibraryApi.md#getproduct) | **GET** /product/item | 
[**GetProductFeeParams**](ContractLibraryApi.md#getproductfeeparams) | **POST** /contract/getproductfeeparams | 
[**GetProductSession**](ContractLibraryApi.md#getproductsession) | **GET** /productSession/item | 
[**GetProductSessions**](ContractLibraryApi.md#getproductsessions) | **GET** /productSession/items | 
[**GetProducts**](ContractLibraryApi.md#getproducts) | **GET** /product/items | 
[**GetSpreadDefinition**](ContractLibraryApi.md#getspreaddefinition) | **GET** /spreadDefinition/item | 
[**GetSpreadDefinitions**](ContractLibraryApi.md#getspreaddefinitions) | **GET** /spreadDefinition/items | 
[**RollContract**](ContractLibraryApi.md#rollcontract) | **POST** /contract/rollcontract | 
[**SuggestContractGroups**](ContractLibraryApi.md#suggestcontractgroups) | **GET** /contractGroup/suggest | 
[**SuggestContracts**](ContractLibraryApi.md#suggestcontracts) | **GET** /contract/suggest | 
[**SuggestCurrencies**](ContractLibraryApi.md#suggestcurrencies) | **GET** /currency/suggest | 
[**SuggestExchanges**](ContractLibraryApi.md#suggestexchanges) | **GET** /exchange/suggest | 
[**SuggestProducts**](ContractLibraryApi.md#suggestproducts) | **GET** /product/suggest | 


<a name="findcontract"></a>
# **FindContract**
> Contract FindContract (string name)



Retrieves an entity of Contract type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FindContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                Contract result = apiInstance.FindContract(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.FindContract: " + e.Message );
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

[**Contract**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findcontractgroup"></a>
# **FindContractGroup**
> ContractGroup FindContractGroup (string name)



Retrieves an entity of ContractGroup type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FindContractGroupExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                ContractGroup result = apiInstance.FindContractGroup(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.FindContractGroup: " + e.Message );
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

[**ContractGroup**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findcurrency"></a>
# **FindCurrency**
> Currency FindCurrency (string name)



Retrieves an entity of Currency type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FindCurrencyExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                Currency result = apiInstance.FindCurrency(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.FindCurrency: " + e.Message );
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

[**Currency**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findexchange"></a>
# **FindExchange**
> Exchange FindExchange (string name)



Retrieves an entity of Exchange type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FindExchangeExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                Exchange result = apiInstance.FindExchange(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.FindExchange: " + e.Message );
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

[**Exchange**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findproduct"></a>
# **FindProduct**
> Product FindProduct (string name)



Retrieves an entity of Product type by its name

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class FindProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var name = name_example;  // string | 

            try
            {
                Product result = apiInstance.FindProduct(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.FindProduct: " + e.Message );
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

[**Product**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcontractgroups"></a>
# **GetAllContractGroups**
> List<ContractGroup> GetAllContractGroups ()



Retrieves all entities of ContractGroup type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllContractGroupsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;ContractGroup&gt; result = apiInstance.GetAllContractGroups();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetAllContractGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ContractGroup>**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcurrencies"></a>
# **GetAllCurrencies**
> List<Currency> GetAllCurrencies ()



Retrieves all entities of Currency type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllCurrenciesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;Currency&gt; result = apiInstance.GetAllCurrencies();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetAllCurrencies: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Currency>**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcurrencyrates"></a>
# **GetAllCurrencyRates**
> List<CurrencyRate> GetAllCurrencyRates ()



Retrieves all entities of CurrencyRate type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllCurrencyRatesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;CurrencyRate&gt; result = apiInstance.GetAllCurrencyRates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetAllCurrencyRates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CurrencyRate>**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallexchanges"></a>
# **GetAllExchanges**
> List<Exchange> GetAllExchanges ()



Retrieves all entities of Exchange type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllExchangesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;Exchange&gt; result = apiInstance.GetAllExchanges();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetAllExchanges: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Exchange>**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallproducts"></a>
# **GetAllProducts**
> List<Product> GetAllProducts ()



Retrieves all entities of Product type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllProductsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();

            try
            {
                List&lt;Product&gt; result = apiInstance.GetAllProducts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetAllProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontract"></a>
# **GetContract**
> Contract GetContract (int? id)



Retrieves an entity of Contract type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var id = 56;  // int? | 

            try
            {
                Contract result = apiInstance.GetContract(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetContract: " + e.Message );
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

[**Contract**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractgroup"></a>
# **GetContractGroup**
> ContractGroup GetContractGroup (int? id)



Retrieves an entity of ContractGroup type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetContractGroupExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var id = 56;  // int? | 

            try
            {
                ContractGroup result = apiInstance.GetContractGroup(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetContractGroup: " + e.Message );
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

[**ContractGroup**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractgroups"></a>
# **GetContractGroups**
> List<ContractGroup> GetContractGroups (List<int?> ids)



Retrieves multiple entities of ContractGroup type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetContractGroupsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;ContractGroup&gt; result = apiInstance.GetContractGroups(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetContractGroups: " + e.Message );
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

[**List<ContractGroup>**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractmaturities"></a>
# **GetContractMaturities**
> List<ContractMaturity> GetContractMaturities (List<int?> ids)



Retrieves multiple entities of ContractMaturity type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetContractMaturitiesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;ContractMaturity&gt; result = apiInstance.GetContractMaturities(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetContractMaturities: " + e.Message );
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

[**List<ContractMaturity>**](ContractMaturity.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractmaturity"></a>
# **GetContractMaturity**
> ContractMaturity GetContractMaturity (int? id)



Retrieves an entity of ContractMaturity type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetContractMaturityExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var id = 56;  // int? | 

            try
            {
                ContractMaturity result = apiInstance.GetContractMaturity(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetContractMaturity: " + e.Message );
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

[**ContractMaturity**](ContractMaturity.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontracts"></a>
# **GetContracts**
> List<Contract> GetContracts (List<int?> ids)



Retrieves multiple entities of Contract type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetContractsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Contract&gt; result = apiInstance.GetContracts(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetContracts: " + e.Message );
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

[**List<Contract>**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencies"></a>
# **GetCurrencies**
> List<Currency> GetCurrencies (List<int?> ids)



Retrieves multiple entities of Currency type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetCurrenciesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Currency&gt; result = apiInstance.GetCurrencies(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetCurrencies: " + e.Message );
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

[**List<Currency>**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrency"></a>
# **GetCurrency**
> Currency GetCurrency (int? id)



Retrieves an entity of Currency type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetCurrencyExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var id = 56;  // int? | 

            try
            {
                Currency result = apiInstance.GetCurrency(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetCurrency: " + e.Message );
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

[**Currency**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencyrate"></a>
# **GetCurrencyRate**
> CurrencyRate GetCurrencyRate (int? id)



Retrieves an entity of CurrencyRate type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetCurrencyRateExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var id = 56;  // int? | 

            try
            {
                CurrencyRate result = apiInstance.GetCurrencyRate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetCurrencyRate: " + e.Message );
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

[**CurrencyRate**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrencyrates"></a>
# **GetCurrencyRates**
> List<CurrencyRate> GetCurrencyRates (List<int?> ids)



Retrieves multiple entities of CurrencyRate type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetCurrencyRatesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;CurrencyRate&gt; result = apiInstance.GetCurrencyRates(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetCurrencyRates: " + e.Message );
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

[**List<CurrencyRate>**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexchange"></a>
# **GetExchange**
> Exchange GetExchange (int? id)



Retrieves an entity of Exchange type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetExchangeExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var id = 56;  // int? | 

            try
            {
                Exchange result = apiInstance.GetExchange(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetExchange: " + e.Message );
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

[**Exchange**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexchanges"></a>
# **GetExchanges**
> List<Exchange> GetExchanges (List<int?> ids)



Retrieves multiple entities of Exchange type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetExchangesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Exchange&gt; result = apiInstance.GetExchanges(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetExchanges: " + e.Message );
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

[**List<Exchange>**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedcontractmaturities"></a>
# **GetOwnedContractMaturities**
> List<ContractMaturity> GetOwnedContractMaturities (int? masterid)



Retrieves all entities of ContractMaturity type related to Product entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedContractMaturitiesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterid = 56;  // int? | id of Product entity

            try
            {
                List&lt;ContractMaturity&gt; result = apiInstance.GetOwnedContractMaturities(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedContractMaturities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of Product entity | 

### Return type

[**List<ContractMaturity>**](ContractMaturity.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedcontractmaturitiesbatch"></a>
# **GetOwnedContractMaturitiesBatch**
> List<ContractMaturity> GetOwnedContractMaturitiesBatch (List<int?> masterids)



Retrieves all entities of ContractMaturity type related to multiple entities of Product type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedContractMaturitiesBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<int?>(); // List<int?> | ids of Product entities

            try
            {
                List&lt;ContractMaturity&gt; result = apiInstance.GetOwnedContractMaturitiesBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedContractMaturitiesBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of Product entities | 

### Return type

[**List<ContractMaturity>**](ContractMaturity.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedcontracts"></a>
# **GetOwnedContracts**
> List<Contract> GetOwnedContracts (int? masterid)



Retrieves all entities of Contract type related to ContractMaturity entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedContractsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterid = 56;  // int? | id of ContractMaturity entity

            try
            {
                List&lt;Contract&gt; result = apiInstance.GetOwnedContracts(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedContracts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of ContractMaturity entity | 

### Return type

[**List<Contract>**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedcontractsbatch"></a>
# **GetOwnedContractsBatch**
> List<Contract> GetOwnedContractsBatch (List<int?> masterids)



Retrieves all entities of Contract type related to multiple entities of ContractMaturity type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedContractsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<int?>(); // List<int?> | ids of ContractMaturity entities

            try
            {
                List&lt;Contract&gt; result = apiInstance.GetOwnedContractsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedContractsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of ContractMaturity entities | 

### Return type

[**List<Contract>**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedcurrencyrates"></a>
# **GetOwnedCurrencyRates**
> List<CurrencyRate> GetOwnedCurrencyRates (int? masterid)



Retrieves all entities of CurrencyRate type related to Currency entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedCurrencyRatesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterid = 56;  // int? | id of Currency entity

            try
            {
                List&lt;CurrencyRate&gt; result = apiInstance.GetOwnedCurrencyRates(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedCurrencyRates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of Currency entity | 

### Return type

[**List<CurrencyRate>**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedcurrencyratesbatch"></a>
# **GetOwnedCurrencyRatesBatch**
> List<CurrencyRate> GetOwnedCurrencyRatesBatch (List<int?> masterids)



Retrieves all entities of CurrencyRate type related to multiple entities of Currency type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedCurrencyRatesBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<int?>(); // List<int?> | ids of Currency entities

            try
            {
                List&lt;CurrencyRate&gt; result = apiInstance.GetOwnedCurrencyRatesBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedCurrencyRatesBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of Currency entities | 

### Return type

[**List<CurrencyRate>**](CurrencyRate.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedproductsessions"></a>
# **GetOwnedProductSessions**
> List<ProductSession> GetOwnedProductSessions (int? masterid)



Retrieves all entities of ProductSession type related to Product entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedProductSessionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterid = 56;  // int? | id of Product entity

            try
            {
                List&lt;ProductSession&gt; result = apiInstance.GetOwnedProductSessions(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedProductSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of Product entity | 

### Return type

[**List<ProductSession>**](ProductSession.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedproductsessionsbatch"></a>
# **GetOwnedProductSessionsBatch**
> List<ProductSession> GetOwnedProductSessionsBatch (List<int?> masterids)



Retrieves all entities of ProductSession type related to multiple entities of Product type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedProductSessionsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<int?>(); // List<int?> | ids of Product entities

            try
            {
                List&lt;ProductSession&gt; result = apiInstance.GetOwnedProductSessionsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedProductSessionsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of Product entities | 

### Return type

[**List<ProductSession>**](ProductSession.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedproducts"></a>
# **GetOwnedProducts**
> List<Product> GetOwnedProducts (int? masterid)



Retrieves all entities of Product type related to Exchange entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedProductsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterid = 56;  // int? | id of Exchange entity

            try
            {
                List&lt;Product&gt; result = apiInstance.GetOwnedProducts(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of Exchange entity | 

### Return type

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedproductsbatch"></a>
# **GetOwnedProductsBatch**
> List<Product> GetOwnedProductsBatch (List<int?> masterids)



Retrieves all entities of Product type related to multiple entities of Exchange type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedProductsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var masterids = new List<int?>(); // List<int?> | ids of Exchange entities

            try
            {
                List&lt;Product&gt; result = apiInstance.GetOwnedProductsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetOwnedProductsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of Exchange entities | 

### Return type

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproduct"></a>
# **GetProduct**
> Product GetProduct (int? id)



Retrieves an entity of Product type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var id = 56;  // int? | 

            try
            {
                Product result = apiInstance.GetProduct(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetProduct: " + e.Message );
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

[**Product**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductfeeparams"></a>
# **GetProductFeeParams**
> ProductFeeParamsResponse GetProductFeeParams (GetProductFeeParams body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetProductFeeParamsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var body = new GetProductFeeParams(); // GetProductFeeParams | 

            try
            {
                ProductFeeParamsResponse result = apiInstance.GetProductFeeParams(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetProductFeeParams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GetProductFeeParams**](GetProductFeeParams.md)|  | 

### Return type

[**ProductFeeParamsResponse**](ProductFeeParamsResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsession"></a>
# **GetProductSession**
> ProductSession GetProductSession (int? id)



Retrieves an entity of ProductSession type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetProductSessionExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var id = 56;  // int? | 

            try
            {
                ProductSession result = apiInstance.GetProductSession(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetProductSession: " + e.Message );
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

[**ProductSession**](ProductSession.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsessions"></a>
# **GetProductSessions**
> List<ProductSession> GetProductSessions (List<int?> ids)



Retrieves multiple entities of ProductSession type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetProductSessionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;ProductSession&gt; result = apiInstance.GetProductSessions(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetProductSessions: " + e.Message );
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

[**List<ProductSession>**](ProductSession.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproducts"></a>
# **GetProducts**
> List<Product> GetProducts (List<int?> ids)



Retrieves multiple entities of Product type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetProductsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Product&gt; result = apiInstance.GetProducts(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetProducts: " + e.Message );
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

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspreaddefinition"></a>
# **GetSpreadDefinition**
> SpreadDefinition GetSpreadDefinition (int? id)



Retrieves an entity of SpreadDefinition type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetSpreadDefinitionExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var id = 56;  // int? | 

            try
            {
                SpreadDefinition result = apiInstance.GetSpreadDefinition(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetSpreadDefinition: " + e.Message );
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

[**SpreadDefinition**](SpreadDefinition.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspreaddefinitions"></a>
# **GetSpreadDefinitions**
> List<SpreadDefinition> GetSpreadDefinitions (List<int?> ids)



Retrieves multiple entities of SpreadDefinition type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetSpreadDefinitionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;SpreadDefinition&gt; result = apiInstance.GetSpreadDefinitions(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.GetSpreadDefinitions: " + e.Message );
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

[**List<SpreadDefinition>**](SpreadDefinition.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rollcontract"></a>
# **RollContract**
> RollContractResponse RollContract (RollContract body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class RollContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var body = new RollContract(); // RollContract | 

            try
            {
                RollContractResponse result = apiInstance.RollContract(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.RollContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RollContract**](RollContract.md)|  | 

### Return type

[**RollContractResponse**](RollContractResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggestcontractgroups"></a>
# **SuggestContractGroups**
> List<ContractGroup> SuggestContractGroups (string t, int? l)



Retrieves entities of ContractGroup type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SuggestContractGroupsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;ContractGroup&gt; result = apiInstance.SuggestContractGroups(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.SuggestContractGroups: " + e.Message );
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

[**List<ContractGroup>**](ContractGroup.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggestcontracts"></a>
# **SuggestContracts**
> List<Contract> SuggestContracts (string t, int? l)



Retrieves entities of Contract type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SuggestContractsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Contract&gt; result = apiInstance.SuggestContracts(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.SuggestContracts: " + e.Message );
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

[**List<Contract>**](Contract.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggestcurrencies"></a>
# **SuggestCurrencies**
> List<Currency> SuggestCurrencies (string t, int? l)



Retrieves entities of Currency type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SuggestCurrenciesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Currency&gt; result = apiInstance.SuggestCurrencies(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.SuggestCurrencies: " + e.Message );
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

[**List<Currency>**](Currency.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggestexchanges"></a>
# **SuggestExchanges**
> List<Exchange> SuggestExchanges (string t, int? l)



Retrieves entities of Exchange type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SuggestExchangesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Exchange&gt; result = apiInstance.SuggestExchanges(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.SuggestExchanges: " + e.Message );
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

[**List<Exchange>**](Exchange.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="suggestproducts"></a>
# **SuggestProducts**
> List<Product> SuggestProducts (string t, int? l)



Retrieves entities of Product type filtered by an occurrence of a text in one of its fields

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class SuggestProductsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ContractLibraryApi();
            var t = t_example;  // string | Text
            var l = 56;  // int? | Max number of entities

            try
            {
                List&lt;Product&gt; result = apiInstance.SuggestProducts(t, l);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractLibraryApi.SuggestProducts: " + e.Message );
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

[**List<Product>**](Product.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

