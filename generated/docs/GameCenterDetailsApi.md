# AppStoreConnect.Net.Api.GameCenterDetailsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GameCenterDetailsAchievementReleasesGetToManyRelated**](GameCenterDetailsApi.md#gamecenterdetailsachievementreleasesgettomanyrelated) | **GET** /v1/gameCenterDetails/{id}/achievementReleases |  |
| [**GameCenterDetailsClassicMatchmakingRequestsGetMetrics**](GameCenterDetailsApi.md#gamecenterdetailsclassicmatchmakingrequestsgetmetrics) | **GET** /v1/gameCenterDetails/{id}/metrics/classicMatchmakingRequests |  |
| [**GameCenterDetailsCreateInstance**](GameCenterDetailsApi.md#gamecenterdetailscreateinstance) | **POST** /v1/gameCenterDetails |  |
| [**GameCenterDetailsGameCenterAchievementsGetToManyRelated**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterachievementsgettomanyrelated) | **GET** /v1/gameCenterDetails/{id}/gameCenterAchievements |  |
| [**GameCenterDetailsGameCenterAchievementsGetToManyRelationship**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterachievementsgettomanyrelationship) | **GET** /v1/gameCenterDetails/{id}/relationships/gameCenterAchievements |  |
| [**GameCenterDetailsGameCenterAchievementsReplaceToManyRelationship**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterachievementsreplacetomanyrelationship) | **PATCH** /v1/gameCenterDetails/{id}/relationships/gameCenterAchievements |  |
| [**GameCenterDetailsGameCenterAppVersionsGetToManyRelated**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterappversionsgettomanyrelated) | **GET** /v1/gameCenterDetails/{id}/gameCenterAppVersions |  |
| [**GameCenterDetailsGameCenterGroupGetToOneRelated**](GameCenterDetailsApi.md#gamecenterdetailsgamecentergroupgettoonerelated) | **GET** /v1/gameCenterDetails/{id}/gameCenterGroup |  |
| [**GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelated**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterleaderboardsetsgettomanyrelated) | **GET** /v1/gameCenterDetails/{id}/gameCenterLeaderboardSets |  |
| [**GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelationship**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterleaderboardsetsgettomanyrelationship) | **GET** /v1/gameCenterDetails/{id}/relationships/gameCenterLeaderboardSets |  |
| [**GameCenterDetailsGameCenterLeaderboardSetsReplaceToManyRelationship**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterleaderboardsetsreplacetomanyrelationship) | **PATCH** /v1/gameCenterDetails/{id}/relationships/gameCenterLeaderboardSets |  |
| [**GameCenterDetailsGameCenterLeaderboardsGetToManyRelated**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterleaderboardsgettomanyrelated) | **GET** /v1/gameCenterDetails/{id}/gameCenterLeaderboards |  |
| [**GameCenterDetailsGameCenterLeaderboardsGetToManyRelationship**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterleaderboardsgettomanyrelationship) | **GET** /v1/gameCenterDetails/{id}/relationships/gameCenterLeaderboards |  |
| [**GameCenterDetailsGameCenterLeaderboardsReplaceToManyRelationship**](GameCenterDetailsApi.md#gamecenterdetailsgamecenterleaderboardsreplacetomanyrelationship) | **PATCH** /v1/gameCenterDetails/{id}/relationships/gameCenterLeaderboards |  |
| [**GameCenterDetailsGetInstance**](GameCenterDetailsApi.md#gamecenterdetailsgetinstance) | **GET** /v1/gameCenterDetails/{id} |  |
| [**GameCenterDetailsLeaderboardReleasesGetToManyRelated**](GameCenterDetailsApi.md#gamecenterdetailsleaderboardreleasesgettomanyrelated) | **GET** /v1/gameCenterDetails/{id}/leaderboardReleases |  |
| [**GameCenterDetailsLeaderboardSetReleasesGetToManyRelated**](GameCenterDetailsApi.md#gamecenterdetailsleaderboardsetreleasesgettomanyrelated) | **GET** /v1/gameCenterDetails/{id}/leaderboardSetReleases |  |
| [**GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics**](GameCenterDetailsApi.md#gamecenterdetailsrulebasedmatchmakingrequestsgetmetrics) | **GET** /v1/gameCenterDetails/{id}/metrics/ruleBasedMatchmakingRequests |  |
| [**GameCenterDetailsUpdateInstance**](GameCenterDetailsApi.md#gamecenterdetailsupdateinstance) | **PATCH** /v1/gameCenterDetails/{id} |  |

<a id="gamecenterdetailsachievementreleasesgettomanyrelated"></a>
# **GameCenterDetailsAchievementReleasesGetToManyRelated**
> GameCenterAchievementReleasesResponse GameCenterDetailsAchievementReleasesGetToManyRelated (string id, List<string>? filterLive = null, List<string>? filterGameCenterAchievement = null, List<string>? fieldsGameCenterAchievementReleases = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterAchievements = null, int? limit = null, List<string>? include = null)



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
    public class GameCenterDetailsAchievementReleasesGetToManyRelatedExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterLive = new List<string>?(); // List<string>? | filter by attribute 'live' (optional) 
            var filterGameCenterAchievement = new List<string>?(); // List<string>? | filter by id(s) of related 'gameCenterAchievement' (optional) 
            var fieldsGameCenterAchievementReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementReleases (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                GameCenterAchievementReleasesResponse result = apiInstance.GameCenterDetailsAchievementReleasesGetToManyRelated(id, filterLive, filterGameCenterAchievement, fieldsGameCenterAchievementReleases, fieldsGameCenterDetails, fieldsGameCenterAchievements, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsAchievementReleasesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsAchievementReleasesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementReleasesResponse> response = apiInstance.GameCenterDetailsAchievementReleasesGetToManyRelatedWithHttpInfo(id, filterLive, filterGameCenterAchievement, fieldsGameCenterAchievementReleases, fieldsGameCenterDetails, fieldsGameCenterAchievements, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsAchievementReleasesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterLive** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;live&#39; | [optional]  |
| **filterGameCenterAchievement** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;gameCenterAchievement&#39; | [optional]  |
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

<a id="gamecenterdetailsclassicmatchmakingrequestsgetmetrics"></a>
# **GameCenterDetailsClassicMatchmakingRequestsGetMetrics**
> GameCenterMatchmakingAppRequestsV1MetricResponse GameCenterDetailsClassicMatchmakingRequestsGetMetrics (string id, string granularity, List<string>? groupBy = null, string? filterResult = null, List<string>? sort = null, int? limit = null)



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
    public class GameCenterDetailsClassicMatchmakingRequestsGetMetricsExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterResult = "MATCHED";  // string? | filter by 'result' attribute dimension (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingAppRequestsV1MetricResponse result = apiInstance.GameCenterDetailsClassicMatchmakingRequestsGetMetrics(id, granularity, groupBy, filterResult, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsClassicMatchmakingRequestsGetMetrics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsClassicMatchmakingRequestsGetMetricsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingAppRequestsV1MetricResponse> response = apiInstance.GameCenterDetailsClassicMatchmakingRequestsGetMetricsWithHttpInfo(id, granularity, groupBy, filterResult, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsClassicMatchmakingRequestsGetMetricsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **granularity** | **string** | the granularity of the per-group dataset |  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | the dimension by which to group the results | [optional]  |
| **filterResult** | **string?** | filter by &#39;result&#39; attribute dimension | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingAppRequestsV1MetricResponse**](GameCenterMatchmakingAppRequestsV1MetricResponse.md)

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
| **200** | Metrics data response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterdetailscreateinstance"></a>
# **GameCenterDetailsCreateInstance**
> GameCenterDetailResponse GameCenterDetailsCreateInstance (GameCenterDetailCreateRequest gameCenterDetailCreateRequest)



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
    public class GameCenterDetailsCreateInstanceExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var gameCenterDetailCreateRequest = new GameCenterDetailCreateRequest(); // GameCenterDetailCreateRequest | GameCenterDetail representation

            try
            {
                GameCenterDetailResponse result = apiInstance.GameCenterDetailsCreateInstance(gameCenterDetailCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterDetailResponse> response = apiInstance.GameCenterDetailsCreateInstanceWithHttpInfo(gameCenterDetailCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gameCenterDetailCreateRequest** | [**GameCenterDetailCreateRequest**](GameCenterDetailCreateRequest.md) | GameCenterDetail representation |  |

### Return type

[**GameCenterDetailResponse**](GameCenterDetailResponse.md)

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
| **201** | Single GameCenterDetail |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterdetailsgamecenterachievementsgettomanyrelated"></a>
# **GameCenterDetailsGameCenterAchievementsGetToManyRelated**
> GameCenterAchievementsResponse GameCenterDetailsGameCenterAchievementsGetToManyRelated (string id, List<string>? filterReferenceName = null, List<string>? filterArchived = null, List<string>? filterId = null, List<string>? fieldsGameCenterAchievements = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterAchievementLocalizations = null, List<string>? fieldsGameCenterAchievementReleases = null, int? limit = null, List<string>? include = null, int? limitLocalizations = null, int? limitReleases = null)



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
    public class GameCenterDetailsGameCenterAchievementsGetToManyRelatedExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
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
                GameCenterAchievementsResponse result = apiInstance.GameCenterDetailsGameCenterAchievementsGetToManyRelated(id, filterReferenceName, filterArchived, filterId, fieldsGameCenterAchievements, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievementReleases, limit, include, limitLocalizations, limitReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterAchievementsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterAchievementsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAchievementsResponse> response = apiInstance.GameCenterDetailsGameCenterAchievementsGetToManyRelatedWithHttpInfo(id, filterReferenceName, filterArchived, filterId, fieldsGameCenterAchievements, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterAchievementLocalizations, fieldsGameCenterAchievementReleases, limit, include, limitLocalizations, limitReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterAchievementsGetToManyRelatedWithHttpInfo: " + e.Message);
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

<a id="gamecenterdetailsgamecenterachievementsgettomanyrelationship"></a>
# **GameCenterDetailsGameCenterAchievementsGetToManyRelationship**
> GameCenterDetailGameCenterAchievementsLinkagesResponse GameCenterDetailsGameCenterAchievementsGetToManyRelationship (string id, int? limit = null)



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
    public class GameCenterDetailsGameCenterAchievementsGetToManyRelationshipExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                GameCenterDetailGameCenterAchievementsLinkagesResponse result = apiInstance.GameCenterDetailsGameCenterAchievementsGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterAchievementsGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterAchievementsGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterDetailGameCenterAchievementsLinkagesResponse> response = apiInstance.GameCenterDetailsGameCenterAchievementsGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterAchievementsGetToManyRelationshipWithHttpInfo: " + e.Message);
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

[**GameCenterDetailGameCenterAchievementsLinkagesResponse**](GameCenterDetailGameCenterAchievementsLinkagesResponse.md)

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

<a id="gamecenterdetailsgamecenterachievementsreplacetomanyrelationship"></a>
# **GameCenterDetailsGameCenterAchievementsReplaceToManyRelationship**
> void GameCenterDetailsGameCenterAchievementsReplaceToManyRelationship (string id, GameCenterDetailGameCenterAchievementsLinkagesRequest gameCenterDetailGameCenterAchievementsLinkagesRequest)



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
    public class GameCenterDetailsGameCenterAchievementsReplaceToManyRelationshipExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterDetailGameCenterAchievementsLinkagesRequest = new GameCenterDetailGameCenterAchievementsLinkagesRequest(); // GameCenterDetailGameCenterAchievementsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.GameCenterDetailsGameCenterAchievementsReplaceToManyRelationship(id, gameCenterDetailGameCenterAchievementsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterAchievementsReplaceToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterAchievementsReplaceToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterDetailsGameCenterAchievementsReplaceToManyRelationshipWithHttpInfo(id, gameCenterDetailGameCenterAchievementsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterAchievementsReplaceToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterDetailGameCenterAchievementsLinkagesRequest** | [**GameCenterDetailGameCenterAchievementsLinkagesRequest**](GameCenterDetailGameCenterAchievementsLinkagesRequest.md) | List of related linkages |  |

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

<a id="gamecenterdetailsgamecenterappversionsgettomanyrelated"></a>
# **GameCenterDetailsGameCenterAppVersionsGetToManyRelated**
> GameCenterAppVersionsResponse GameCenterDetailsGameCenterAppVersionsGetToManyRelated (string id, List<string>? filterEnabled = null, List<string>? fieldsGameCenterAppVersions = null, List<string>? fieldsAppStoreVersions = null, int? limit = null, List<string>? include = null, int? limitCompatibilityVersions = null)



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
    public class GameCenterDetailsGameCenterAppVersionsGetToManyRelatedExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterEnabled = new List<string>?(); // List<string>? | filter by attribute 'enabled' (optional) 
            var fieldsGameCenterAppVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAppVersions (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitCompatibilityVersions = 56;  // int? | maximum number of related compatibilityVersions returned (when they are included) (optional) 

            try
            {
                GameCenterAppVersionsResponse result = apiInstance.GameCenterDetailsGameCenterAppVersionsGetToManyRelated(id, filterEnabled, fieldsGameCenterAppVersions, fieldsAppStoreVersions, limit, include, limitCompatibilityVersions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterAppVersionsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterAppVersionsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAppVersionsResponse> response = apiInstance.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedWithHttpInfo(id, filterEnabled, fieldsGameCenterAppVersions, fieldsAppStoreVersions, limit, include, limitCompatibilityVersions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterEnabled** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;enabled&#39; | [optional]  |
| **fieldsGameCenterAppVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAppVersions | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitCompatibilityVersions** | **int?** | maximum number of related compatibilityVersions returned (when they are included) | [optional]  |

### Return type

[**GameCenterAppVersionsResponse**](GameCenterAppVersionsResponse.md)

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
| **200** | List of GameCenterAppVersions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterdetailsgamecentergroupgettoonerelated"></a>
# **GameCenterDetailsGameCenterGroupGetToOneRelated**
> GameCenterGroupResponse GameCenterDetailsGameCenterGroupGetToOneRelated (string id, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterLeaderboards = null, List<string>? fieldsGameCenterLeaderboardSets = null, List<string>? fieldsGameCenterAchievements = null, List<string>? include = null, int? limitGameCenterDetails = null, int? limitGameCenterLeaderboards = null, int? limitGameCenterLeaderboardSets = null, int? limitGameCenterAchievements = null)



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
    public class GameCenterDetailsGameCenterGroupGetToOneRelatedExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsGameCenterGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterGroups (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterLeaderboards = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboards (optional) 
            var fieldsGameCenterLeaderboardSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSets (optional) 
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitGameCenterDetails = 56;  // int? | maximum number of related gameCenterDetails returned (when they are included) (optional) 
            var limitGameCenterLeaderboards = 56;  // int? | maximum number of related gameCenterLeaderboards returned (when they are included) (optional) 
            var limitGameCenterLeaderboardSets = 56;  // int? | maximum number of related gameCenterLeaderboardSets returned (when they are included) (optional) 
            var limitGameCenterAchievements = 56;  // int? | maximum number of related gameCenterAchievements returned (when they are included) (optional) 

            try
            {
                GameCenterGroupResponse result = apiInstance.GameCenterDetailsGameCenterGroupGetToOneRelated(id, fieldsGameCenterGroups, fieldsGameCenterDetails, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, include, limitGameCenterDetails, limitGameCenterLeaderboards, limitGameCenterLeaderboardSets, limitGameCenterAchievements);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterGroupGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterGroupGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterGroupResponse> response = apiInstance.GameCenterDetailsGameCenterGroupGetToOneRelatedWithHttpInfo(id, fieldsGameCenterGroups, fieldsGameCenterDetails, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, include, limitGameCenterDetails, limitGameCenterLeaderboards, limitGameCenterLeaderboardSets, limitGameCenterAchievements);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterGroupGetToOneRelatedWithHttpInfo: " + e.Message);
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
| **limitGameCenterDetails** | **int?** | maximum number of related gameCenterDetails returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboards** | **int?** | maximum number of related gameCenterLeaderboards returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboardSets** | **int?** | maximum number of related gameCenterLeaderboardSets returned (when they are included) | [optional]  |
| **limitGameCenterAchievements** | **int?** | maximum number of related gameCenterAchievements returned (when they are included) | [optional]  |

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

<a id="gamecenterdetailsgamecenterleaderboardsetsgettomanyrelated"></a>
# **GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelated**
> GameCenterLeaderboardSetsResponse GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelated (string id, List<string>? filterReferenceName = null, List<string>? filterId = null, List<string>? fieldsGameCenterLeaderboardSets = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterLeaderboardSetLocalizations = null, List<string>? fieldsGameCenterLeaderboards = null, List<string>? fieldsGameCenterLeaderboardSetReleases = null, int? limit = null, List<string>? include = null, int? limitLocalizations = null, int? limitGameCenterLeaderboards = null, int? limitReleases = null)



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
    public class GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
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
                GameCenterLeaderboardSetsResponse result = apiInstance.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelated(id, filterReferenceName, filterId, fieldsGameCenterLeaderboardSets, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSetLocalizations, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSetReleases, limit, include, limitLocalizations, limitGameCenterLeaderboards, limitReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterLeaderboardSetsResponse> response = apiInstance.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedWithHttpInfo(id, filterReferenceName, filterId, fieldsGameCenterLeaderboardSets, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSetLocalizations, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSetReleases, limit, include, limitLocalizations, limitGameCenterLeaderboards, limitReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedWithHttpInfo: " + e.Message);
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

<a id="gamecenterdetailsgamecenterleaderboardsetsgettomanyrelationship"></a>
# **GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelationship**
> GameCenterDetailGameCenterLeaderboardSetsLinkagesResponse GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelationship (string id, int? limit = null)



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
    public class GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelationshipExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                GameCenterDetailGameCenterLeaderboardSetsLinkagesResponse result = apiInstance.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterDetailGameCenterLeaderboardSetsLinkagesResponse> response = apiInstance.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelationshipWithHttpInfo: " + e.Message);
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

[**GameCenterDetailGameCenterLeaderboardSetsLinkagesResponse**](GameCenterDetailGameCenterLeaderboardSetsLinkagesResponse.md)

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

<a id="gamecenterdetailsgamecenterleaderboardsetsreplacetomanyrelationship"></a>
# **GameCenterDetailsGameCenterLeaderboardSetsReplaceToManyRelationship**
> void GameCenterDetailsGameCenterLeaderboardSetsReplaceToManyRelationship (string id, GameCenterDetailGameCenterLeaderboardSetsLinkagesRequest gameCenterDetailGameCenterLeaderboardSetsLinkagesRequest)



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
    public class GameCenterDetailsGameCenterLeaderboardSetsReplaceToManyRelationshipExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterDetailGameCenterLeaderboardSetsLinkagesRequest = new GameCenterDetailGameCenterLeaderboardSetsLinkagesRequest(); // GameCenterDetailGameCenterLeaderboardSetsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.GameCenterDetailsGameCenterLeaderboardSetsReplaceToManyRelationship(id, gameCenterDetailGameCenterLeaderboardSetsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardSetsReplaceToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterLeaderboardSetsReplaceToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterDetailsGameCenterLeaderboardSetsReplaceToManyRelationshipWithHttpInfo(id, gameCenterDetailGameCenterLeaderboardSetsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardSetsReplaceToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterDetailGameCenterLeaderboardSetsLinkagesRequest** | [**GameCenterDetailGameCenterLeaderboardSetsLinkagesRequest**](GameCenterDetailGameCenterLeaderboardSetsLinkagesRequest.md) | List of related linkages |  |

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

<a id="gamecenterdetailsgamecenterleaderboardsgettomanyrelated"></a>
# **GameCenterDetailsGameCenterLeaderboardsGetToManyRelated**
> GameCenterLeaderboardsResponse GameCenterDetailsGameCenterLeaderboardsGetToManyRelated (string id, List<string>? filterReferenceName = null, List<string>? filterArchived = null, List<string>? filterId = null, List<string>? fieldsGameCenterLeaderboards = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterLeaderboardSets = null, List<string>? fieldsGameCenterLeaderboardLocalizations = null, List<string>? fieldsGameCenterLeaderboardReleases = null, int? limit = null, List<string>? include = null, int? limitGameCenterLeaderboardSets = null, int? limitLocalizations = null, int? limitReleases = null)



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
    public class GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
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
                GameCenterLeaderboardsResponse result = apiInstance.GameCenterDetailsGameCenterLeaderboardsGetToManyRelated(id, filterReferenceName, filterArchived, filterId, fieldsGameCenterLeaderboards, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSets, fieldsGameCenterLeaderboardLocalizations, fieldsGameCenterLeaderboardReleases, limit, include, limitGameCenterLeaderboardSets, limitLocalizations, limitReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterLeaderboardsResponse> response = apiInstance.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedWithHttpInfo(id, filterReferenceName, filterArchived, filterId, fieldsGameCenterLeaderboards, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSets, fieldsGameCenterLeaderboardLocalizations, fieldsGameCenterLeaderboardReleases, limit, include, limitGameCenterLeaderboardSets, limitLocalizations, limitReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedWithHttpInfo: " + e.Message);
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

<a id="gamecenterdetailsgamecenterleaderboardsgettomanyrelationship"></a>
# **GameCenterDetailsGameCenterLeaderboardsGetToManyRelationship**
> GameCenterDetailGameCenterLeaderboardsLinkagesResponse GameCenterDetailsGameCenterLeaderboardsGetToManyRelationship (string id, int? limit = null)



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
    public class GameCenterDetailsGameCenterLeaderboardsGetToManyRelationshipExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                GameCenterDetailGameCenterLeaderboardsLinkagesResponse result = apiInstance.GameCenterDetailsGameCenterLeaderboardsGetToManyRelationship(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardsGetToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterLeaderboardsGetToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterDetailGameCenterLeaderboardsLinkagesResponse> response = apiInstance.GameCenterDetailsGameCenterLeaderboardsGetToManyRelationshipWithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardsGetToManyRelationshipWithHttpInfo: " + e.Message);
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

[**GameCenterDetailGameCenterLeaderboardsLinkagesResponse**](GameCenterDetailGameCenterLeaderboardsLinkagesResponse.md)

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

<a id="gamecenterdetailsgamecenterleaderboardsreplacetomanyrelationship"></a>
# **GameCenterDetailsGameCenterLeaderboardsReplaceToManyRelationship**
> void GameCenterDetailsGameCenterLeaderboardsReplaceToManyRelationship (string id, GameCenterDetailGameCenterLeaderboardsLinkagesRequest gameCenterDetailGameCenterLeaderboardsLinkagesRequest)



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
    public class GameCenterDetailsGameCenterLeaderboardsReplaceToManyRelationshipExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterDetailGameCenterLeaderboardsLinkagesRequest = new GameCenterDetailGameCenterLeaderboardsLinkagesRequest(); // GameCenterDetailGameCenterLeaderboardsLinkagesRequest | List of related linkages

            try
            {
                apiInstance.GameCenterDetailsGameCenterLeaderboardsReplaceToManyRelationship(id, gameCenterDetailGameCenterLeaderboardsLinkagesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardsReplaceToManyRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGameCenterLeaderboardsReplaceToManyRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GameCenterDetailsGameCenterLeaderboardsReplaceToManyRelationshipWithHttpInfo(id, gameCenterDetailGameCenterLeaderboardsLinkagesRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGameCenterLeaderboardsReplaceToManyRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterDetailGameCenterLeaderboardsLinkagesRequest** | [**GameCenterDetailGameCenterLeaderboardsLinkagesRequest**](GameCenterDetailGameCenterLeaderboardsLinkagesRequest.md) | List of related linkages |  |

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

<a id="gamecenterdetailsgetinstance"></a>
# **GameCenterDetailsGetInstance**
> GameCenterDetailResponse GameCenterDetailsGetInstance (string id, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterAppVersions = null, List<string>? fieldsGameCenterGroups = null, List<string>? fieldsGameCenterLeaderboards = null, List<string>? fieldsGameCenterLeaderboardSets = null, List<string>? fieldsGameCenterAchievements = null, List<string>? fieldsGameCenterAchievementReleases = null, List<string>? fieldsGameCenterLeaderboardReleases = null, List<string>? fieldsGameCenterLeaderboardSetReleases = null, List<string>? include = null, int? limitAchievementReleases = null, int? limitGameCenterAchievements = null, int? limitGameCenterAppVersions = null, int? limitGameCenterLeaderboardSets = null, int? limitGameCenterLeaderboards = null, int? limitLeaderboardReleases = null, int? limitLeaderboardSetReleases = null)



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
    public class GameCenterDetailsGetInstanceExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterAppVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAppVersions (optional) 
            var fieldsGameCenterGroups = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterGroups (optional) 
            var fieldsGameCenterLeaderboards = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboards (optional) 
            var fieldsGameCenterLeaderboardSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSets (optional) 
            var fieldsGameCenterAchievements = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievements (optional) 
            var fieldsGameCenterAchievementReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAchievementReleases (optional) 
            var fieldsGameCenterLeaderboardReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardReleases (optional) 
            var fieldsGameCenterLeaderboardSetReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSetReleases (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitAchievementReleases = 56;  // int? | maximum number of related achievementReleases returned (when they are included) (optional) 
            var limitGameCenterAchievements = 56;  // int? | maximum number of related gameCenterAchievements returned (when they are included) (optional) 
            var limitGameCenterAppVersions = 56;  // int? | maximum number of related gameCenterAppVersions returned (when they are included) (optional) 
            var limitGameCenterLeaderboardSets = 56;  // int? | maximum number of related gameCenterLeaderboardSets returned (when they are included) (optional) 
            var limitGameCenterLeaderboards = 56;  // int? | maximum number of related gameCenterLeaderboards returned (when they are included) (optional) 
            var limitLeaderboardReleases = 56;  // int? | maximum number of related leaderboardReleases returned (when they are included) (optional) 
            var limitLeaderboardSetReleases = 56;  // int? | maximum number of related leaderboardSetReleases returned (when they are included) (optional) 

            try
            {
                GameCenterDetailResponse result = apiInstance.GameCenterDetailsGetInstance(id, fieldsGameCenterDetails, fieldsGameCenterAppVersions, fieldsGameCenterGroups, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, fieldsGameCenterAchievementReleases, fieldsGameCenterLeaderboardReleases, fieldsGameCenterLeaderboardSetReleases, include, limitAchievementReleases, limitGameCenterAchievements, limitGameCenterAppVersions, limitGameCenterLeaderboardSets, limitGameCenterLeaderboards, limitLeaderboardReleases, limitLeaderboardSetReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterDetailResponse> response = apiInstance.GameCenterDetailsGetInstanceWithHttpInfo(id, fieldsGameCenterDetails, fieldsGameCenterAppVersions, fieldsGameCenterGroups, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSets, fieldsGameCenterAchievements, fieldsGameCenterAchievementReleases, fieldsGameCenterLeaderboardReleases, fieldsGameCenterLeaderboardSetReleases, include, limitAchievementReleases, limitGameCenterAchievements, limitGameCenterAppVersions, limitGameCenterLeaderboardSets, limitGameCenterLeaderboards, limitLeaderboardReleases, limitLeaderboardSetReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterAppVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAppVersions | [optional]  |
| **fieldsGameCenterGroups** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterGroups | [optional]  |
| **fieldsGameCenterLeaderboards** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboards | [optional]  |
| **fieldsGameCenterLeaderboardSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSets | [optional]  |
| **fieldsGameCenterAchievements** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievements | [optional]  |
| **fieldsGameCenterAchievementReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAchievementReleases | [optional]  |
| **fieldsGameCenterLeaderboardReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardReleases | [optional]  |
| **fieldsGameCenterLeaderboardSetReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSetReleases | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitAchievementReleases** | **int?** | maximum number of related achievementReleases returned (when they are included) | [optional]  |
| **limitGameCenterAchievements** | **int?** | maximum number of related gameCenterAchievements returned (when they are included) | [optional]  |
| **limitGameCenterAppVersions** | **int?** | maximum number of related gameCenterAppVersions returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboardSets** | **int?** | maximum number of related gameCenterLeaderboardSets returned (when they are included) | [optional]  |
| **limitGameCenterLeaderboards** | **int?** | maximum number of related gameCenterLeaderboards returned (when they are included) | [optional]  |
| **limitLeaderboardReleases** | **int?** | maximum number of related leaderboardReleases returned (when they are included) | [optional]  |
| **limitLeaderboardSetReleases** | **int?** | maximum number of related leaderboardSetReleases returned (when they are included) | [optional]  |

### Return type

[**GameCenterDetailResponse**](GameCenterDetailResponse.md)

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
| **200** | Single GameCenterDetail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterdetailsleaderboardreleasesgettomanyrelated"></a>
# **GameCenterDetailsLeaderboardReleasesGetToManyRelated**
> GameCenterLeaderboardReleasesResponse GameCenterDetailsLeaderboardReleasesGetToManyRelated (string id, List<string>? filterLive = null, List<string>? filterGameCenterLeaderboard = null, List<string>? fieldsGameCenterLeaderboardReleases = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterLeaderboards = null, int? limit = null, List<string>? include = null)



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
    public class GameCenterDetailsLeaderboardReleasesGetToManyRelatedExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterLive = new List<string>?(); // List<string>? | filter by attribute 'live' (optional) 
            var filterGameCenterLeaderboard = new List<string>?(); // List<string>? | filter by id(s) of related 'gameCenterLeaderboard' (optional) 
            var fieldsGameCenterLeaderboardReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardReleases (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterLeaderboards = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboards (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                GameCenterLeaderboardReleasesResponse result = apiInstance.GameCenterDetailsLeaderboardReleasesGetToManyRelated(id, filterLive, filterGameCenterLeaderboard, fieldsGameCenterLeaderboardReleases, fieldsGameCenterDetails, fieldsGameCenterLeaderboards, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsLeaderboardReleasesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsLeaderboardReleasesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterLeaderboardReleasesResponse> response = apiInstance.GameCenterDetailsLeaderboardReleasesGetToManyRelatedWithHttpInfo(id, filterLive, filterGameCenterLeaderboard, fieldsGameCenterLeaderboardReleases, fieldsGameCenterDetails, fieldsGameCenterLeaderboards, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsLeaderboardReleasesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterLive** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;live&#39; | [optional]  |
| **filterGameCenterLeaderboard** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;gameCenterLeaderboard&#39; | [optional]  |
| **fieldsGameCenterLeaderboardReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardReleases | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterLeaderboards** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboards | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**GameCenterLeaderboardReleasesResponse**](GameCenterLeaderboardReleasesResponse.md)

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
| **200** | List of GameCenterLeaderboardReleases |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterdetailsleaderboardsetreleasesgettomanyrelated"></a>
# **GameCenterDetailsLeaderboardSetReleasesGetToManyRelated**
> GameCenterLeaderboardSetReleasesResponse GameCenterDetailsLeaderboardSetReleasesGetToManyRelated (string id, List<string>? filterLive = null, List<string>? filterGameCenterLeaderboardSet = null, List<string>? fieldsGameCenterLeaderboardSetReleases = null, List<string>? fieldsGameCenterDetails = null, List<string>? fieldsGameCenterLeaderboardSets = null, int? limit = null, List<string>? include = null)



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
    public class GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterLive = new List<string>?(); // List<string>? | filter by attribute 'live' (optional) 
            var filterGameCenterLeaderboardSet = new List<string>?(); // List<string>? | filter by id(s) of related 'gameCenterLeaderboardSet' (optional) 
            var fieldsGameCenterLeaderboardSetReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSetReleases (optional) 
            var fieldsGameCenterDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterDetails (optional) 
            var fieldsGameCenterLeaderboardSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterLeaderboardSets (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                GameCenterLeaderboardSetReleasesResponse result = apiInstance.GameCenterDetailsLeaderboardSetReleasesGetToManyRelated(id, filterLive, filterGameCenterLeaderboardSet, fieldsGameCenterLeaderboardSetReleases, fieldsGameCenterDetails, fieldsGameCenterLeaderboardSets, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsLeaderboardSetReleasesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterLeaderboardSetReleasesResponse> response = apiInstance.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedWithHttpInfo(id, filterLive, filterGameCenterLeaderboardSet, fieldsGameCenterLeaderboardSetReleases, fieldsGameCenterDetails, fieldsGameCenterLeaderboardSets, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterLive** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;live&#39; | [optional]  |
| **filterGameCenterLeaderboardSet** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;gameCenterLeaderboardSet&#39; | [optional]  |
| **fieldsGameCenterLeaderboardSetReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSetReleases | [optional]  |
| **fieldsGameCenterDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterDetails | [optional]  |
| **fieldsGameCenterLeaderboardSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterLeaderboardSets | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**GameCenterLeaderboardSetReleasesResponse**](GameCenterLeaderboardSetReleasesResponse.md)

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
| **200** | List of GameCenterLeaderboardSetReleases |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterdetailsrulebasedmatchmakingrequestsgetmetrics"></a>
# **GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics**
> GameCenterMatchmakingAppRequestsV1MetricResponse GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics (string id, string granularity, List<string>? groupBy = null, string? filterResult = null, List<string>? sort = null, int? limit = null)



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
    public class GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterResult = "MATCHED";  // string? | filter by 'result' attribute dimension (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingAppRequestsV1MetricResponse result = apiInstance.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics(id, granularity, groupBy, filterResult, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingAppRequestsV1MetricResponse> response = apiInstance.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsWithHttpInfo(id, granularity, groupBy, filterResult, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **granularity** | **string** | the granularity of the per-group dataset |  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | the dimension by which to group the results | [optional]  |
| **filterResult** | **string?** | filter by &#39;result&#39; attribute dimension | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingAppRequestsV1MetricResponse**](GameCenterMatchmakingAppRequestsV1MetricResponse.md)

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
| **200** | Metrics data response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gamecenterdetailsupdateinstance"></a>
# **GameCenterDetailsUpdateInstance**
> GameCenterDetailResponse GameCenterDetailsUpdateInstance (string id, GameCenterDetailUpdateRequest gameCenterDetailUpdateRequest)



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
    public class GameCenterDetailsUpdateInstanceExample
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
            var apiInstance = new GameCenterDetailsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var gameCenterDetailUpdateRequest = new GameCenterDetailUpdateRequest(); // GameCenterDetailUpdateRequest | GameCenterDetail representation

            try
            {
                GameCenterDetailResponse result = apiInstance.GameCenterDetailsUpdateInstance(id, gameCenterDetailUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterDetailResponse> response = apiInstance.GameCenterDetailsUpdateInstanceWithHttpInfo(id, gameCenterDetailUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameCenterDetailsApi.GameCenterDetailsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **gameCenterDetailUpdateRequest** | [**GameCenterDetailUpdateRequest**](GameCenterDetailUpdateRequest.md) | GameCenterDetail representation |  |

### Return type

[**GameCenterDetailResponse**](GameCenterDetailResponse.md)

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
| **200** | Single GameCenterDetail |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

