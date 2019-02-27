# Tradovate.Services.Api.RisksApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUserAccountAutoLiq**](RisksApi.md#createuseraccountautoliq) | **POST** /userAccountAutoLiq/create | 
[**CreateUserAccountPositionLimit**](RisksApi.md#createuseraccountpositionlimit) | **POST** /userAccountPositionLimit/create | 
[**CreateUserAccountRiskParameter**](RisksApi.md#createuseraccountriskparameter) | **POST** /userAccountRiskParameter/create | 
[**DeleteUserAccountPositionLimit**](RisksApi.md#deleteuseraccountpositionlimit) | **POST** /userAccountPositionLimit/deleteuseraccountpositionlimit | 
[**DeleteUserAccountRiskParameter**](RisksApi.md#deleteuseraccountriskparameter) | **POST** /userAccountPositionLimit/deleteuseraccountriskparameter | 
[**GetAllProductMargins**](RisksApi.md#getallproductmargins) | **GET** /productMargin/list | 
[**GetAllUserAccountAutoLiqs**](RisksApi.md#getalluseraccountautoliqs) | **GET** /userAccountAutoLiq/list | 
[**GetContractMargin**](RisksApi.md#getcontractmargin) | **GET** /contractMargin/item | 
[**GetContractMargins**](RisksApi.md#getcontractmargins) | **GET** /contractMargin/items | 
[**GetOwnedContractMargins**](RisksApi.md#getownedcontractmargins) | **GET** /contractMargin/deps | 
[**GetOwnedContractMarginsBatch**](RisksApi.md#getownedcontractmarginsbatch) | **GET** /contractMargin/ldeps | 
[**GetOwnedProductMargins**](RisksApi.md#getownedproductmargins) | **GET** /productMargin/deps | 
[**GetOwnedProductMarginsBatch**](RisksApi.md#getownedproductmarginsbatch) | **GET** /productMargin/ldeps | 
[**GetOwnedUserAccountAutoLiqs**](RisksApi.md#getowneduseraccountautoliqs) | **GET** /userAccountAutoLiq/deps | 
[**GetOwnedUserAccountAutoLiqsBatch**](RisksApi.md#getowneduseraccountautoliqsbatch) | **GET** /userAccountAutoLiq/ldeps | 
[**GetOwnedUserAccountPositionLimits**](RisksApi.md#getowneduseraccountpositionlimits) | **GET** /userAccountPositionLimit/deps | 
[**GetOwnedUserAccountPositionLimitsBatch**](RisksApi.md#getowneduseraccountpositionlimitsbatch) | **GET** /userAccountPositionLimit/ldeps | 
[**GetOwnedUserAccountRiskParameters**](RisksApi.md#getowneduseraccountriskparameters) | **GET** /userAccountRiskParameter/deps | 
[**GetOwnedUserAccountRiskParametersBatch**](RisksApi.md#getowneduseraccountriskparametersbatch) | **GET** /userAccountRiskParameter/ldeps | 
[**GetProductMargin**](RisksApi.md#getproductmargin) | **GET** /productMargin/item | 
[**GetProductMargins**](RisksApi.md#getproductmargins) | **GET** /productMargin/items | 
[**GetUserAccountAutoLiq**](RisksApi.md#getuseraccountautoliq) | **GET** /userAccountAutoLiq/item | 
[**GetUserAccountAutoLiqs**](RisksApi.md#getuseraccountautoliqs) | **GET** /userAccountAutoLiq/items | 
[**GetUserAccountPositionLimit**](RisksApi.md#getuseraccountpositionlimit) | **GET** /userAccountPositionLimit/item | 
[**GetUserAccountPositionLimits**](RisksApi.md#getuseraccountpositionlimits) | **GET** /userAccountPositionLimit/items | 
[**GetUserAccountRiskParameter**](RisksApi.md#getuseraccountriskparameter) | **GET** /userAccountRiskParameter/item | 
[**GetUserAccountRiskParameters**](RisksApi.md#getuseraccountriskparameters) | **GET** /userAccountRiskParameter/items | 
[**UpdateUserAccountAutoLiq**](RisksApi.md#updateuseraccountautoliq) | **POST** /userAccountAutoLiq/update | 
[**UpdateUserAccountPositionLimit**](RisksApi.md#updateuseraccountpositionlimit) | **POST** /userAccountPositionLimit/update | 
[**UpdateUserAccountRiskParameter**](RisksApi.md#updateuseraccountriskparameter) | **POST** /userAccountRiskParameter/update | 


<a name="createuseraccountautoliq"></a>
# **CreateUserAccountAutoLiq**
> UserAccountAutoLiq CreateUserAccountAutoLiq (UserAccountAutoLiq body)



Creates a new entity of UserAccountAutoLiq

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CreateUserAccountAutoLiqExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var body = new UserAccountAutoLiq(); // UserAccountAutoLiq | 

            try
            {
                UserAccountAutoLiq result = apiInstance.CreateUserAccountAutoLiq(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.CreateUserAccountAutoLiq: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountAutoLiq**](UserAccountAutoLiq.md)|  | 

### Return type

[**UserAccountAutoLiq**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuseraccountpositionlimit"></a>
# **CreateUserAccountPositionLimit**
> UserAccountPositionLimit CreateUserAccountPositionLimit (UserAccountPositionLimit body)



Creates a new entity of UserAccountPositionLimit

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CreateUserAccountPositionLimitExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var body = new UserAccountPositionLimit(); // UserAccountPositionLimit | 

            try
            {
                UserAccountPositionLimit result = apiInstance.CreateUserAccountPositionLimit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.CreateUserAccountPositionLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountPositionLimit**](UserAccountPositionLimit.md)|  | 

### Return type

[**UserAccountPositionLimit**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuseraccountriskparameter"></a>
# **CreateUserAccountRiskParameter**
> UserAccountRiskParameter CreateUserAccountRiskParameter (UserAccountRiskParameter body)



Creates a new entity of UserAccountRiskParameter

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CreateUserAccountRiskParameterExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var body = new UserAccountRiskParameter(); // UserAccountRiskParameter | 

            try
            {
                UserAccountRiskParameter result = apiInstance.CreateUserAccountRiskParameter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.CreateUserAccountRiskParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountRiskParameter**](UserAccountRiskParameter.md)|  | 

### Return type

[**UserAccountRiskParameter**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuseraccountpositionlimit"></a>
# **DeleteUserAccountPositionLimit**
> DeleteResultResponse DeleteUserAccountPositionLimit (DeleteUserAccountPositionLimit body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class DeleteUserAccountPositionLimitExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var body = new DeleteUserAccountPositionLimit(); // DeleteUserAccountPositionLimit | 

            try
            {
                DeleteResultResponse result = apiInstance.DeleteUserAccountPositionLimit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.DeleteUserAccountPositionLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteUserAccountPositionLimit**](DeleteUserAccountPositionLimit.md)|  | 

### Return type

[**DeleteResultResponse**](DeleteResultResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuseraccountriskparameter"></a>
# **DeleteUserAccountRiskParameter**
> DeleteResultResponse DeleteUserAccountRiskParameter (DeleteUserAccountRiskParameter body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class DeleteUserAccountRiskParameterExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var body = new DeleteUserAccountRiskParameter(); // DeleteUserAccountRiskParameter | 

            try
            {
                DeleteResultResponse result = apiInstance.DeleteUserAccountRiskParameter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.DeleteUserAccountRiskParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeleteUserAccountRiskParameter**](DeleteUserAccountRiskParameter.md)|  | 

### Return type

[**DeleteResultResponse**](DeleteResultResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallproductmargins"></a>
# **GetAllProductMargins**
> List<ProductMargin> GetAllProductMargins ()



Retrieves all entities of ProductMargin type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllProductMarginsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();

            try
            {
                List&lt;ProductMargin&gt; result = apiInstance.GetAllProductMargins();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetAllProductMargins: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ProductMargin>**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalluseraccountautoliqs"></a>
# **GetAllUserAccountAutoLiqs**
> List<UserAccountAutoLiq> GetAllUserAccountAutoLiqs ()



Retrieves all entities of UserAccountAutoLiq type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllUserAccountAutoLiqsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();

            try
            {
                List&lt;UserAccountAutoLiq&gt; result = apiInstance.GetAllUserAccountAutoLiqs();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetAllUserAccountAutoLiqs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserAccountAutoLiq>**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractmargin"></a>
# **GetContractMargin**
> ContractMargin GetContractMargin (int? id)



Retrieves an entity of ContractMargin type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetContractMarginExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var id = 56;  // int? | 

            try
            {
                ContractMargin result = apiInstance.GetContractMargin(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetContractMargin: " + e.Message );
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

[**ContractMargin**](ContractMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractmargins"></a>
# **GetContractMargins**
> List<ContractMargin> GetContractMargins (List<int?> ids)



Retrieves multiple entities of ContractMargin type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetContractMarginsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;ContractMargin&gt; result = apiInstance.GetContractMargins(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetContractMargins: " + e.Message );
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

[**List<ContractMargin>**](ContractMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedcontractmargins"></a>
# **GetOwnedContractMargins**
> List<ContractMargin> GetOwnedContractMargins (int? masterid)



Retrieves all entities of ContractMargin type related to Contract entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedContractMarginsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterid = 56;  // int? | id of Contract entity

            try
            {
                List&lt;ContractMargin&gt; result = apiInstance.GetOwnedContractMargins(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedContractMargins: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of Contract entity | 

### Return type

[**List<ContractMargin>**](ContractMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedcontractmarginsbatch"></a>
# **GetOwnedContractMarginsBatch**
> List<ContractMargin> GetOwnedContractMarginsBatch (List<int?> masterids)



Retrieves all entities of ContractMargin type related to multiple entities of Contract type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedContractMarginsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterids = new List<int?>(); // List<int?> | ids of Contract entities

            try
            {
                List&lt;ContractMargin&gt; result = apiInstance.GetOwnedContractMarginsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedContractMarginsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of Contract entities | 

### Return type

[**List<ContractMargin>**](ContractMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedproductmargins"></a>
# **GetOwnedProductMargins**
> List<ProductMargin> GetOwnedProductMargins (int? masterid)



Retrieves all entities of ProductMargin type related to Product entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedProductMarginsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterid = 56;  // int? | id of Product entity

            try
            {
                List&lt;ProductMargin&gt; result = apiInstance.GetOwnedProductMargins(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedProductMargins: " + e.Message );
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

[**List<ProductMargin>**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedproductmarginsbatch"></a>
# **GetOwnedProductMarginsBatch**
> List<ProductMargin> GetOwnedProductMarginsBatch (List<int?> masterids)



Retrieves all entities of ProductMargin type related to multiple entities of Product type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedProductMarginsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterids = new List<int?>(); // List<int?> | ids of Product entities

            try
            {
                List&lt;ProductMargin&gt; result = apiInstance.GetOwnedProductMarginsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedProductMarginsBatch: " + e.Message );
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

[**List<ProductMargin>**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getowneduseraccountautoliqs"></a>
# **GetOwnedUserAccountAutoLiqs**
> List<UserAccountAutoLiq> GetOwnedUserAccountAutoLiqs (int? masterid)



Retrieves all entities of UserAccountAutoLiq type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedUserAccountAutoLiqsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterid = 56;  // int? | id of Account entity

            try
            {
                List&lt;UserAccountAutoLiq&gt; result = apiInstance.GetOwnedUserAccountAutoLiqs(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedUserAccountAutoLiqs: " + e.Message );
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

[**List<UserAccountAutoLiq>**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getowneduseraccountautoliqsbatch"></a>
# **GetOwnedUserAccountAutoLiqsBatch**
> List<UserAccountAutoLiq> GetOwnedUserAccountAutoLiqsBatch (List<int?> masterids)



Retrieves all entities of UserAccountAutoLiq type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedUserAccountAutoLiqsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterids = new List<int?>(); // List<int?> | ids of Account entities

            try
            {
                List&lt;UserAccountAutoLiq&gt; result = apiInstance.GetOwnedUserAccountAutoLiqsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedUserAccountAutoLiqsBatch: " + e.Message );
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

[**List<UserAccountAutoLiq>**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getowneduseraccountpositionlimits"></a>
# **GetOwnedUserAccountPositionLimits**
> List<UserAccountPositionLimit> GetOwnedUserAccountPositionLimits (int? masterid)



Retrieves all entities of UserAccountPositionLimit type related to Account entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedUserAccountPositionLimitsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterid = 56;  // int? | id of Account entity

            try
            {
                List&lt;UserAccountPositionLimit&gt; result = apiInstance.GetOwnedUserAccountPositionLimits(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedUserAccountPositionLimits: " + e.Message );
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

[**List<UserAccountPositionLimit>**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getowneduseraccountpositionlimitsbatch"></a>
# **GetOwnedUserAccountPositionLimitsBatch**
> List<UserAccountPositionLimit> GetOwnedUserAccountPositionLimitsBatch (List<int?> masterids)



Retrieves all entities of UserAccountPositionLimit type related to multiple entities of Account type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedUserAccountPositionLimitsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterids = new List<int?>(); // List<int?> | ids of Account entities

            try
            {
                List&lt;UserAccountPositionLimit&gt; result = apiInstance.GetOwnedUserAccountPositionLimitsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedUserAccountPositionLimitsBatch: " + e.Message );
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

[**List<UserAccountPositionLimit>**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getowneduseraccountriskparameters"></a>
# **GetOwnedUserAccountRiskParameters**
> List<UserAccountRiskParameter> GetOwnedUserAccountRiskParameters (int? masterid)



Retrieves all entities of UserAccountRiskParameter type related to UserAccountPositionLimit entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedUserAccountRiskParametersExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterid = 56;  // int? | id of UserAccountPositionLimit entity

            try
            {
                List&lt;UserAccountRiskParameter&gt; result = apiInstance.GetOwnedUserAccountRiskParameters(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedUserAccountRiskParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of UserAccountPositionLimit entity | 

### Return type

[**List<UserAccountRiskParameter>**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getowneduseraccountriskparametersbatch"></a>
# **GetOwnedUserAccountRiskParametersBatch**
> List<UserAccountRiskParameter> GetOwnedUserAccountRiskParametersBatch (List<int?> masterids)



Retrieves all entities of UserAccountRiskParameter type related to multiple entities of UserAccountPositionLimit type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedUserAccountRiskParametersBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var masterids = new List<int?>(); // List<int?> | ids of UserAccountPositionLimit entities

            try
            {
                List&lt;UserAccountRiskParameter&gt; result = apiInstance.GetOwnedUserAccountRiskParametersBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetOwnedUserAccountRiskParametersBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of UserAccountPositionLimit entities | 

### Return type

[**List<UserAccountRiskParameter>**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductmargin"></a>
# **GetProductMargin**
> ProductMargin GetProductMargin (int? id)



Retrieves an entity of ProductMargin type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetProductMarginExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var id = 56;  // int? | 

            try
            {
                ProductMargin result = apiInstance.GetProductMargin(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetProductMargin: " + e.Message );
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

[**ProductMargin**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductmargins"></a>
# **GetProductMargins**
> List<ProductMargin> GetProductMargins (List<int?> ids)



Retrieves multiple entities of ProductMargin type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetProductMarginsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;ProductMargin&gt; result = apiInstance.GetProductMargins(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetProductMargins: " + e.Message );
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

[**List<ProductMargin>**](ProductMargin.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseraccountautoliq"></a>
# **GetUserAccountAutoLiq**
> UserAccountAutoLiq GetUserAccountAutoLiq (int? id)



Retrieves an entity of UserAccountAutoLiq type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetUserAccountAutoLiqExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var id = 56;  // int? | 

            try
            {
                UserAccountAutoLiq result = apiInstance.GetUserAccountAutoLiq(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetUserAccountAutoLiq: " + e.Message );
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

[**UserAccountAutoLiq**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseraccountautoliqs"></a>
# **GetUserAccountAutoLiqs**
> List<UserAccountAutoLiq> GetUserAccountAutoLiqs (List<int?> ids)



Retrieves multiple entities of UserAccountAutoLiq type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetUserAccountAutoLiqsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;UserAccountAutoLiq&gt; result = apiInstance.GetUserAccountAutoLiqs(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetUserAccountAutoLiqs: " + e.Message );
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

[**List<UserAccountAutoLiq>**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseraccountpositionlimit"></a>
# **GetUserAccountPositionLimit**
> UserAccountPositionLimit GetUserAccountPositionLimit (int? id)



Retrieves an entity of UserAccountPositionLimit type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetUserAccountPositionLimitExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var id = 56;  // int? | 

            try
            {
                UserAccountPositionLimit result = apiInstance.GetUserAccountPositionLimit(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetUserAccountPositionLimit: " + e.Message );
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

[**UserAccountPositionLimit**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseraccountpositionlimits"></a>
# **GetUserAccountPositionLimits**
> List<UserAccountPositionLimit> GetUserAccountPositionLimits (List<int?> ids)



Retrieves multiple entities of UserAccountPositionLimit type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetUserAccountPositionLimitsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;UserAccountPositionLimit&gt; result = apiInstance.GetUserAccountPositionLimits(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetUserAccountPositionLimits: " + e.Message );
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

[**List<UserAccountPositionLimit>**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseraccountriskparameter"></a>
# **GetUserAccountRiskParameter**
> UserAccountRiskParameter GetUserAccountRiskParameter (int? id)



Retrieves an entity of UserAccountRiskParameter type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetUserAccountRiskParameterExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var id = 56;  // int? | 

            try
            {
                UserAccountRiskParameter result = apiInstance.GetUserAccountRiskParameter(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetUserAccountRiskParameter: " + e.Message );
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

[**UserAccountRiskParameter**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseraccountriskparameters"></a>
# **GetUserAccountRiskParameters**
> List<UserAccountRiskParameter> GetUserAccountRiskParameters (List<int?> ids)



Retrieves multiple entities of UserAccountRiskParameter type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetUserAccountRiskParametersExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;UserAccountRiskParameter&gt; result = apiInstance.GetUserAccountRiskParameters(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.GetUserAccountRiskParameters: " + e.Message );
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

[**List<UserAccountRiskParameter>**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuseraccountautoliq"></a>
# **UpdateUserAccountAutoLiq**
> UserAccountAutoLiq UpdateUserAccountAutoLiq (UserAccountAutoLiq body)



Updates an existing entity of UserAccountAutoLiq

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UpdateUserAccountAutoLiqExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var body = new UserAccountAutoLiq(); // UserAccountAutoLiq | 

            try
            {
                UserAccountAutoLiq result = apiInstance.UpdateUserAccountAutoLiq(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UpdateUserAccountAutoLiq: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountAutoLiq**](UserAccountAutoLiq.md)|  | 

### Return type

[**UserAccountAutoLiq**](UserAccountAutoLiq.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuseraccountpositionlimit"></a>
# **UpdateUserAccountPositionLimit**
> UserAccountPositionLimit UpdateUserAccountPositionLimit (UserAccountPositionLimit body)



Updates an existing entity of UserAccountPositionLimit

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UpdateUserAccountPositionLimitExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var body = new UserAccountPositionLimit(); // UserAccountPositionLimit | 

            try
            {
                UserAccountPositionLimit result = apiInstance.UpdateUserAccountPositionLimit(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UpdateUserAccountPositionLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountPositionLimit**](UserAccountPositionLimit.md)|  | 

### Return type

[**UserAccountPositionLimit**](UserAccountPositionLimit.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuseraccountriskparameter"></a>
# **UpdateUserAccountRiskParameter**
> UserAccountRiskParameter UpdateUserAccountRiskParameter (UserAccountRiskParameter body)



Updates an existing entity of UserAccountRiskParameter

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class UpdateUserAccountRiskParameterExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new RisksApi();
            var body = new UserAccountRiskParameter(); // UserAccountRiskParameter | 

            try
            {
                UserAccountRiskParameter result = apiInstance.UpdateUserAccountRiskParameter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RisksApi.UpdateUserAccountRiskParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserAccountRiskParameter**](UserAccountRiskParameter.md)|  | 

### Return type

[**UserAccountRiskParameter**](UserAccountRiskParameter.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

