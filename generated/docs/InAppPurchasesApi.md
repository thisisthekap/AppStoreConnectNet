# AppStoreConnect.Net.Api.InAppPurchasesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InAppPurchasesGetInstance**](InAppPurchasesApi.md#inapppurchasesgetinstance) | **GET** /v1/inAppPurchases/{id} |  |
| [**InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelated**](InAppPurchasesApi.md#inapppurchasesv2appstorereviewscreenshotgettoonerelated) | **GET** /v2/inAppPurchases/{id}/appStoreReviewScreenshot |  |
| [**InAppPurchasesV2ContentGetToOneRelated**](InAppPurchasesApi.md#inapppurchasesv2contentgettoonerelated) | **GET** /v2/inAppPurchases/{id}/content |  |
| [**InAppPurchasesV2CreateInstance**](InAppPurchasesApi.md#inapppurchasesv2createinstance) | **POST** /v2/inAppPurchases |  |
| [**InAppPurchasesV2DeleteInstance**](InAppPurchasesApi.md#inapppurchasesv2deleteinstance) | **DELETE** /v2/inAppPurchases/{id} |  |
| [**InAppPurchasesV2GetInstance**](InAppPurchasesApi.md#inapppurchasesv2getinstance) | **GET** /v2/inAppPurchases/{id} |  |
| [**InAppPurchasesV2IapPriceScheduleGetToOneRelated**](InAppPurchasesApi.md#inapppurchasesv2iappriceschedulegettoonerelated) | **GET** /v2/inAppPurchases/{id}/iapPriceSchedule |  |
| [**InAppPurchasesV2ImagesGetToManyRelated**](InAppPurchasesApi.md#inapppurchasesv2imagesgettomanyrelated) | **GET** /v2/inAppPurchases/{id}/images |  |
| [**InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelated**](InAppPurchasesApi.md#inapppurchasesv2inapppurchaseavailabilitygettoonerelated) | **GET** /v2/inAppPurchases/{id}/inAppPurchaseAvailability |  |
| [**InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelated**](InAppPurchasesApi.md#inapppurchasesv2inapppurchaselocalizationsgettomanyrelated) | **GET** /v2/inAppPurchases/{id}/inAppPurchaseLocalizations |  |
| [**InAppPurchasesV2PricePointsGetToManyRelated**](InAppPurchasesApi.md#inapppurchasesv2pricepointsgettomanyrelated) | **GET** /v2/inAppPurchases/{id}/pricePoints |  |
| [**InAppPurchasesV2PromotedPurchaseGetToOneRelated**](InAppPurchasesApi.md#inapppurchasesv2promotedpurchasegettoonerelated) | **GET** /v2/inAppPurchases/{id}/promotedPurchase |  |
| [**InAppPurchasesV2UpdateInstance**](InAppPurchasesApi.md#inapppurchasesv2updateinstance) | **PATCH** /v2/inAppPurchases/{id} |  |

<a id="inapppurchasesgetinstance"></a>
# **InAppPurchasesGetInstance**
> InAppPurchaseResponse InAppPurchasesGetInstance (string id, List<string>? fieldsInAppPurchases = null, List<string>? include = null, int? limitApps = null)



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
    public class InAppPurchasesGetInstanceExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitApps = 56;  // int? | maximum number of related apps returned (when they are included) (optional) 

            try
            {
                InAppPurchaseResponse result = apiInstance.InAppPurchasesGetInstance(id, fieldsInAppPurchases, include, limitApps);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseResponse> response = apiInstance.InAppPurchasesGetInstanceWithHttpInfo(id, fieldsInAppPurchases, include, limitApps);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitApps** | **int?** | maximum number of related apps returned (when they are included) | [optional]  |

### Return type

[**InAppPurchaseResponse**](InAppPurchaseResponse.md)

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
| **200** | Single InAppPurchase |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2appstorereviewscreenshotgettoonerelated"></a>
# **InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelated**
> InAppPurchaseAppStoreReviewScreenshotResponse InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelated (string id, List<string>? fieldsInAppPurchaseAppStoreReviewScreenshots = null, List<string>? fieldsInAppPurchases = null, List<string>? include = null)



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
    public class InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchaseAppStoreReviewScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseAppStoreReviewScreenshots (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchaseAppStoreReviewScreenshotResponse result = apiInstance.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelated(id, fieldsInAppPurchaseAppStoreReviewScreenshots, fieldsInAppPurchases, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseAppStoreReviewScreenshotResponse> response = apiInstance.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedWithHttpInfo(id, fieldsInAppPurchaseAppStoreReviewScreenshots, fieldsInAppPurchases, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchaseAppStoreReviewScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseAppStoreReviewScreenshots | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchaseAppStoreReviewScreenshotResponse**](InAppPurchaseAppStoreReviewScreenshotResponse.md)

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
| **200** | Single InAppPurchaseAppStoreReviewScreenshot |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2contentgettoonerelated"></a>
# **InAppPurchasesV2ContentGetToOneRelated**
> InAppPurchaseContentResponse InAppPurchasesV2ContentGetToOneRelated (string id, List<string>? fieldsInAppPurchaseContents = null, List<string>? fieldsInAppPurchases = null, List<string>? include = null)



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
    public class InAppPurchasesV2ContentGetToOneRelatedExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchaseContents = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseContents (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchaseContentResponse result = apiInstance.InAppPurchasesV2ContentGetToOneRelated(id, fieldsInAppPurchaseContents, fieldsInAppPurchases, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2ContentGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2ContentGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseContentResponse> response = apiInstance.InAppPurchasesV2ContentGetToOneRelatedWithHttpInfo(id, fieldsInAppPurchaseContents, fieldsInAppPurchases, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2ContentGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchaseContents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseContents | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchaseContentResponse**](InAppPurchaseContentResponse.md)

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
| **200** | Single InAppPurchaseContent |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2createinstance"></a>
# **InAppPurchasesV2CreateInstance**
> InAppPurchaseV2Response InAppPurchasesV2CreateInstance (InAppPurchaseV2CreateRequest inAppPurchaseV2CreateRequest)



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
    public class InAppPurchasesV2CreateInstanceExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var inAppPurchaseV2CreateRequest = new InAppPurchaseV2CreateRequest(); // InAppPurchaseV2CreateRequest | InAppPurchase representation

            try
            {
                InAppPurchaseV2Response result = apiInstance.InAppPurchasesV2CreateInstance(inAppPurchaseV2CreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2CreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2CreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseV2Response> response = apiInstance.InAppPurchasesV2CreateInstanceWithHttpInfo(inAppPurchaseV2CreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2CreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inAppPurchaseV2CreateRequest** | [**InAppPurchaseV2CreateRequest**](InAppPurchaseV2CreateRequest.md) | InAppPurchase representation |  |

### Return type

[**InAppPurchaseV2Response**](InAppPurchaseV2Response.md)

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
| **201** | Single InAppPurchase |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2deleteinstance"></a>
# **InAppPurchasesV2DeleteInstance**
> void InAppPurchasesV2DeleteInstance (string id)



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
    public class InAppPurchasesV2DeleteInstanceExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.InAppPurchasesV2DeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2DeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2DeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.InAppPurchasesV2DeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2DeleteInstanceWithHttpInfo: " + e.Message);
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

<a id="inapppurchasesv2getinstance"></a>
# **InAppPurchasesV2GetInstance**
> InAppPurchaseV2Response InAppPurchasesV2GetInstance (string id, List<string>? fieldsInAppPurchases = null, List<string>? fieldsInAppPurchaseLocalizations = null, List<string>? fieldsInAppPurchasePricePoints = null, List<string>? fieldsInAppPurchaseContents = null, List<string>? fieldsInAppPurchaseAppStoreReviewScreenshots = null, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsInAppPurchasePriceSchedules = null, List<string>? fieldsInAppPurchaseAvailabilities = null, List<string>? fieldsInAppPurchaseImages = null, List<string>? include = null, int? limitImages = null, int? limitInAppPurchaseLocalizations = null, int? limitPricePoints = null)



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
    public class InAppPurchasesV2GetInstanceExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsInAppPurchaseLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseLocalizations (optional) 
            var fieldsInAppPurchasePricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePricePoints (optional) 
            var fieldsInAppPurchaseContents = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseContents (optional) 
            var fieldsInAppPurchaseAppStoreReviewScreenshots = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseAppStoreReviewScreenshots (optional) 
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsInAppPurchasePriceSchedules = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePriceSchedules (optional) 
            var fieldsInAppPurchaseAvailabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseAvailabilities (optional) 
            var fieldsInAppPurchaseImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseImages (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitImages = 56;  // int? | maximum number of related images returned (when they are included) (optional) 
            var limitInAppPurchaseLocalizations = 56;  // int? | maximum number of related inAppPurchaseLocalizations returned (when they are included) (optional) 
            var limitPricePoints = 56;  // int? | maximum number of related pricePoints returned (when they are included) (optional) 

            try
            {
                InAppPurchaseV2Response result = apiInstance.InAppPurchasesV2GetInstance(id, fieldsInAppPurchases, fieldsInAppPurchaseLocalizations, fieldsInAppPurchasePricePoints, fieldsInAppPurchaseContents, fieldsInAppPurchaseAppStoreReviewScreenshots, fieldsPromotedPurchases, fieldsInAppPurchasePriceSchedules, fieldsInAppPurchaseAvailabilities, fieldsInAppPurchaseImages, include, limitImages, limitInAppPurchaseLocalizations, limitPricePoints);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2GetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2GetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseV2Response> response = apiInstance.InAppPurchasesV2GetInstanceWithHttpInfo(id, fieldsInAppPurchases, fieldsInAppPurchaseLocalizations, fieldsInAppPurchasePricePoints, fieldsInAppPurchaseContents, fieldsInAppPurchaseAppStoreReviewScreenshots, fieldsPromotedPurchases, fieldsInAppPurchasePriceSchedules, fieldsInAppPurchaseAvailabilities, fieldsInAppPurchaseImages, include, limitImages, limitInAppPurchaseLocalizations, limitPricePoints);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2GetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsInAppPurchaseLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseLocalizations | [optional]  |
| **fieldsInAppPurchasePricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePricePoints | [optional]  |
| **fieldsInAppPurchaseContents** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseContents | [optional]  |
| **fieldsInAppPurchaseAppStoreReviewScreenshots** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseAppStoreReviewScreenshots | [optional]  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsInAppPurchasePriceSchedules** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePriceSchedules | [optional]  |
| **fieldsInAppPurchaseAvailabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseAvailabilities | [optional]  |
| **fieldsInAppPurchaseImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseImages | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitImages** | **int?** | maximum number of related images returned (when they are included) | [optional]  |
| **limitInAppPurchaseLocalizations** | **int?** | maximum number of related inAppPurchaseLocalizations returned (when they are included) | [optional]  |
| **limitPricePoints** | **int?** | maximum number of related pricePoints returned (when they are included) | [optional]  |

### Return type

[**InAppPurchaseV2Response**](InAppPurchaseV2Response.md)

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
| **200** | Single InAppPurchase |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2iappriceschedulegettoonerelated"></a>
# **InAppPurchasesV2IapPriceScheduleGetToOneRelated**
> InAppPurchasePriceScheduleResponse InAppPurchasesV2IapPriceScheduleGetToOneRelated (string id, List<string>? fieldsInAppPurchasePriceSchedules = null, List<string>? fieldsInAppPurchases = null, List<string>? fieldsTerritories = null, List<string>? fieldsInAppPurchasePrices = null, List<string>? include = null, int? limitManualPrices = null, int? limitAutomaticPrices = null)



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
    public class InAppPurchasesV2IapPriceScheduleGetToOneRelatedExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchasePriceSchedules = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePriceSchedules (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var fieldsInAppPurchasePrices = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePrices (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitManualPrices = 56;  // int? | maximum number of related manualPrices returned (when they are included) (optional) 
            var limitAutomaticPrices = 56;  // int? | maximum number of related automaticPrices returned (when they are included) (optional) 

            try
            {
                InAppPurchasePriceScheduleResponse result = apiInstance.InAppPurchasesV2IapPriceScheduleGetToOneRelated(id, fieldsInAppPurchasePriceSchedules, fieldsInAppPurchases, fieldsTerritories, fieldsInAppPurchasePrices, include, limitManualPrices, limitAutomaticPrices);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2IapPriceScheduleGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2IapPriceScheduleGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchasePriceScheduleResponse> response = apiInstance.InAppPurchasesV2IapPriceScheduleGetToOneRelatedWithHttpInfo(id, fieldsInAppPurchasePriceSchedules, fieldsInAppPurchases, fieldsTerritories, fieldsInAppPurchasePrices, include, limitManualPrices, limitAutomaticPrices);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2IapPriceScheduleGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchasePriceSchedules** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePriceSchedules | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **fieldsInAppPurchasePrices** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePrices | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitManualPrices** | **int?** | maximum number of related manualPrices returned (when they are included) | [optional]  |
| **limitAutomaticPrices** | **int?** | maximum number of related automaticPrices returned (when they are included) | [optional]  |

### Return type

[**InAppPurchasePriceScheduleResponse**](InAppPurchasePriceScheduleResponse.md)

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
| **200** | Single InAppPurchasePriceSchedule |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2imagesgettomanyrelated"></a>
# **InAppPurchasesV2ImagesGetToManyRelated**
> InAppPurchaseImagesResponse InAppPurchasesV2ImagesGetToManyRelated (string id, List<string>? fieldsInAppPurchaseImages = null, List<string>? fieldsInAppPurchases = null, int? limit = null, List<string>? include = null)



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
    public class InAppPurchasesV2ImagesGetToManyRelatedExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchaseImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseImages (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchaseImagesResponse result = apiInstance.InAppPurchasesV2ImagesGetToManyRelated(id, fieldsInAppPurchaseImages, fieldsInAppPurchases, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2ImagesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2ImagesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseImagesResponse> response = apiInstance.InAppPurchasesV2ImagesGetToManyRelatedWithHttpInfo(id, fieldsInAppPurchaseImages, fieldsInAppPurchases, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2ImagesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchaseImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseImages | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchaseImagesResponse**](InAppPurchaseImagesResponse.md)

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
| **200** | List of InAppPurchaseImages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2inapppurchaseavailabilitygettoonerelated"></a>
# **InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelated**
> InAppPurchaseAvailabilityResponse InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelated (string id, List<string>? fieldsInAppPurchaseAvailabilities = null, List<string>? fieldsTerritories = null, List<string>? include = null, int? limitAvailableTerritories = null)



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
    public class InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchaseAvailabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseAvailabilities (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitAvailableTerritories = 56;  // int? | maximum number of related availableTerritories returned (when they are included) (optional) 

            try
            {
                InAppPurchaseAvailabilityResponse result = apiInstance.InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelated(id, fieldsInAppPurchaseAvailabilities, fieldsTerritories, include, limitAvailableTerritories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseAvailabilityResponse> response = apiInstance.InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedWithHttpInfo(id, fieldsInAppPurchaseAvailabilities, fieldsTerritories, include, limitAvailableTerritories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2InAppPurchaseAvailabilityGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchaseAvailabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseAvailabilities | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitAvailableTerritories** | **int?** | maximum number of related availableTerritories returned (when they are included) | [optional]  |

### Return type

[**InAppPurchaseAvailabilityResponse**](InAppPurchaseAvailabilityResponse.md)

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
| **200** | Single InAppPurchaseAvailability |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2inapppurchaselocalizationsgettomanyrelated"></a>
# **InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelated**
> InAppPurchaseLocalizationsResponse InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelated (string id, List<string>? fieldsInAppPurchaseLocalizations = null, List<string>? fieldsInAppPurchases = null, int? limit = null, List<string>? include = null)



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
    public class InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsInAppPurchaseLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchaseLocalizations (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchaseLocalizationsResponse result = apiInstance.InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelated(id, fieldsInAppPurchaseLocalizations, fieldsInAppPurchases, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseLocalizationsResponse> response = apiInstance.InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedWithHttpInfo(id, fieldsInAppPurchaseLocalizations, fieldsInAppPurchases, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsInAppPurchaseLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchaseLocalizations | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchaseLocalizationsResponse**](InAppPurchaseLocalizationsResponse.md)

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
| **200** | List of InAppPurchaseLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2pricepointsgettomanyrelated"></a>
# **InAppPurchasesV2PricePointsGetToManyRelated**
> InAppPurchasePricePointsResponse InAppPurchasesV2PricePointsGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? fieldsInAppPurchasePricePoints = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class InAppPurchasesV2PricePointsGetToManyRelatedExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by id(s) of related 'territory' (optional) 
            var fieldsInAppPurchasePricePoints = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchasePricePoints (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                InAppPurchasePricePointsResponse result = apiInstance.InAppPurchasesV2PricePointsGetToManyRelated(id, filterTerritory, fieldsInAppPurchasePricePoints, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2PricePointsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2PricePointsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchasePricePointsResponse> response = apiInstance.InAppPurchasesV2PricePointsGetToManyRelatedWithHttpInfo(id, filterTerritory, fieldsInAppPurchasePricePoints, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2PricePointsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by id(s) of related &#39;territory&#39; | [optional]  |
| **fieldsInAppPurchasePricePoints** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchasePricePoints | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**InAppPurchasePricePointsResponse**](InAppPurchasePricePointsResponse.md)

### Authorization

[itc-bearer-token](../README.md#itc-bearer-token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Parameter error(s) |  -  |
| **401** | Unauthorized error(s) |  -  |
| **403** | Forbidden error |  -  |
| **404** | Not found error |  -  |
| **200** | List of InAppPurchasePricePoints |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2promotedpurchasegettoonerelated"></a>
# **InAppPurchasesV2PromotedPurchaseGetToOneRelated**
> PromotedPurchaseResponse InAppPurchasesV2PromotedPurchaseGetToOneRelated (string id, List<string>? fieldsPromotedPurchases = null, List<string>? fieldsInAppPurchases = null, List<string>? fieldsSubscriptions = null, List<string>? fieldsPromotedPurchaseImages = null, List<string>? include = null, int? limitPromotionImages = null)



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
    public class InAppPurchasesV2PromotedPurchaseGetToOneRelatedExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsPromotedPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchases (optional) 
            var fieldsInAppPurchases = new List<string>?(); // List<string>? | the fields to include for returned resources of type inAppPurchases (optional) 
            var fieldsSubscriptions = new List<string>?(); // List<string>? | the fields to include for returned resources of type subscriptions (optional) 
            var fieldsPromotedPurchaseImages = new List<string>?(); // List<string>? | the fields to include for returned resources of type promotedPurchaseImages (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitPromotionImages = 56;  // int? | maximum number of related promotionImages returned (when they are included) (optional) 

            try
            {
                PromotedPurchaseResponse result = apiInstance.InAppPurchasesV2PromotedPurchaseGetToOneRelated(id, fieldsPromotedPurchases, fieldsInAppPurchases, fieldsSubscriptions, fieldsPromotedPurchaseImages, include, limitPromotionImages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2PromotedPurchaseGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2PromotedPurchaseGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PromotedPurchaseResponse> response = apiInstance.InAppPurchasesV2PromotedPurchaseGetToOneRelatedWithHttpInfo(id, fieldsPromotedPurchases, fieldsInAppPurchases, fieldsSubscriptions, fieldsPromotedPurchaseImages, include, limitPromotionImages);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2PromotedPurchaseGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsPromotedPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchases | [optional]  |
| **fieldsInAppPurchases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type inAppPurchases | [optional]  |
| **fieldsSubscriptions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type subscriptions | [optional]  |
| **fieldsPromotedPurchaseImages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type promotedPurchaseImages | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitPromotionImages** | **int?** | maximum number of related promotionImages returned (when they are included) | [optional]  |

### Return type

[**PromotedPurchaseResponse**](PromotedPurchaseResponse.md)

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
| **200** | Single PromotedPurchase |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inapppurchasesv2updateinstance"></a>
# **InAppPurchasesV2UpdateInstance**
> InAppPurchaseV2Response InAppPurchasesV2UpdateInstance (string id, InAppPurchaseV2UpdateRequest inAppPurchaseV2UpdateRequest)



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
    public class InAppPurchasesV2UpdateInstanceExample
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
            var apiInstance = new InAppPurchasesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var inAppPurchaseV2UpdateRequest = new InAppPurchaseV2UpdateRequest(); // InAppPurchaseV2UpdateRequest | InAppPurchase representation

            try
            {
                InAppPurchaseV2Response result = apiInstance.InAppPurchasesV2UpdateInstance(id, inAppPurchaseV2UpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2UpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InAppPurchasesV2UpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InAppPurchaseV2Response> response = apiInstance.InAppPurchasesV2UpdateInstanceWithHttpInfo(id, inAppPurchaseV2UpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InAppPurchasesApi.InAppPurchasesV2UpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **inAppPurchaseV2UpdateRequest** | [**InAppPurchaseV2UpdateRequest**](InAppPurchaseV2UpdateRequest.md) | InAppPurchase representation |  |

### Return type

[**InAppPurchaseV2Response**](InAppPurchaseV2Response.md)

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
| **200** | Single InAppPurchase |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

