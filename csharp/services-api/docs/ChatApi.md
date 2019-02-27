# Tradovate.Services.Api.ChatApi

All URIs are relative to *https://demo-api-d.tradovate.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CloseChat**](ChatApi.md#closechat) | **POST** /chat/closechat | 
[**GetAllChats**](ChatApi.md#getallchats) | **GET** /chat/list | 
[**GetChat**](ChatApi.md#getchat) | **GET** /chat/item | 
[**GetChatMessage**](ChatApi.md#getchatmessage) | **GET** /chatMessage/item | 
[**GetChatMessages**](ChatApi.md#getchatmessages) | **GET** /chatMessage/items | 
[**GetChats**](ChatApi.md#getchats) | **GET** /chat/items | 
[**GetOwnedChatMessages**](ChatApi.md#getownedchatmessages) | **GET** /chatMessage/deps | 
[**GetOwnedChatMessagesBatch**](ChatApi.md#getownedchatmessagesbatch) | **GET** /chatMessage/ldeps | 
[**GetOwnedChats**](ChatApi.md#getownedchats) | **GET** /chat/deps | 
[**GetOwnedChatsBatch**](ChatApi.md#getownedchatsbatch) | **GET** /chat/ldeps | 
[**MarkAsReadChatMessage**](ChatApi.md#markasreadchatmessage) | **POST** /chat/markasreadchatmessage | 
[**PostChatMessage**](ChatApi.md#postchatmessage) | **POST** /chat/postchatmessage | 


<a name="closechat"></a>
# **CloseChat**
> ChatResponse CloseChat (CloseChat body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class CloseChatExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var body = new CloseChat(); // CloseChat | 

            try
            {
                ChatResponse result = apiInstance.CloseChat(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.CloseChat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CloseChat**](CloseChat.md)|  | 

### Return type

[**ChatResponse**](ChatResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallchats"></a>
# **GetAllChats**
> List<Chat> GetAllChats ()



Retrieves all entities of Chat type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetAllChatsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();

            try
            {
                List&lt;Chat&gt; result = apiInstance.GetAllChats();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetAllChats: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Chat>**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchat"></a>
# **GetChat**
> Chat GetChat (int? id)



Retrieves an entity of Chat type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetChatExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var id = 56;  // int? | 

            try
            {
                Chat result = apiInstance.GetChat(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChat: " + e.Message );
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

[**Chat**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchatmessage"></a>
# **GetChatMessage**
> ChatMessage GetChatMessage (int? id)



Retrieves an entity of ChatMessage type by its id

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetChatMessageExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var id = 56;  // int? | 

            try
            {
                ChatMessage result = apiInstance.GetChatMessage(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatMessage: " + e.Message );
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

[**ChatMessage**](ChatMessage.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchatmessages"></a>
# **GetChatMessages**
> List<ChatMessage> GetChatMessages (List<int?> ids)



Retrieves multiple entities of ChatMessage type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetChatMessagesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;ChatMessage&gt; result = apiInstance.GetChatMessages(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChatMessages: " + e.Message );
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

[**List<ChatMessage>**](ChatMessage.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchats"></a>
# **GetChats**
> List<Chat> GetChats (List<int?> ids)



Retrieves multiple entities of Chat type by its ids

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetChatsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                List&lt;Chat&gt; result = apiInstance.GetChats(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetChats: " + e.Message );
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

[**List<Chat>**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedchatmessages"></a>
# **GetOwnedChatMessages**
> List<ChatMessage> GetOwnedChatMessages (int? masterid)



Retrieves all entities of ChatMessage type related to Chat entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedChatMessagesExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var masterid = 56;  // int? | id of Chat entity

            try
            {
                List&lt;ChatMessage&gt; result = apiInstance.GetOwnedChatMessages(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetOwnedChatMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of Chat entity | 

### Return type

[**List<ChatMessage>**](ChatMessage.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedchatmessagesbatch"></a>
# **GetOwnedChatMessagesBatch**
> List<ChatMessage> GetOwnedChatMessagesBatch (List<int?> masterids)



Retrieves all entities of ChatMessage type related to multiple entities of Chat type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedChatMessagesBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var masterids = new List<int?>(); // List<int?> | ids of Chat entities

            try
            {
                List&lt;ChatMessage&gt; result = apiInstance.GetOwnedChatMessagesBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetOwnedChatMessagesBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of Chat entities | 

### Return type

[**List<ChatMessage>**](ChatMessage.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedchats"></a>
# **GetOwnedChats**
> List<Chat> GetOwnedChats (int? masterid)



Retrieves all entities of Chat type related to User entity

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedChatsExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var masterid = 56;  // int? | id of User entity

            try
            {
                List&lt;Chat&gt; result = apiInstance.GetOwnedChats(masterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetOwnedChats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterid** | **int?**| id of User entity | 

### Return type

[**List<Chat>**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedchatsbatch"></a>
# **GetOwnedChatsBatch**
> List<Chat> GetOwnedChatsBatch (List<int?> masterids)



Retrieves all entities of Chat type related to multiple entities of User type

### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class GetOwnedChatsBatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var masterids = new List<int?>(); // List<int?> | ids of User entities

            try
            {
                List&lt;Chat&gt; result = apiInstance.GetOwnedChatsBatch(masterids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.GetOwnedChatsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masterids** | [**List<int?>**](int?.md)| ids of User entities | 

### Return type

[**List<Chat>**](Chat.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markasreadchatmessage"></a>
# **MarkAsReadChatMessage**
> ChatMessageResponse MarkAsReadChatMessage (MarkAsReadChatMessage body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class MarkAsReadChatMessageExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var body = new MarkAsReadChatMessage(); // MarkAsReadChatMessage | 

            try
            {
                ChatMessageResponse result = apiInstance.MarkAsReadChatMessage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.MarkAsReadChatMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MarkAsReadChatMessage**](MarkAsReadChatMessage.md)|  | 

### Return type

[**ChatMessageResponse**](ChatMessageResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postchatmessage"></a>
# **PostChatMessage**
> ChatMessageResponse PostChatMessage (PostChatMessage body)



### Example
```csharp
using System;
using System.Diagnostics;
using Tradovate.Services.Api;
using Tradovate.Services.Client;
using Tradovate.Services.Model;

namespace Example
{
    public class PostChatMessageExample
    {
        public void main()
        {
            
            // Configure API key authorization: bearer_access_token
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ChatApi();
            var body = new PostChatMessage(); // PostChatMessage | 

            try
            {
                ChatMessageResponse result = apiInstance.PostChatMessage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatApi.PostChatMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostChatMessage**](PostChatMessage.md)|  | 

### Return type

[**ChatMessageResponse**](ChatMessageResponse.md)

### Authorization

[bearer_access_token](../README.md#bearer_access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

