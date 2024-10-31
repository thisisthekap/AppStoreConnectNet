# AppStoreConnect.Net.Api.GameCenterAchievementsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GameCenterAchievementsCreateInstance**](GameCenterAchievementsApi.md#gamecenterachievementscreateinstance) | **POST** /v1/gameCenterAchievements |  |
| [**GameCenterAchievementsDeleteInstance**](GameCenterAchievementsApi.md#gamecenterachievementsdeleteinstance) | **DELETE** /v1/gameCenterAchievements/{id} |  |
| [**GameCenterAchievementsGetInstance**](GameCenterAchievementsApi.md#gamecenterachievementsgetinstance) | **GET** /v1/gameCenterAchievements/{id} |  |
| [**GameCenterAchievementsGroupAchievementGetToOneRelated**](GameCenterAchievementsApi.md#gamecenterachievementsgroupachievementgettoonerelated) | **GET** /v1/gameCenterAchievements/{id}/groupAchievement |  |
| [**GameCenterAchievementsGroupAchievementGetToOneRelationship**](GameCenterAchievementsApi.md#gamecenterachievementsgroupachievementgettoonerelationship) | **GET** /v1/gameCenterAchievements/{id}/relationships/groupAchievement |  |
| [**GameCenterAchievementsGroupAchievementUpdateToOneRelationship**](GameCenterAchievementsApi.md#gamecenterachievementsgroupachievementupdatetoonerelationship) | **PATCH** /v1/gameCenterAchievements/{id}/relationships/groupAchievement |  |
| [**GameCenterAchievementsLocalizationsGetToManyRelated**](GameCenterAchievementsApi.md#gamecenterachievementslocalizationsgettomanyrelated) | **GET** /v1/gameCenterAchievements/{id}/localizations |  |
| [**GameCenterAchievementsReleasesGetToManyRelated**](GameCenterAchievementsApi.md#gamecenterachievementsreleasesgettomanyrelated) | **GET** /v1/gameCenterAchievements/{id}/releases |  |
| [**GameCenterAchievementsUpdateInstance**](GameCenterAchievementsApi.md#gamecenterachievementsupdateinstance) | **PATCH** /v1/gameCenterAchievements/{id} |  |

<a id="gamecenterachievementscreateinstance"></a>
# **GameCenterAchievementsCreateInstance**
> GameCenterAchievementResponse GameCenterAchievementsCreateInstance (GameCenterAchievementCreateRequest gameCenterAchievementCreateRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class GameCenterAchievementsCreateInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GameCenterAchievementsApi(httpClient, config, httpClientHandler);
            var gameCenterAchievementCreateRequest = new GameCenterAchievementCreateRequest(); // GameCenterAchievementCreateRequest | GameCenterAchievement representation

            try
            {
                GameCenterAchievementResponse result = apiInstance.GameCenterAchievementsCreateInstance(gameCenterAchievementCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterAchievementsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementResponse> response = apiInstance.GameCenterAchievementsCreateInstanceWithHttpInfo(gameCenterAchievementCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gameCenterAchievementCreateRequest** | [**GameCenterAchievementCreateRequest**](GameCenterAchievementCreateRequest.md) | GameCenterAchievement representation |  |

### Return type

[**GameCenterAchievementResponse**](GameCenterAchievementResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **422** | Unprocessable request entity error(s) |  -  |
| **201** | Single GameCenterAchievement |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterachievementsdeleteinstance"></a>
# **GameCenterAchievementsDeleteInstance**
> void GameCenterAchievementsDeleteInstance (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class GameCenterAchievementsDeleteInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GameCenterAchievementsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.GameCenterAchievementsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterAchievementsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterAchievementsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsDeleteInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterachievementsgetinstance"></a>
# **GameCenterAchievementsGetInstance**
> GameCenterAchievementResponse GameCenterAchievementsGetInstance (string id, List<string>? fieldsGameCenterAchievements = null, List<string>? fieldsGameCenterAchievementLocalizations = null, List<string>? fieldsGameCenterAchievementReleases = null, List<string>? include = null, int? limitLocalizations = null, int? limitReleases = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class GameCenterAchievementsGetInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GameCenterAchievementsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var fieldsGameCenterAchievementLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementLocalizations (optional) 
            var fieldsGameCenterAchievementReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementReleases (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitLocalizations = 56;  // int? | maximum number of related localizations returned (when they are included) (optional) 
            var limitReleases = 56;  // int? | maximum number of related releases returned (when they are included) (optional) 

            try
            {
                GameCenterAchievementResponse result = apiInstance.GameCenterAchievementsGetInstance(id, fieldsGameCenterAchievements, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievementReleases, include, limitLocalizations, limitReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterAchievementsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementResponse> response = apiInstance.GameCenterAchievementsGetInstanceWithHttpInfo(id, fieldsGameCenterAchievements, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievementReleases, include, limitLocalizations, limitReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsGameCenterAchievements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievements | [optional]  |
| **fieldsGameCenterAchievementLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementLocalizations | [optional]  |
| **fieldsGameCenterAchievementReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementReleases | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitLocalizations** | **int?** | maximum number of related localizations returned (when they are included) | [optional]  |
| **limitReleases** | **int?** | maximum number of related releases returned (when they are included) | [optional]  |

### Return type

[**GameCenterAchievementResponse**](GameCenterAchievementResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Single GameCenterAchievement |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterachievementsgroupachievementgettoonerelated"></a>
# **GameCenterAchievementsGroupAchievementGetToOneRelated**
> GameCenterAchievementResponse GameCenterAchievementsGroupAchievementGetToOneRelated (string id, List<string>? fieldsGameCenterAchievements = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterAchievementLocalizations = null, List<string>? fieldsGameCenterAchievementReleases = null, List<string>? include = null, int? limitLocalizations = null, int? limitReleases = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class GameCenterAchievementsGroupAchievementGetToOneRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GameCenterAchievementsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterGroups (optional) 
            var fieldsGameCenterAchievementLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementLocalizations (optional) 
            var fieldsGameCenterAchievementReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementReleases (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitLocalizations = 56;  // int? | maximum number of related localizations returned (when they are included) (optional) 
            var limitReleases = 56;  // int? | maximum number of related releases returned (when they are included) (optional) 

            try
            {
                GameCenterAchievementResponse result = apiInstance.GameCenterAchievementsGroupAchievementGetToOneRelated(id, fieldsGameCenterAchievements, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievementReleases, include, limitLocalizations, limitReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsGroupAchievementGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterAchievementsGroupAchievementGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementResponse> response = apiInstance.GameCenterAchievementsGroupAchievementGetToOneRelatedWithHttpInfo(id, fieldsGameCenterAchievements, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievementReleases, include, limitLocalizations, limitReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsGroupAchievementGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsGameCenterAchievements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievements | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterGroups | [optional]  |
| **fieldsGameCenterAchievementLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementLocalizations | [optional]  |
| **fieldsGameCenterAchievementReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementReleases | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitLocalizations** | **int?** | maximum number of related localizations returned (when they are included) | [optional]  |
| **limitReleases** | **int?** | maximum number of related releases returned (when they are included) | [optional]  |

### Return type

[**GameCenterAchievementResponse**](GameCenterAchievementResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Single GameCenterAchievement |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterachievementsgroupachievementgettoonerelationship"></a>
# **GameCenterAchievementsGroupAchievementGetToOneRelationship**
> GameCenterAchievementGroupAchievementLinkageResponse GameCenterAchievementsGroupAchievementGetToOneRelationship (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class GameCenterAchievementsGroupAchievementGetToOneRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GameCenterAchievementsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                GameCenterAchievementGroupAchievementLinkageResponse result = apiInstance.GameCenterAchievementsGroupAchievementGetToOneRelationship(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsGroupAchievementGetToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterAchievementsGroupAchievementGetToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementGroupAchievementLinkageResponse> response = apiInstance.GameCenterAchievementsGroupAchievementGetToOneRelationshipWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsGroupAchievementGetToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

[**GameCenterAchievementGroupAchievementLinkageResponse**](GameCenterAchievementGroupAchievementLinkageResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | Related linkage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterachievementsgroupachievementupdatetoonerelationship"></a>
# **GameCenterAchievementsGroupAchievementUpdateToOneRelationship**
> void GameCenterAchievementsGroupAchievementUpdateToOneRelationship (string id, GameCenterAchievementGroupAchievementLinkageRequest gameCenterAchievementGroupAchievementLinkageRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class GameCenterAchievementsGroupAchievementUpdateToOneRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GameCenterAchievementsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterAchievementGroupAchievementLinkageRequest = new GameCenterAchievementGroupAchievementLinkageRequest(); // GameCenterAchievementGroupAchievementLinkageRequest | Related linkage

            try
            {
                apiInstance.GameCenterAchievementsGroupAchievementUpdateToOneRelationship(id, gameCenterAchievementGroupAchievementLinkageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsGroupAchievementUpdateToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterAchievementsGroupAchievementUpdateToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterAchievementsGroupAchievementUpdateToOneRelationshipWithHttpInfo(id, gameCenterAchievementGroupAchievementLinkageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsGroupAchievementUpdateToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterAchievementGroupAchievementLinkageRequest** | [**GameCenterAchievementGroupAchievementLinkageRequest**](GameCenterAchievementGroupAchievementLinkageRequest.md) | Related linkage |  |

### Return type

void (empty response body)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **422** | Unprocessable request entity error(s) |  -  |
| **409** | Request entity error(s) |  -  |
| **204** | Success (no content) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterachievementslocalizationsgettomanyrelated"></a>
# **GameCenterAchievementsLocalizationsGetToManyRelated**
> GameCenterAchievementLocalizationsResponse GameCenterAchievementsLocalizationsGetToManyRelated (string id, List<string>? fieldsGameCenterAchievementLocalizations = null, List<string>? fieldsGameCenterAchievements = null, List<string>? fieldsGameCenterAchievementImages = null, int? limit = null, List<string>? include = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class GameCenterAchievementsLocalizationsGetToManyRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GameCenterAchievementsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsGameCenterAchievementLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementLocalizations (optional) 
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var fieldsGameCenterAchievementImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementImages (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                GameCenterAchievementLocalizationsResponse result = apiInstance.GameCenterAchievementsLocalizationsGetToManyRelated(id, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievements, fieldsGameCenterAchievementImages, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterAchievementsLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementLocalizationsResponse> response = apiInstance.GameCenterAchievementsLocalizationsGetToManyRelatedWithHttpInfo(id, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievements, fieldsGameCenterAchievementImages, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsGameCenterAchievementLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementLocalizations | [optional]  |
| **fieldsGameCenterAchievements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievements | [optional]  |
| **fieldsGameCenterAchievementImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementImages | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**GameCenterAchievementLocalizationsResponse**](GameCenterAchievementLocalizationsResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of GameCenterAchievementLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterachievementsreleasesgettomanyrelated"></a>
# **GameCenterAchievementsReleasesGetToManyRelated**
> GameCenterAchievementReleasesResponse GameCenterAchievementsReleasesGetToManyRelated (string id, List<string>? filterLive = null, List<string>? filterGameCenterDetail = null, List<string>? fieldsGameCenterAchievementReleases = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterAchievements = null, int? limit = null, List<string>? include = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class GameCenterAchievementsReleasesGetToManyRelatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GameCenterAchievementsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterLive = new List<string>?(); // List<string>? | filter by attribute 'live' (optional) 
            var filterGameCenterDetail = new List<string>?(); // List<string>? | filter by id(s) of related 'gameCenterDetail' (optional) 
            var fieldsGameCenterAchievementReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementReleases (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                GameCenterAchievementReleasesResponse result = apiInstance.GameCenterAchievementsReleasesGetToManyRelated(id, filterLive, filterGameCenterDetail, fieldsGameCenterAchievementReleases, fieldsGameCenterDetails, fieldsGameCenterAchievements, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsReleasesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterAchievementsReleasesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementReleasesResponse> response = apiInstance.GameCenterAchievementsReleasesGetToManyRelatedWithHttpInfo(id, filterLive, filterGameCenterDetail, fieldsGameCenterAchievementReleases, fieldsGameCenterDetails, fieldsGameCenterAchievements, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsReleasesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterLive** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;live&#39; | [optional]  |
| **filterGameCenterDetail** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;gameCenterDetail&#39; | [optional]  |
| **fieldsGameCenterAchievementReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementReleases | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterAchievements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievements | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**GameCenterAchievementReleasesResponse**](GameCenterAchievementReleasesResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of GameCenterAchievementReleases |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterachievementsupdateinstance"></a>
# **GameCenterAchievementsUpdateInstance**
> GameCenterAchievementResponse GameCenterAchievementsUpdateInstance (string id, GameCenterAchievementUpdateRequest gameCenterAchievementUpdateRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AppStoreConnect.Net.Api;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace Example
{
    public class GameCenterAchievementsUpdateInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.appstoreconnect.apple.com";
            // Configure Bearer token for authorization: itc-bearer-token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GameCenterAchievementsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterAchievementUpdateRequest = new GameCenterAchievementUpdateRequest(); // GameCenterAchievementUpdateRequest | GameCenterAchievement representation

            try
            {
                GameCenterAchievementResponse result = apiInstance.GameCenterAchievementsUpdateInstance(id, gameCenterAchievementUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterAchievementsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementResponse> response = apiInstance.GameCenterAchievementsUpdateInstanceWithHttpInfo(id, gameCenterAchievementUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterAchievementsApi.GameCenterAchievementsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterAchievementUpdateRequest** | [**GameCenterAchievementUpdateRequest**](GameCenterAchievementUpdateRequest.md) | GameCenterAchievement representation |  |

### Return type

[**GameCenterAchievementResponse**](GameCenterAchievementResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **422** | Unprocessable request entity error(s) |  -  |
| **200** | Single GameCenterAchievement |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

