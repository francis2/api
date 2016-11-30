# Tradovate.Services.Api.AuthenticationApi

All URIs are relative to *https://live-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccessTokenRequest**](AuthenticationApi.md#accesstokenrequest) | **POST** /auth/accesstokenrequest | 


<a name="accesstokenrequest"></a>
# **AccessTokenRequest**
> AccessTokenResponse AccessTokenRequest (AccessTokenRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class AccessTokenRequestExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var body = new AccessTokenRequest(); // AccessTokenRequest | 

            try
            {
                AccessTokenResponse result = apiInstance.AccessTokenRequest(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AccessTokenRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccessTokenRequest**](AccessTokenRequest.md)|  | 

### Return type

[**AccessTokenResponse**](AccessTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

