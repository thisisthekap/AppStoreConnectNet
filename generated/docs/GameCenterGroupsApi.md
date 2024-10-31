# AppStoreConnect.Net.Api.GameCenterGroupsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GameCenterGroupsCreateInstance**](GameCenterGroupsApi.md#gamecentergroupscreateinstance) | **POST** /v1/gameCenterGroups |  |
| [**GameCenterGroupsDeleteInstance**](GameCenterGroupsApi.md#gamecentergroupsdeleteinstance) | **DELETE** /v1/gameCenterGroups/{id} |  |
| [**GameCenterGroupsGameCenterAchievementsGetToManyRelated**](GameCenterGroupsApi.md#gamecentergroupsgamecenterachievementsgettomanyrelated) | **GET** /v1/gameCenterGroups/{id}/gameCenterAchievements |  |
| [**GameCenterGroupsGameCenterAchievementsGetToManyRelationship**](GameCenterGroupsApi.md#gamecentergroupsgamecenterachievementsgettomanyrelationship) | **GET** /v1/gameCenterGroups/{id}/relationships/gameCenterAchievements |  |
| [**GameCenterGroupsGameCenterAchievementsReplaceToManyRelationship**](GameCenterGroupsApi.md#gamecentergroupsgamecenterachievementsreplacetomanyrelationship) | **PATCH** /v1/gameCenterGroups/{id}/relationships/gameCenterAchievements |  |
| [**GameCenterGroupsGameCenterDetailsGetToManyRelated**](GameCenterGroupsApi.md#gamecentergroupsgamecenterdetailsgettomanyrelated) | **GET** /v1/gameCenterGroups/{id}/gameCenterDetails |  |
| [**GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelated**](GameCenterGroupsApi.md#gamecentergroupsgamecenterleaderboardsetsgettomanyrelated) | **GET** /v1/gameCenterGroups/{id}/gameCenterLeaderboardSets |  |
| [**GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelationship**](GameCenterGroupsApi.md#gamecentergroupsgamecenterleaderboardsetsgettomanyrelationship) | **GET** /v1/gameCenterGroups/{id}/relationships/gameCenterLeaderboardSets |  |
| [**GameCenterGroupsGameCenterLeaderboardSetsReplaceToManyRelationship**](GameCenterGroupsApi.md#gamecentergroupsgamecenterleaderboardsetsreplacetomanyrelationship) | **PATCH** /v1/gameCenterGroups/{id}/relationships/gameCenterLeaderboardSets |  |
| [**GameCenterGroupsGameCenterLeaderboardsGetToManyRelated**](GameCenterGroupsApi.md#gamecentergroupsgamecenterleaderboardsgettomanyrelated) | **GET** /v1/gameCenterGroups/{id}/gameCenterLeaderboards |  |
| [**GameCenterGroupsGameCenterLeaderboardsGetToManyRelationship**](GameCenterGroupsApi.md#gamecentergroupsgamecenterleaderboardsgettomanyrelationship) | **GET** /v1/gameCenterGroups/{id}/relationships/gameCenterLeaderboards |  |
| [**GameCenterGroupsGameCenterLeaderboardsReplaceToManyRelationship**](GameCenterGroupsApi.md#gamecentergroupsgamecenterleaderboardsreplacetomanyrelationship) | **PATCH** /v1/gameCenterGroups/{id}/relationships/gameCenterLeaderboards |  |
| [**GameCenterGroupsGetCollection**](GameCenterGroupsApi.md#gamecentergroupsgetcollection) | **GET** /v1/gameCenterGroups |  |
| [**GameCenterGroupsGetInstance**](GameCenterGroupsApi.md#gamecentergroupsgetinstance) | **GET** /v1/gameCenterGroups/{id} |  |
| [**GameCenterGroupsUpdateInstance**](GameCenterGroupsApi.md#gamecentergroupsupdateinstance) | **PATCH** /v1/gameCenterGroups/{id} |  |

<a id="gamecentergroupscreateinstance"></a>
# **GameCenterGroupsCreateInstance**
> GameCenterGroupResponse GameCenterGroupsCreateInstance (GameCenterGroupCreateRequest gameCenterGroupCreateRequest)



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
    public class GameCenterGroupsCreateInstanceExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var gameCenterGroupCreateRequest = new GameCenterGroupCreateRequest(); // GameCenterGroupCreateRequest | GameCenterGroup representation

            try
            {
                GameCenterGroupResponse result = apiInstance.GameCenterGroupsCreateInstance(gameCenterGroupCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterGroupResponse> response = apiInstance.GameCenterGroupsCreateInstanceWithHttpInfo(gameCenterGroupCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gameCenterGroupCreateRequest** | [**GameCenterGroupCreateRequest**](GameCenterGroupCreateRequest.md) | GameCenterGroup representation |  |

### Return type

[**GameCenterGroupResponse**](GameCenterGroupResponse.md)

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
| **201** | Single GameCenterGroup |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsdeleteinstance"></a>
# **GameCenterGroupsDeleteInstance**
> void GameCenterGroupsDeleteInstance (string id)



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
    public class GameCenterGroupsDeleteInstanceExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.GameCenterGroupsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterGroupsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a id="gamecentergroupsgamecenterachievementsgettomanyrelated"></a>
# **GameCenterGroupsGameCenterAchievementsGetToManyRelated**
> GameCenterAchievementsResponse GameCenterGroupsGameCenterAchievementsGetToManyRelated (string id, List<string>? filterReferenceName = null, List<string>? filterArchived = null, List<string>? filterId = null, List<string>? fieldsGameCenterAchievements = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterAchievementLocalizations = null, List<string>? fieldsGameCenterAchievementReleases = null, int? limit = null, List<string>? include = null, int? limitLocalizations = null, int? limitReleases = null)



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
    public class GameCenterGroupsGameCenterAchievementsGetToManyRelatedExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterReferenceName = new List<string>?(); // List<string>? | filter by attribute 'referenceName' (optional) 
            var filterArchived = new List<string>?(); // List<string>? | filter by attribute 'archived' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterGroups (optional) 
            var fieldsGameCenterAchievementLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementLocalizations (optional) 
            var fieldsGameCenterAchievementReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementReleases (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitLocalizations = 56;  // int? | maximum number of related localizations returned (when they are included) (optional) 
            var limitReleases = 56;  // int? | maximum number of related releases returned (when they are included) (optional) 

            try
            {
                GameCenterAchievementsResponse result = apiInstance.GameCenterGroupsGameCenterAchievementsGetToManyRelated(id, filterReferenceName, filterArchived, filterId, fieldsGameCenterAchievements, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievementReleases, limit, include, limitLocalizations, limitReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterAchievementsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterAchievementsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementsResponse> response = apiInstance.GameCenterGroupsGameCenterAchievementsGetToManyRelatedWithHttpInfo(id, filterReferenceName, filterArchived, filterId, fieldsGameCenterAchievements, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievementReleases, limit, include, limitLocalizations, limitReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterAchievementsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterReferenceName** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;referenceName&#39; | [optional]  |
| **filterArchived** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;archived&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **fieldsGameCenterAchievements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievements | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterGroups | [optional]  |
| **fieldsGameCenterAchievementLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementLocalizations | [optional]  |
| **fieldsGameCenterAchievementReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementReleases | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitLocalizations** | **int?** | maximum number of related localizations returned (when they are included) | [optional]  |
| **limitReleases** | **int?** | maximum number of related releases returned (when they are included) | [optional]  |

### Return type

[**GameCenterAchievementsResponse**](GameCenterAchievementsResponse.md)

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
| **200** | List of GameCenterAchievements |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsgamecenterachievementsgettomanyrelationship"></a>
# **GameCenterGroupsGameCenterAchievementsGetToManyRelationship**
> GameCenterGroupGameCenterAchievementsLinkagesResponse GameCenterGroupsGameCenterAchievementsGetToManyRelationship (string id, int? limit = null)



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
    public class GameCenterGroupsGameCenterAchievementsGetToManyRelationshipExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                GameCenterGroupGameCenterAchievementsLinkagesResponse result = apiInstance.GameCenterGroupsGameCenterAchievementsGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterAchievementsGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterAchievementsGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterGroupGameCenterAchievementsLinkagesResponse> response = apiInstance.GameCenterGroupsGameCenterAchievementsGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterAchievementsGetToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**GameCenterGroupGameCenterAchievementsLinkagesResponse**](GameCenterGroupGameCenterAchievementsLinkagesResponse.md)

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
| **200** | List of related linkages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsgamecenterachievementsreplacetomanyrelationship"></a>
# **GameCenterGroupsGameCenterAchievementsReplaceToManyRelationship**
> void GameCenterGroupsGameCenterAchievementsReplaceToManyRelationship (string id, GameCenterGroupGameCenterAchievementsLinkagesRequest gameCenterGroupGameCenterAchievementsLinkagesRequest)



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
    public class GameCenterGroupsGameCenterAchievementsReplaceToManyRelationshipExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterGroupGameCenterAchievementsLinkagesRequest = new GameCenterGroupGameCenterAchievementsLinkagesRequest(); // GameCenterGroupGameCenterAchievementsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.GameCenterGroupsGameCenterAchievementsReplaceToManyRelationship(id, gameCenterGroupGameCenterAchievementsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterAchievementsReplaceToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterAchievementsReplaceToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterGroupsGameCenterAchievementsReplaceToManyRelationshipWithHttpInfo(id, gameCenterGroupGameCenterAchievementsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterAchievementsReplaceToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterGroupGameCenterAchievementsLinkagesRequest** | [**GameCenterGroupGameCenterAchievementsLinkagesRequest**](GameCenterGroupGameCenterAchievementsLinkagesRequest.md) | List of related linkages |  |

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

<a id="gamecentergroupsgamecenterdetailsgettomanyrelated"></a>
# **GameCenterGroupsGameCenterDetailsGetToManyRelated**
> GameCenterDetailsResponse GameCenterGroupsGameCenterDetailsGetToManyRelated (string id, List<string>? filterGameCenterAppVersionsEnabled = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsApps = null, List<string>? fieldsGameCenterAppVersions = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterLeaderboards = null, List<string>? fieldsGameCenterLeaderboardSets = null, List<string>? fieldsGameCenterAchievements = null, List<string>? fieldsGameCenterAchievementReleases = null, List<string>? fieldsGameCenterLeaderboardReleases = null, List<string>? fieldsGameCenterLeaderboardSetReleases = null, int? limit = null, List<string>? include = null, int? limitGameCenterAppVersions = null, int? limitGameCenterLeaderboards = null, int? limitGameCenterLeaderboardSets = null, int? limitGameCenterAchievements = null, int? limitAchievementReleases = null, int? limitLeaderboardReleases = null, int? limitLeaderboardSetReleases = null)



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
    public class GameCenterGroupsGameCenterDetailsGetToManyRelatedExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterGameCenterAppVersionsEnabled = new List<string>?(); // List<string>? | filter by attribute 'gameCenterAppVersions.enabled' (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsGameCenterAppVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAppVersions (optional) 
            var fieldsGameCenterGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterGroups (optional) 
            var fieldsGameCenterLeaderboards = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboards (optional) 
            var fieldsGameCenterLeaderboardSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSets (optional) 
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var fieldsGameCenterAchievementReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementReleases (optional) 
            var fieldsGameCenterLeaderboardReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardReleases (optional) 
            var fieldsGameCenterLeaderboardSetReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSetReleases (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitGameCenterAppVersions = 56;  // int? | maximum number of related gameCenterAppVersions returned (when they are included) (optional) 
            var limitGameCenterLeaderboards = 56;  // int? | maximum number of related gameCenterLeaderboards returned (when they are included) (optional) 
            var limitGameCenterLeaderboardSets = 56;  // int? | maximum number of related gameCenterLeaderboardSets returned (when they are included) (optional) 
            var limitGameCenterAchievements = 56;  // int? | maximum number of related gameCenterAchievements returned (when they are included) (optional) 
            var limitAchievementReleases = 56;  // int? | maximum number of related achievementReleases returned (when they are included) (optional) 
            var limitLeaderboardReleases = 56;  // int? | maximum number of related leaderboardReleases returned (when they are included) (optional) 
            var limitLeaderboardSetReleases = 56;  // int? | maximum number of related leaderboardSetReleases returned (when they are included) (optional) 

            try
            {
                GameCenterDetailsResponse result = apiInstance.GameCenterGroupsGameCenterDetailsGetToManyRelated(id, filterGameCenterAppVersionsEnabled, fieldsGameCenterDetails, fieldsApps, fieldsGameCenterAppVersions, fieldsGameCenterGroups, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, fieldsGameCenterAchievementReleases, fieldsGameCenterLeaderboardReleases, fieldsGameCenterLeaderboardSetReleases, limit, include, limitGameCenterAppVersions, limitGameCenterLeaderboards, limitGameCenterLeaderboardSets, limitGameCenterAchievements, limitAchievementReleases, limitLeaderboardReleases, limitLeaderboardSetReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterDetailsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterDetailsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterDetailsResponse> response = apiInstance.GameCenterGroupsGameCenterDetailsGetToManyRelatedWithHttpInfo(id, filterGameCenterAppVersionsEnabled, fieldsGameCenterDetails, fieldsApps, fieldsGameCenterAppVersions, fieldsGameCenterGroups, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, fieldsGameCenterAchievementReleases, fieldsGameCenterLeaderboardReleases, fieldsGameCenterLeaderboardSetReleases, limit, include, limitGameCenterAppVersions, limitGameCenterLeaderboards, limitGameCenterLeaderboardSets, limitGameCenterAchievements, limitAchievementReleases, limitLeaderboardReleases, limitLeaderboardSetReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterDetailsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterGameCenterAppVersionsEnabled** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;gameCenterAppVersions.enabled&#39; | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsGameCenterAppVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAppVersions | [optional]  |
| **fieldsGameCenterGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterGroups | [optional]  |
| **fieldsGameCenterLeaderboards** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboards | [optional]  |
| **fieldsGameCenterLeaderboardSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSets | [optional]  |
| **fieldsGameCenterAchievements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievements | [optional]  |
| **fieldsGameCenterAchievementReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementReleases | [optional]  |
| **fieldsGameCenterLeaderboardReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardReleases | [optional]  |
| **fieldsGameCenterLeaderboardSetReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSetReleases | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitGameCenterAppVersions** | **int?** | maximum number of related gameCenterAppVersions returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboards** | **int?** | maximum number of related gameCenterLeaderboards returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboardSets** | **int?** | maximum number of related gameCenterLeaderboardSets returned (when they are included) | [optional]  |
| **limitGameCenterAchievements** | **int?** | maximum number of related gameCenterAchievements returned (when they are included) | [optional]  |
| **limitAchievementReleases** | **int?** | maximum number of related achievementReleases returned (when they are included) | [optional]  |
| **limitLeaderboardReleases** | **int?** | maximum number of related leaderboardReleases returned (when they are included) | [optional]  |
| **limitLeaderboardSetReleases** | **int?** | maximum number of related leaderboardSetReleases returned (when they are included) | [optional]  |

### Return type

[**GameCenterDetailsResponse**](GameCenterDetailsResponse.md)

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
| **200** | List of GameCenterDetails |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsgamecenterleaderboardsetsgettomanyrelated"></a>
# **GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelated**
> GameCenterLeaderboardSetsResponse GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelated (string id, List<string>? filterReferenceName = null, List<string>? filterId = null, List<string>? fieldsGameCenterLeaderboardSets = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterLeaderboardSetLocalizations = null, List<string>? fieldsGameCenterLeaderboards = null, List<string>? fieldsGameCenterLeaderboardSetReleases = null, int? limit = null, List<string>? include = null, int? limitLocalizations = null, int? limitGameCenterLeaderboards = null, int? limitReleases = null)



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
    public class GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterReferenceName = new List<string>?(); // List<string>? | filter by attribute 'referenceName' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var fieldsGameCenterLeaderboardSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSets (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterGroups (optional) 
            var fieldsGameCenterLeaderboardSetLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSetLocalizations (optional) 
            var fieldsGameCenterLeaderboards = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboards (optional) 
            var fieldsGameCenterLeaderboardSetReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSetReleases (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitLocalizations = 56;  // int? | maximum number of related localizations returned (when they are included) (optional) 
            var limitGameCenterLeaderboards = 56;  // int? | maximum number of related gameCenterLeaderboards returned (when they are included) (optional) 
            var limitReleases = 56;  // int? | maximum number of related releases returned (when they are included) (optional) 

            try
            {
                GameCenterLeaderboardSetsResponse result = apiInstance.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelated(id, filterReferenceName, filterId, fieldsGameCenterLeaderboardSets, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSetLocalizations, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSetReleases, limit, include, limitLocalizations, limitGameCenterLeaderboards, limitReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterLeaderboardSetsResponse> response = apiInstance.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedWithHttpInfo(id, filterReferenceName, filterId, fieldsGameCenterLeaderboardSets, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSetLocalizations, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSetReleases, limit, include, limitLocalizations, limitGameCenterLeaderboards, limitReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterReferenceName** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;referenceName&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **fieldsGameCenterLeaderboardSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSets | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterGroups | [optional]  |
| **fieldsGameCenterLeaderboardSetLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSetLocalizations | [optional]  |
| **fieldsGameCenterLeaderboards** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboards | [optional]  |
| **fieldsGameCenterLeaderboardSetReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSetReleases | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitLocalizations** | **int?** | maximum number of related localizations returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboards** | **int?** | maximum number of related gameCenterLeaderboards returned (when they are included) | [optional]  |
| **limitReleases** | **int?** | maximum number of related releases returned (when they are included) | [optional]  |

### Return type

[**GameCenterLeaderboardSetsResponse**](GameCenterLeaderboardSetsResponse.md)

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
| **200** | List of GameCenterLeaderboardSets |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsgamecenterleaderboardsetsgettomanyrelationship"></a>
# **GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelationship**
> GameCenterGroupGameCenterLeaderboardSetsLinkagesResponse GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelationship (string id, int? limit = null)



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
    public class GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelationshipExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                GameCenterGroupGameCenterLeaderboardSetsLinkagesResponse result = apiInstance.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterGroupGameCenterLeaderboardSetsLinkagesResponse> response = apiInstance.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**GameCenterGroupGameCenterLeaderboardSetsLinkagesResponse**](GameCenterGroupGameCenterLeaderboardSetsLinkagesResponse.md)

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
| **200** | List of related linkages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsgamecenterleaderboardsetsreplacetomanyrelationship"></a>
# **GameCenterGroupsGameCenterLeaderboardSetsReplaceToManyRelationship**
> void GameCenterGroupsGameCenterLeaderboardSetsReplaceToManyRelationship (string id, GameCenterGroupGameCenterLeaderboardSetsLinkagesRequest gameCenterGroupGameCenterLeaderboardSetsLinkagesRequest)



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
    public class GameCenterGroupsGameCenterLeaderboardSetsReplaceToManyRelationshipExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterGroupGameCenterLeaderboardSetsLinkagesRequest = new GameCenterGroupGameCenterLeaderboardSetsLinkagesRequest(); // GameCenterGroupGameCenterLeaderboardSetsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.GameCenterGroupsGameCenterLeaderboardSetsReplaceToManyRelationship(id, gameCenterGroupGameCenterLeaderboardSetsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardSetsReplaceToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterLeaderboardSetsReplaceToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterGroupsGameCenterLeaderboardSetsReplaceToManyRelationshipWithHttpInfo(id, gameCenterGroupGameCenterLeaderboardSetsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardSetsReplaceToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterGroupGameCenterLeaderboardSetsLinkagesRequest** | [**GameCenterGroupGameCenterLeaderboardSetsLinkagesRequest**](GameCenterGroupGameCenterLeaderboardSetsLinkagesRequest.md) | List of related linkages |  |

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

<a id="gamecentergroupsgamecenterleaderboardsgettomanyrelated"></a>
# **GameCenterGroupsGameCenterLeaderboardsGetToManyRelated**
> GameCenterLeaderboardsResponse GameCenterGroupsGameCenterLeaderboardsGetToManyRelated (string id, List<string>? filterReferenceName = null, List<string>? filterArchived = null, List<string>? filterId = null, List<string>? fieldsGameCenterLeaderboards = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterLeaderboardSets = null, List<string>? fieldsGameCenterLeaderboardLocalizations = null, List<string>? fieldsGameCenterLeaderboardReleases = null, int? limit = null, List<string>? include = null, int? limitGameCenterLeaderboardSets = null, int? limitLocalizations = null, int? limitReleases = null)



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
    public class GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterReferenceName = new List<string>?(); // List<string>? | filter by attribute 'referenceName' (optional) 
            var filterArchived = new List<string>?(); // List<string>? | filter by attribute 'archived' (optional) 
            var filterId = new List<string>?(); // List<string>? | filter by id(s) (optional) 
            var fieldsGameCenterLeaderboards = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboards (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterGroups (optional) 
            var fieldsGameCenterLeaderboardSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSets (optional) 
            var fieldsGameCenterLeaderboardLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardLocalizations (optional) 
            var fieldsGameCenterLeaderboardReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardReleases (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitGameCenterLeaderboardSets = 56;  // int? | maximum number of related gameCenterLeaderboardSets returned (when they are included) (optional) 
            var limitLocalizations = 56;  // int? | maximum number of related localizations returned (when they are included) (optional) 
            var limitReleases = 56;  // int? | maximum number of related releases returned (when they are included) (optional) 

            try
            {
                GameCenterLeaderboardsResponse result = apiInstance.GameCenterGroupsGameCenterLeaderboardsGetToManyRelated(id, filterReferenceName, filterArchived, filterId, fieldsGameCenterLeaderboards, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSets, fieldsGameCenterLeaderboardLocalizations, fieldsGameCenterLeaderboardReleases, limit, include, limitGameCenterLeaderboardSets, limitLocalizations, limitReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterLeaderboardsResponse> response = apiInstance.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedWithHttpInfo(id, filterReferenceName, filterArchived, filterId, fieldsGameCenterLeaderboards, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSets, fieldsGameCenterLeaderboardLocalizations, fieldsGameCenterLeaderboardReleases, limit, include, limitGameCenterLeaderboardSets, limitLocalizations, limitReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterReferenceName** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;referenceName&#39; | [optional]  |
| **filterArchived** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;archived&#39; | [optional]  |
| **filterId** | [**List&lt;string&gt;?**](string.md) | filter by id(s) | [optional]  |
| **fieldsGameCenterLeaderboards** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboards | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterGroups | [optional]  |
| **fieldsGameCenterLeaderboardSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSets | [optional]  |
| **fieldsGameCenterLeaderboardLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardLocalizations | [optional]  |
| **fieldsGameCenterLeaderboardReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardReleases | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitGameCenterLeaderboardSets** | **int?** | maximum number of related gameCenterLeaderboardSets returned (when they are included) | [optional]  |
| **limitLocalizations** | **int?** | maximum number of related localizations returned (when they are included) | [optional]  |
| **limitReleases** | **int?** | maximum number of related releases returned (when they are included) | [optional]  |

### Return type

[**GameCenterLeaderboardsResponse**](GameCenterLeaderboardsResponse.md)

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
| **200** | List of GameCenterLeaderboards |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsgamecenterleaderboardsgettomanyrelationship"></a>
# **GameCenterGroupsGameCenterLeaderboardsGetToManyRelationship**
> GameCenterGroupGameCenterLeaderboardsLinkagesResponse GameCenterGroupsGameCenterLeaderboardsGetToManyRelationship (string id, int? limit = null)



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
    public class GameCenterGroupsGameCenterLeaderboardsGetToManyRelationshipExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                GameCenterGroupGameCenterLeaderboardsLinkagesResponse result = apiInstance.GameCenterGroupsGameCenterLeaderboardsGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardsGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterLeaderboardsGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterGroupGameCenterLeaderboardsLinkagesResponse> response = apiInstance.GameCenterGroupsGameCenterLeaderboardsGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardsGetToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**GameCenterGroupGameCenterLeaderboardsLinkagesResponse**](GameCenterGroupGameCenterLeaderboardsLinkagesResponse.md)

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
| **200** | List of related linkages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsgamecenterleaderboardsreplacetomanyrelationship"></a>
# **GameCenterGroupsGameCenterLeaderboardsReplaceToManyRelationship**
> void GameCenterGroupsGameCenterLeaderboardsReplaceToManyRelationship (string id, GameCenterGroupGameCenterLeaderboardsLinkagesRequest gameCenterGroupGameCenterLeaderboardsLinkagesRequest)



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
    public class GameCenterGroupsGameCenterLeaderboardsReplaceToManyRelationshipExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterGroupGameCenterLeaderboardsLinkagesRequest = new GameCenterGroupGameCenterLeaderboardsLinkagesRequest(); // GameCenterGroupGameCenterLeaderboardsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.GameCenterGroupsGameCenterLeaderboardsReplaceToManyRelationship(id, gameCenterGroupGameCenterLeaderboardsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardsReplaceToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGameCenterLeaderboardsReplaceToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterGroupsGameCenterLeaderboardsReplaceToManyRelationshipWithHttpInfo(id, gameCenterGroupGameCenterLeaderboardsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGameCenterLeaderboardsReplaceToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterGroupGameCenterLeaderboardsLinkagesRequest** | [**GameCenterGroupGameCenterLeaderboardsLinkagesRequest**](GameCenterGroupGameCenterLeaderboardsLinkagesRequest.md) | List of related linkages |  |

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

<a id="gamecentergroupsgetcollection"></a>
# **GameCenterGroupsGetCollection**
> GameCenterGroupsResponse GameCenterGroupsGetCollection (List<string>? filterGameCenterDetails = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterLeaderboards = null, List<string>? fieldsGameCenterLeaderboardSets = null, List<string>? fieldsGameCenterAchievements = null, int? limit = null, List<string>? include = null, int? limitGameCenterAchievements = null, int? limitGameCenterDetails = null, int? limitGameCenterLeaderboardSets = null, int? limitGameCenterLeaderboards = null)



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
    public class GameCenterGroupsGetCollectionExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var filterGameCenterDetails = new List<string>?(); // List<string>? | filter by id(s) of related 'gameCenterDetails' (optional) 
            var fieldsGameCenterGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterGroups (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterLeaderboards = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboards (optional) 
            var fieldsGameCenterLeaderboardSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSets (optional) 
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitGameCenterAchievements = 56;  // int? | maximum number of related gameCenterAchievements returned (when they are included) (optional) 
            var limitGameCenterDetails = 56;  // int? | maximum number of related gameCenterDetails returned (when they are included) (optional) 
            var limitGameCenterLeaderboardSets = 56;  // int? | maximum number of related gameCenterLeaderboardSets returned (when they are included) (optional) 
            var limitGameCenterLeaderboards = 56;  // int? | maximum number of related gameCenterLeaderboards returned (when they are included) (optional) 

            try
            {
                GameCenterGroupsResponse result = apiInstance.GameCenterGroupsGetCollection(filterGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterDetails, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, limit, include, limitGameCenterAchievements, limitGameCenterDetails, limitGameCenterLeaderboardSets, limitGameCenterLeaderboards);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterGroupsResponse> response = apiInstance.GameCenterGroupsGetCollectionWithHttpInfo(filterGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterDetails, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, limit, include, limitGameCenterAchievements, limitGameCenterDetails, limitGameCenterLeaderboardSets, limitGameCenterLeaderboards);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;gameCenterDetails&#39; | [optional]  |
| **fieldsGameCenterGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterGroups | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterLeaderboards** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboards | [optional]  |
| **fieldsGameCenterLeaderboardSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSets | [optional]  |
| **fieldsGameCenterAchievements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievements | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitGameCenterAchievements** | **int?** | maximum number of related gameCenterAchievements returned (when they are included) | [optional]  |
| **limitGameCenterDetails** | **int?** | maximum number of related gameCenterDetails returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboardSets** | **int?** | maximum number of related gameCenterLeaderboardSets returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboards** | **int?** | maximum number of related gameCenterLeaderboards returned (when they are included) | [optional]  |

### Return type

[**GameCenterGroupsResponse**](GameCenterGroupsResponse.md)

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
| **200** | List of GameCenterGroups |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsgetinstance"></a>
# **GameCenterGroupsGetInstance**
> GameCenterGroupResponse GameCenterGroupsGetInstance (string id, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterLeaderboards = null, List<string>? fieldsGameCenterLeaderboardSets = null, List<string>? fieldsGameCenterAchievements = null, List<string>? include = null, int? limitGameCenterAchievements = null, int? limitGameCenterDetails = null, int? limitGameCenterLeaderboardSets = null, int? limitGameCenterLeaderboards = null)



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
    public class GameCenterGroupsGetInstanceExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsGameCenterGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterGroups (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterLeaderboards = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboards (optional) 
            var fieldsGameCenterLeaderboardSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSets (optional) 
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitGameCenterAchievements = 56;  // int? | maximum number of related gameCenterAchievements returned (when they are included) (optional) 
            var limitGameCenterDetails = 56;  // int? | maximum number of related gameCenterDetails returned (when they are included) (optional) 
            var limitGameCenterLeaderboardSets = 56;  // int? | maximum number of related gameCenterLeaderboardSets returned (when they are included) (optional) 
            var limitGameCenterLeaderboards = 56;  // int? | maximum number of related gameCenterLeaderboards returned (when they are included) (optional) 

            try
            {
                GameCenterGroupResponse result = apiInstance.GameCenterGroupsGetInstance(id, fieldsGameCenterGroups, fieldsGameCenterDetails, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, include, limitGameCenterAchievements, limitGameCenterDetails, limitGameCenterLeaderboardSets, limitGameCenterLeaderboards);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterGroupResponse> response = apiInstance.GameCenterGroupsGetInstanceWithHttpInfo(id, fieldsGameCenterGroups, fieldsGameCenterDetails, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, include, limitGameCenterAchievements, limitGameCenterDetails, limitGameCenterLeaderboardSets, limitGameCenterLeaderboards);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsGameCenterGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterGroups | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterLeaderboards** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboards | [optional]  |
| **fieldsGameCenterLeaderboardSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSets | [optional]  |
| **fieldsGameCenterAchievements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievements | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitGameCenterAchievements** | **int?** | maximum number of related gameCenterAchievements returned (when they are included) | [optional]  |
| **limitGameCenterDetails** | **int?** | maximum number of related gameCenterDetails returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboardSets** | **int?** | maximum number of related gameCenterLeaderboardSets returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboards** | **int?** | maximum number of related gameCenterLeaderboards returned (when they are included) | [optional]  |

### Return type

[**GameCenterGroupResponse**](GameCenterGroupResponse.md)

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
| **200** | Single GameCenterGroup |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecentergroupsupdateinstance"></a>
# **GameCenterGroupsUpdateInstance**
> GameCenterGroupResponse GameCenterGroupsUpdateInstance (string id, GameCenterGroupUpdateRequest gameCenterGroupUpdateRequest)



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
    public class GameCenterGroupsUpdateInstanceExample
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
            var apiInstance = new GameCenterGroupsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterGroupUpdateRequest = new GameCenterGroupUpdateRequest(); // GameCenterGroupUpdateRequest | GameCenterGroup representation

            try
            {
                GameCenterGroupResponse result = apiInstance.GameCenterGroupsUpdateInstance(id, gameCenterGroupUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterGroupsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterGroupResponse> response = apiInstance.GameCenterGroupsUpdateInstanceWithHttpInfo(id, gameCenterGroupUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterGroupsApi.GameCenterGroupsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterGroupUpdateRequest** | [**GameCenterGroupUpdateRequest**](GameCenterGroupUpdateRequest.md) | GameCenterGroup representation |  |

### Return type

[**GameCenterGroupResponse**](GameCenterGroupResponse.md)

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
| **200** | Single GameCenterGroup |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

