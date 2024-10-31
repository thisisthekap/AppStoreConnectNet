# AppStoreConnect.Net.Api.MetricsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppsBetaTesterUsagesGetMetrics_0**](MetricsApi.md#appsbetatesterusagesgetmetrics_0) | **GET** /v1/apps/{id}/metrics/betaTesterUsages |  |
| [**BetaGroupsBetaTesterUsagesGetMetrics_0**](MetricsApi.md#betagroupsbetatesterusagesgetmetrics_0) | **GET** /v1/betaGroups/{id}/metrics/betaTesterUsages |  |
| [**BetaTestersBetaTesterUsagesGetMetrics_0**](MetricsApi.md#betatestersbetatesterusagesgetmetrics_0) | **GET** /v1/betaTesters/{id}/metrics/betaTesterUsages |  |
| [**BuildsBetaBuildUsagesGetMetrics_0**](MetricsApi.md#buildsbetabuildusagesgetmetrics_0) | **GET** /v1/builds/{id}/metrics/betaBuildUsages |  |
| [**GameCenterDetailsClassicMatchmakingRequestsGetMetrics_0**](MetricsApi.md#gamecenterdetailsclassicmatchmakingrequestsgetmetrics_0) | **GET** /v1/gameCenterDetails/{id}/metrics/classicMatchmakingRequests |  |
| [**GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics_0**](MetricsApi.md#gamecenterdetailsrulebasedmatchmakingrequestsgetmetrics_0) | **GET** /v1/gameCenterDetails/{id}/metrics/ruleBasedMatchmakingRequests |  |
| [**GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetrics_0**](MetricsApi.md#gamecentermatchmakingqueuesexperimentmatchmakingqueuesizesgetmetrics_0) | **GET** /v1/gameCenterMatchmakingQueues/{id}/metrics/experimentMatchmakingQueueSizes |  |
| [**GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetrics_0**](MetricsApi.md#gamecentermatchmakingqueuesexperimentmatchmakingrequestsgetmetrics_0) | **GET** /v1/gameCenterMatchmakingQueues/{id}/metrics/experimentMatchmakingRequests |  |
| [**GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetrics_0**](MetricsApi.md#gamecentermatchmakingqueuesmatchmakingqueuesizesgetmetrics_0) | **GET** /v1/gameCenterMatchmakingQueues/{id}/metrics/matchmakingQueueSizes |  |
| [**GameCenterMatchmakingQueuesMatchmakingRequestsGetMetrics_0**](MetricsApi.md#gamecentermatchmakingqueuesmatchmakingrequestsgetmetrics_0) | **GET** /v1/gameCenterMatchmakingQueues/{id}/metrics/matchmakingRequests |  |
| [**GameCenterMatchmakingQueuesMatchmakingSessionsGetMetrics_0**](MetricsApi.md#gamecentermatchmakingqueuesmatchmakingsessionsgetmetrics_0) | **GET** /v1/gameCenterMatchmakingQueues/{id}/metrics/matchmakingSessions |  |
| [**GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetrics_0**](MetricsApi.md#gamecentermatchmakingrulesmatchmakingbooleanruleresultsgetmetrics_0) | **GET** /v1/gameCenterMatchmakingRules/{id}/metrics/matchmakingBooleanRuleResults |  |
| [**GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetrics_0**](MetricsApi.md#gamecentermatchmakingrulesmatchmakingnumberruleresultsgetmetrics_0) | **GET** /v1/gameCenterMatchmakingRules/{id}/metrics/matchmakingNumberRuleResults |  |
| [**GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetrics_0**](MetricsApi.md#gamecentermatchmakingrulesmatchmakingruleerrorsgetmetrics_0) | **GET** /v1/gameCenterMatchmakingRules/{id}/metrics/matchmakingRuleErrors |  |

<a id="appsbetatesterusagesgetmetrics_0"></a>
# **AppsBetaTesterUsagesGetMetrics_0**
> AppsBetaTesterUsagesV1MetricResponse AppsBetaTesterUsagesGetMetrics_0 (string id, string? period = null, List<string>? groupBy = null, string? filterBetaTesters = null, int? limit = null)



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
    public class AppsBetaTesterUsagesGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var period = P7D;  // string? | the duration of the reporting period (optional) 
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterBetaTesters = "filterBetaTesters_example";  // string? | filter by 'betaTesters' relationship dimension (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                AppsBetaTesterUsagesV1MetricResponse result = apiInstance.AppsBetaTesterUsagesGetMetrics_0(id, period, groupBy, filterBetaTesters, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.AppsBetaTesterUsagesGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppsBetaTesterUsagesGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppsBetaTesterUsagesV1MetricResponse> response = apiInstance.AppsBetaTesterUsagesGetMetrics_0WithHttpInfo(id, period, groupBy, filterBetaTesters, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.AppsBetaTesterUsagesGetMetrics_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **period** | **string?** | the duration of the reporting period | [optional]  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | the dimension by which to group the results | [optional]  |
| **filterBetaTesters** | **string?** | filter by &#39;betaTesters&#39; relationship dimension | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**AppsBetaTesterUsagesV1MetricResponse**](AppsBetaTesterUsagesV1MetricResponse.md)

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

<a id="betagroupsbetatesterusagesgetmetrics_0"></a>
# **BetaGroupsBetaTesterUsagesGetMetrics_0**
> AppsBetaTesterUsagesV1MetricResponse BetaGroupsBetaTesterUsagesGetMetrics_0 (string id, string? period = null, List<string>? groupBy = null, string? filterBetaTesters = null, int? limit = null)



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
    public class BetaGroupsBetaTesterUsagesGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var period = P7D;  // string? | the duration of the reporting period (optional) 
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterBetaTesters = "filterBetaTesters_example";  // string? | filter by 'betaTesters' relationship dimension (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                AppsBetaTesterUsagesV1MetricResponse result = apiInstance.BetaGroupsBetaTesterUsagesGetMetrics_0(id, period, groupBy, filterBetaTesters, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.BetaGroupsBetaTesterUsagesGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaGroupsBetaTesterUsagesGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppsBetaTesterUsagesV1MetricResponse> response = apiInstance.BetaGroupsBetaTesterUsagesGetMetrics_0WithHttpInfo(id, period, groupBy, filterBetaTesters, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.BetaGroupsBetaTesterUsagesGetMetrics_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **period** | **string?** | the duration of the reporting period | [optional]  |
| **groupBy** | [**List&lt;string&gt;?**](string.md) | the dimension by which to group the results | [optional]  |
| **filterBetaTesters** | **string?** | filter by &#39;betaTesters&#39; relationship dimension | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**AppsBetaTesterUsagesV1MetricResponse**](AppsBetaTesterUsagesV1MetricResponse.md)

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

<a id="betatestersbetatesterusagesgetmetrics_0"></a>
# **BetaTestersBetaTesterUsagesGetMetrics_0**
> BetaTesterUsagesV1MetricResponse BetaTestersBetaTesterUsagesGetMetrics_0 (string id, string filterApps, string? period = null, int? limit = null)



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
    public class BetaTestersBetaTesterUsagesGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterApps = "filterApps_example";  // string | filter by 'apps' relationship dimension
            var period = P7D;  // string? | the duration of the reporting period (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                BetaTesterUsagesV1MetricResponse result = apiInstance.BetaTestersBetaTesterUsagesGetMetrics_0(id, filterApps, period, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.BetaTestersBetaTesterUsagesGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BetaTestersBetaTesterUsagesGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaTesterUsagesV1MetricResponse> response = apiInstance.BetaTestersBetaTesterUsagesGetMetrics_0WithHttpInfo(id, filterApps, period, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.BetaTestersBetaTesterUsagesGetMetrics_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterApps** | **string** | filter by &#39;apps&#39; relationship dimension |  |
| **period** | **string?** | the duration of the reporting period | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**BetaTesterUsagesV1MetricResponse**](BetaTesterUsagesV1MetricResponse.md)

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

<a id="buildsbetabuildusagesgetmetrics_0"></a>
# **BuildsBetaBuildUsagesGetMetrics_0**
> BetaBuildUsagesV1MetricResponse BuildsBetaBuildUsagesGetMetrics_0 (string id, int? limit = null)



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
    public class BuildsBetaBuildUsagesGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                BetaBuildUsagesV1MetricResponse result = apiInstance.BuildsBetaBuildUsagesGetMetrics_0(id, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.BuildsBetaBuildUsagesGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildsBetaBuildUsagesGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BetaBuildUsagesV1MetricResponse> response = apiInstance.BuildsBetaBuildUsagesGetMetrics_0WithHttpInfo(id, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.BuildsBetaBuildUsagesGetMetrics_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**BetaBuildUsagesV1MetricResponse**](BetaBuildUsagesV1MetricResponse.md)

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

<a id="gamecenterdetailsclassicmatchmakingrequestsgetmetrics_0"></a>
# **GameCenterDetailsClassicMatchmakingRequestsGetMetrics_0**
> GameCenterMatchmakingAppRequestsV1MetricResponse GameCenterDetailsClassicMatchmakingRequestsGetMetrics_0 (string id, string granularity, List<string>? groupBy = null, string? filterResult = null, List<string>? sort = null, int? limit = null)



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
    public class GameCenterDetailsClassicMatchmakingRequestsGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterResult = "MATCHED";  // string? | filter by 'result' attribute dimension (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingAppRequestsV1MetricResponse result = apiInstance.GameCenterDetailsClassicMatchmakingRequestsGetMetrics_0(id, granularity, groupBy, filterResult, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterDetailsClassicMatchmakingRequestsGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsClassicMatchmakingRequestsGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingAppRequestsV1MetricResponse> response = apiInstance.GameCenterDetailsClassicMatchmakingRequestsGetMetrics_0WithHttpInfo(id, granularity, groupBy, filterResult, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterDetailsClassicMatchmakingRequestsGetMetrics_0WithHttpInfo: " + e.Message);
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

<a id="gamecenterdetailsrulebasedmatchmakingrequestsgetmetrics_0"></a>
# **GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics_0**
> GameCenterMatchmakingAppRequestsV1MetricResponse GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics_0 (string id, string granularity, List<string>? groupBy = null, string? filterResult = null, List<string>? sort = null, int? limit = null)



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
    public class GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterResult = "MATCHED";  // string? | filter by 'result' attribute dimension (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingAppRequestsV1MetricResponse result = apiInstance.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics_0(id, granularity, groupBy, filterResult, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingAppRequestsV1MetricResponse> response = apiInstance.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics_0WithHttpInfo(id, granularity, groupBy, filterResult, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterDetailsRuleBasedMatchmakingRequestsGetMetrics_0WithHttpInfo: " + e.Message);
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

<a id="gamecentermatchmakingqueuesexperimentmatchmakingqueuesizesgetmetrics_0"></a>
# **GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetrics_0**
> GameCenterMatchmakingQueueSizesV1MetricResponse GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetrics_0 (string id, string granularity, List<string>? sort = null, int? limit = null)



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
    public class GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingQueueSizesV1MetricResponse result = apiInstance.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetrics_0(id, granularity, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingQueueSizesV1MetricResponse> response = apiInstance.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetrics_0WithHttpInfo(id, granularity, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetrics_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **granularity** | **string** | the granularity of the per-group dataset |  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingQueueSizesV1MetricResponse**](GameCenterMatchmakingQueueSizesV1MetricResponse.md)

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

<a id="gamecentermatchmakingqueuesexperimentmatchmakingrequestsgetmetrics_0"></a>
# **GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetrics_0**
> GameCenterMatchmakingQueueRequestsV1MetricResponse GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetrics_0 (string id, string granularity, List<string>? groupBy = null, string? filterResult = null, string? filterGameCenterDetail = null, List<string>? sort = null, int? limit = null)



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
    public class GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterResult = "MATCHED";  // string? | filter by 'result' attribute dimension (optional) 
            var filterGameCenterDetail = "filterGameCenterDetail_example";  // string? | filter by 'gameCenterDetail' relationship dimension (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingQueueRequestsV1MetricResponse result = apiInstance.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetrics_0(id, granularity, groupBy, filterResult, filterGameCenterDetail, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingQueueRequestsV1MetricResponse> response = apiInstance.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetrics_0WithHttpInfo(id, granularity, groupBy, filterResult, filterGameCenterDetail, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetrics_0WithHttpInfo: " + e.Message);
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
| **filterGameCenterDetail** | **string?** | filter by &#39;gameCenterDetail&#39; relationship dimension | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingQueueRequestsV1MetricResponse**](GameCenterMatchmakingQueueRequestsV1MetricResponse.md)

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

<a id="gamecentermatchmakingqueuesmatchmakingqueuesizesgetmetrics_0"></a>
# **GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetrics_0**
> GameCenterMatchmakingQueueSizesV1MetricResponse GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetrics_0 (string id, string granularity, List<string>? sort = null, int? limit = null)



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
    public class GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingQueueSizesV1MetricResponse result = apiInstance.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetrics_0(id, granularity, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingQueueSizesV1MetricResponse> response = apiInstance.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetrics_0WithHttpInfo(id, granularity, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetrics_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **granularity** | **string** | the granularity of the per-group dataset |  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingQueueSizesV1MetricResponse**](GameCenterMatchmakingQueueSizesV1MetricResponse.md)

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

<a id="gamecentermatchmakingqueuesmatchmakingrequestsgetmetrics_0"></a>
# **GameCenterMatchmakingQueuesMatchmakingRequestsGetMetrics_0**
> GameCenterMatchmakingQueueRequestsV1MetricResponse GameCenterMatchmakingQueuesMatchmakingRequestsGetMetrics_0 (string id, string granularity, List<string>? groupBy = null, string? filterResult = null, string? filterGameCenterDetail = null, List<string>? sort = null, int? limit = null)



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
    public class GameCenterMatchmakingQueuesMatchmakingRequestsGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterResult = "MATCHED";  // string? | filter by 'result' attribute dimension (optional) 
            var filterGameCenterDetail = "filterGameCenterDetail_example";  // string? | filter by 'gameCenterDetail' relationship dimension (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingQueueRequestsV1MetricResponse result = apiInstance.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetrics_0(id, granularity, groupBy, filterResult, filterGameCenterDetail, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterMatchmakingQueuesMatchmakingRequestsGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingQueueRequestsV1MetricResponse> response = apiInstance.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetrics_0WithHttpInfo(id, granularity, groupBy, filterResult, filterGameCenterDetail, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetrics_0WithHttpInfo: " + e.Message);
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
| **filterGameCenterDetail** | **string?** | filter by &#39;gameCenterDetail&#39; relationship dimension | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingQueueRequestsV1MetricResponse**](GameCenterMatchmakingQueueRequestsV1MetricResponse.md)

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

<a id="gamecentermatchmakingqueuesmatchmakingsessionsgetmetrics_0"></a>
# **GameCenterMatchmakingQueuesMatchmakingSessionsGetMetrics_0**
> GameCenterMatchmakingSessionsV1MetricResponse GameCenterMatchmakingQueuesMatchmakingSessionsGetMetrics_0 (string id, string granularity, List<string>? sort = null, int? limit = null)



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
    public class GameCenterMatchmakingQueuesMatchmakingSessionsGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingSessionsV1MetricResponse result = apiInstance.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetrics_0(id, granularity, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterMatchmakingQueuesMatchmakingSessionsGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingSessionsV1MetricResponse> response = apiInstance.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetrics_0WithHttpInfo(id, granularity, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetrics_0WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **granularity** | **string** | the granularity of the per-group dataset |  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingSessionsV1MetricResponse**](GameCenterMatchmakingSessionsV1MetricResponse.md)

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

<a id="gamecentermatchmakingrulesmatchmakingbooleanruleresultsgetmetrics_0"></a>
# **GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetrics_0**
> GameCenterMatchmakingBooleanRuleResultsV1MetricResponse GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetrics_0 (string id, string granularity, List<string>? groupBy = null, string? filterResult = null, string? filterGameCenterMatchmakingQueue = null, List<string>? sort = null, int? limit = null)



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
    public class GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterResult = "filterResult_example";  // string? | filter by 'result' attribute dimension (optional) 
            var filterGameCenterMatchmakingQueue = "filterGameCenterMatchmakingQueue_example";  // string? | filter by 'gameCenterMatchmakingQueue' relationship dimension (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingBooleanRuleResultsV1MetricResponse result = apiInstance.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetrics_0(id, granularity, groupBy, filterResult, filterGameCenterMatchmakingQueue, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingBooleanRuleResultsV1MetricResponse> response = apiInstance.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetrics_0WithHttpInfo(id, granularity, groupBy, filterResult, filterGameCenterMatchmakingQueue, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetrics_0WithHttpInfo: " + e.Message);
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
| **filterGameCenterMatchmakingQueue** | **string?** | filter by &#39;gameCenterMatchmakingQueue&#39; relationship dimension | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingBooleanRuleResultsV1MetricResponse**](GameCenterMatchmakingBooleanRuleResultsV1MetricResponse.md)

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

<a id="gamecentermatchmakingrulesmatchmakingnumberruleresultsgetmetrics_0"></a>
# **GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetrics_0**
> GameCenterMatchmakingNumberRuleResultsV1MetricResponse GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetrics_0 (string id, string granularity, List<string>? groupBy = null, string? filterGameCenterMatchmakingQueue = null, List<string>? sort = null, int? limit = null)



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
    public class GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterGameCenterMatchmakingQueue = "filterGameCenterMatchmakingQueue_example";  // string? | filter by 'gameCenterMatchmakingQueue' relationship dimension (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingNumberRuleResultsV1MetricResponse result = apiInstance.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetrics_0(id, granularity, groupBy, filterGameCenterMatchmakingQueue, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingNumberRuleResultsV1MetricResponse> response = apiInstance.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetrics_0WithHttpInfo(id, granularity, groupBy, filterGameCenterMatchmakingQueue, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetrics_0WithHttpInfo: " + e.Message);
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
| **filterGameCenterMatchmakingQueue** | **string?** | filter by &#39;gameCenterMatchmakingQueue&#39; relationship dimension | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingNumberRuleResultsV1MetricResponse**](GameCenterMatchmakingNumberRuleResultsV1MetricResponse.md)

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

<a id="gamecentermatchmakingrulesmatchmakingruleerrorsgetmetrics_0"></a>
# **GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetrics_0**
> GameCenterMatchmakingRuleErrorsV1MetricResponse GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetrics_0 (string id, string granularity, List<string>? groupBy = null, string? filterGameCenterMatchmakingQueue = null, List<string>? sort = null, int? limit = null)



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
    public class GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetrics_0Example
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
            var apiInstance = new MetricsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var granularity = P7D;  // string | the granularity of the per-group dataset
            var groupBy = new List<string>?(); // List<string>? | the dimension by which to group the results (optional) 
            var filterGameCenterMatchmakingQueue = "filterGameCenterMatchmakingQueue_example";  // string? | filter by 'gameCenterMatchmakingQueue' relationship dimension (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; metrics will be sorted as specified (optional) 
            var limit = 56;  // int? | maximum number of groups to return per page (optional) 

            try
            {
                GameCenterMatchmakingRuleErrorsV1MetricResponse result = apiInstance.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetrics_0(id, granularity, groupBy, filterGameCenterMatchmakingQueue, sort, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetrics_0: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetrics_0WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterMatchmakingRuleErrorsV1MetricResponse> response = apiInstance.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetrics_0WithHttpInfo(id, granularity, groupBy, filterGameCenterMatchmakingQueue, sort, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetricsApi.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetrics_0WithHttpInfo: " + e.Message);
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
| **filterGameCenterMatchmakingQueue** | **string?** | filter by &#39;gameCenterMatchmakingQueue&#39; relationship dimension | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; metrics will be sorted as specified | [optional]  |
| **limit** | **int?** | maximum number of groups to return per page | [optional]  |

### Return type

[**GameCenterMatchmakingRuleErrorsV1MetricResponse**](GameCenterMatchmakingRuleErrorsV1MetricResponse.md)

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

