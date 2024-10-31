# AppStoreConnect.Net.Api.AppAvailabilitiesApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppAvailabilitiesAvailableTerritoriesGetToManyRelated**](AppAvailabilitiesApi.md#appavailabilitiesavailableterritoriesgettomanyrelated) | **GET** /v1/appAvailabilities/{id}/availableTerritories |  |
| [**AppAvailabilitiesCreateInstance**](AppAvailabilitiesApi.md#appavailabilitiescreateinstance) | **POST** /v1/appAvailabilities |  |
| [**AppAvailabilitiesGetInstance**](AppAvailabilitiesApi.md#appavailabilitiesgetinstance) | **GET** /v1/appAvailabilities/{id} |  |
| [**AppAvailabilitiesV2CreateInstance**](AppAvailabilitiesApi.md#appavailabilitiesv2createinstance) | **POST** /v2/appAvailabilities |  |
| [**AppAvailabilitiesV2GetInstance**](AppAvailabilitiesApi.md#appavailabilitiesv2getinstance) | **GET** /v2/appAvailabilities/{id} |  |
| [**AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelated**](AppAvailabilitiesApi.md#appavailabilitiesv2territoryavailabilitiesgettomanyrelated) | **GET** /v2/appAvailabilities/{id}/territoryAvailabilities |  |

<a id="appavailabilitiesavailableterritoriesgettomanyrelated"></a>
# **AppAvailabilitiesAvailableTerritoriesGetToManyRelated**
> TerritoriesResponse AppAvailabilitiesAvailableTerritoriesGetToManyRelated (string id, List<string>? fieldsTerritories = null, int? limit = null)



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
    public class AppAvailabilitiesAvailableTerritoriesGetToManyRelatedExample
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
            var apiInstance = new AppAvailabilitiesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                TerritoriesResponse result = apiInstance.AppAvailabilitiesAvailableTerritoriesGetToManyRelated(id, fieldsTerritories, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesAvailableTerritoriesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppAvailabilitiesAvailableTerritoriesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TerritoriesResponse> response = apiInstance.AppAvailabilitiesAvailableTerritoriesGetToManyRelatedWithHttpInfo(id, fieldsTerritories, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesAvailableTerritoriesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**TerritoriesResponse**](TerritoriesResponse.md)

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
| **200** | List of Territories |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appavailabilitiescreateinstance"></a>
# **AppAvailabilitiesCreateInstance**
> AppAvailabilityResponse AppAvailabilitiesCreateInstance (AppAvailabilityCreateRequest appAvailabilityCreateRequest)



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
    public class AppAvailabilitiesCreateInstanceExample
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
            var apiInstance = new AppAvailabilitiesApi(httpClient, config, httpClientHandler);
            var appAvailabilityCreateRequest = new AppAvailabilityCreateRequest(); // AppAvailabilityCreateRequest | AppAvailability representation

            try
            {
                AppAvailabilityResponse result = apiInstance.AppAvailabilitiesCreateInstance(appAvailabilityCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppAvailabilitiesCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppAvailabilityResponse> response = apiInstance.AppAvailabilitiesCreateInstanceWithHttpInfo(appAvailabilityCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appAvailabilityCreateRequest** | [**AppAvailabilityCreateRequest**](AppAvailabilityCreateRequest.md) | AppAvailability representation |  |

### Return type

[**AppAvailabilityResponse**](AppAvailabilityResponse.md)

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
| **201** | Single AppAvailability |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appavailabilitiesgetinstance"></a>
# **AppAvailabilitiesGetInstance**
> AppAvailabilityResponse AppAvailabilitiesGetInstance (string id, List<string>? fieldsAppAvailabilities = null, List<string>? fieldsTerritories = null, List<string>? include = null, int? limitAvailableTerritories = null)



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
    public class AppAvailabilitiesGetInstanceExample
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
            var apiInstance = new AppAvailabilitiesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppAvailabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type appAvailabilities (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitAvailableTerritories = 56;  // int? | maximum number of related availableTerritories returned (when they are included) (optional) 

            try
            {
                AppAvailabilityResponse result = apiInstance.AppAvailabilitiesGetInstance(id, fieldsAppAvailabilities, fieldsTerritories, include, limitAvailableTerritories);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppAvailabilitiesGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppAvailabilityResponse> response = apiInstance.AppAvailabilitiesGetInstanceWithHttpInfo(id, fieldsAppAvailabilities, fieldsTerritories, include, limitAvailableTerritories);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppAvailabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appAvailabilities | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitAvailableTerritories** | **int?** | maximum number of related availableTerritories returned (when they are included) | [optional]  |

### Return type

[**AppAvailabilityResponse**](AppAvailabilityResponse.md)

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
| **200** | Single AppAvailability |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appavailabilitiesv2createinstance"></a>
# **AppAvailabilitiesV2CreateInstance**
> AppAvailabilityV2Response AppAvailabilitiesV2CreateInstance (AppAvailabilityV2CreateRequest appAvailabilityV2CreateRequest)



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
    public class AppAvailabilitiesV2CreateInstanceExample
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
            var apiInstance = new AppAvailabilitiesApi(httpClient, config, httpClientHandler);
            var appAvailabilityV2CreateRequest = new AppAvailabilityV2CreateRequest(); // AppAvailabilityV2CreateRequest | AppAvailability representation

            try
            {
                AppAvailabilityV2Response result = apiInstance.AppAvailabilitiesV2CreateInstance(appAvailabilityV2CreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesV2CreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppAvailabilitiesV2CreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppAvailabilityV2Response> response = apiInstance.AppAvailabilitiesV2CreateInstanceWithHttpInfo(appAvailabilityV2CreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesV2CreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appAvailabilityV2CreateRequest** | [**AppAvailabilityV2CreateRequest**](AppAvailabilityV2CreateRequest.md) | AppAvailability representation |  |

### Return type

[**AppAvailabilityV2Response**](AppAvailabilityV2Response.md)

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
| **201** | Single AppAvailability |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appavailabilitiesv2getinstance"></a>
# **AppAvailabilitiesV2GetInstance**
> AppAvailabilityV2Response AppAvailabilitiesV2GetInstance (string id, List<string>? fieldsAppAvailabilities = null, List<string>? fieldsTerritoryAvailabilities = null, List<string>? include = null, int? limitTerritoryAvailabilities = null)



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
    public class AppAvailabilitiesV2GetInstanceExample
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
            var apiInstance = new AppAvailabilitiesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppAvailabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type appAvailabilities (optional) 
            var fieldsTerritoryAvailabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type territoryAvailabilities (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitTerritoryAvailabilities = 56;  // int? | maximum number of related territoryAvailabilities returned (when they are included) (optional) 

            try
            {
                AppAvailabilityV2Response result = apiInstance.AppAvailabilitiesV2GetInstance(id, fieldsAppAvailabilities, fieldsTerritoryAvailabilities, include, limitTerritoryAvailabilities);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesV2GetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppAvailabilitiesV2GetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppAvailabilityV2Response> response = apiInstance.AppAvailabilitiesV2GetInstanceWithHttpInfo(id, fieldsAppAvailabilities, fieldsTerritoryAvailabilities, include, limitTerritoryAvailabilities);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesV2GetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppAvailabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appAvailabilities | [optional]  |
| **fieldsTerritoryAvailabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territoryAvailabilities | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitTerritoryAvailabilities** | **int?** | maximum number of related territoryAvailabilities returned (when they are included) | [optional]  |

### Return type

[**AppAvailabilityV2Response**](AppAvailabilityV2Response.md)

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
| **200** | Single AppAvailability |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appavailabilitiesv2territoryavailabilitiesgettomanyrelated"></a>
# **AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelated**
> TerritoryAvailabilitiesResponse AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelated (string id, List<string>? fieldsTerritoryAvailabilities = null, List<string>? fieldsTerritories = null, int? limit = null, List<string>? include = null)



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
    public class AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedExample
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
            var apiInstance = new AppAvailabilitiesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsTerritoryAvailabilities = new List<string>?(); // List<string>? | the fields to include for returned resources of type territoryAvailabilities (optional) 
            var fieldsTerritories = new List<string>?(); // List<string>? | the fields to include for returned resources of type territories (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                TerritoryAvailabilitiesResponse result = apiInstance.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelated(id, fieldsTerritoryAvailabilities, fieldsTerritories, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TerritoryAvailabilitiesResponse> response = apiInstance.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedWithHttpInfo(id, fieldsTerritoryAvailabilities, fieldsTerritories, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppAvailabilitiesApi.AppAvailabilitiesV2TerritoryAvailabilitiesGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsTerritoryAvailabilities** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territoryAvailabilities | [optional]  |
| **fieldsTerritories** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type territories | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**TerritoryAvailabilitiesResponse**](TerritoryAvailabilitiesResponse.md)

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
| **200** | List of TerritoryAvailabilities |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

