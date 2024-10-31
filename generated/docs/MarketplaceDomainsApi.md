# AppStoreConnect.Net.Api.MarketplaceDomainsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MarketplaceDomainsCreateInstance**](MarketplaceDomainsApi.md#marketplacedomainscreateinstance) | **POST** /v1/marketplaceDomains |  |
| [**MarketplaceDomainsDeleteInstance**](MarketplaceDomainsApi.md#marketplacedomainsdeleteinstance) | **DELETE** /v1/marketplaceDomains/{id} |  |
| [**MarketplaceDomainsGetCollection**](MarketplaceDomainsApi.md#marketplacedomainsgetcollection) | **GET** /v1/marketplaceDomains |  |
| [**MarketplaceDomainsGetInstance**](MarketplaceDomainsApi.md#marketplacedomainsgetinstance) | **GET** /v1/marketplaceDomains/{id} |  |

<a id="marketplacedomainscreateinstance"></a>
# **MarketplaceDomainsCreateInstance**
> MarketplaceDomainResponse MarketplaceDomainsCreateInstance (MarketplaceDomainCreateRequest marketplaceDomainCreateRequest)



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
    public class MarketplaceDomainsCreateInstanceExample
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
            var apiInstance = new MarketplaceDomainsApi(httpClient, config, httpClientHandler);
            var marketplaceDomainCreateRequest = new MarketplaceDomainCreateRequest(); // MarketplaceDomainCreateRequest | MarketplaceDomain representation

            try
            {
                MarketplaceDomainResponse result = apiInstance.MarketplaceDomainsCreateInstance(marketplaceDomainCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceDomainsApi.MarketplaceDomainsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarketplaceDomainsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MarketplaceDomainResponse> response = apiInstance.MarketplaceDomainsCreateInstanceWithHttpInfo(marketplaceDomainCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceDomainsApi.MarketplaceDomainsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **marketplaceDomainCreateRequest** | [**MarketplaceDomainCreateRequest**](MarketplaceDomainCreateRequest.md) | MarketplaceDomain representation |  |

### Return type

[**MarketplaceDomainResponse**](MarketplaceDomainResponse.md)

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
| **201** | Single MarketplaceDomain |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="marketplacedomainsdeleteinstance"></a>
# **MarketplaceDomainsDeleteInstance**
> void MarketplaceDomainsDeleteInstance (string id)



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
    public class MarketplaceDomainsDeleteInstanceExample
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
            var apiInstance = new MarketplaceDomainsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.MarketplaceDomainsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceDomainsApi.MarketplaceDomainsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarketplaceDomainsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MarketplaceDomainsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceDomainsApi.MarketplaceDomainsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a id="marketplacedomainsgetcollection"></a>
# **MarketplaceDomainsGetCollection**
> MarketplaceDomainsResponse MarketplaceDomainsGetCollection (List<string>? fieldsMarketplaceDomains = null, int? limit = null)



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
    public class MarketplaceDomainsGetCollectionExample
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
            var apiInstance = new MarketplaceDomainsApi(httpClient, config, httpClientHandler);
            var fieldsMarketplaceDomains = new List<string>?(); // List<string>? | the fields to include for returned resources of type marketplaceDomains (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 

            try
            {
                MarketplaceDomainsResponse result = apiInstance.MarketplaceDomainsGetCollection(fieldsMarketplaceDomains, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceDomainsApi.MarketplaceDomainsGetCollection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarketplaceDomainsGetCollectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MarketplaceDomainsResponse> response = apiInstance.MarketplaceDomainsGetCollectionWithHttpInfo(fieldsMarketplaceDomains, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceDomainsApi.MarketplaceDomainsGetCollectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fieldsMarketplaceDomains** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type marketplaceDomains | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |

### Return type

[**MarketplaceDomainsResponse**](MarketplaceDomainsResponse.md)

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
| **200** | List of MarketplaceDomains |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="marketplacedomainsgetinstance"></a>
# **MarketplaceDomainsGetInstance**
> MarketplaceDomainResponse MarketplaceDomainsGetInstance (string id, List<string>? fieldsMarketplaceDomains = null)



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
    public class MarketplaceDomainsGetInstanceExample
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
            var apiInstance = new MarketplaceDomainsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsMarketplaceDomains = new List<string>?(); // List<string>? | the fields to include for returned resources of type marketplaceDomains (optional) 

            try
            {
                MarketplaceDomainResponse result = apiInstance.MarketplaceDomainsGetInstance(id, fieldsMarketplaceDomains);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketplaceDomainsApi.MarketplaceDomainsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarketplaceDomainsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MarketplaceDomainResponse> response = apiInstance.MarketplaceDomainsGetInstanceWithHttpInfo(id, fieldsMarketplaceDomains);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketplaceDomainsApi.MarketplaceDomainsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsMarketplaceDomains** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type marketplaceDomains | [optional]  |

### Return type

[**MarketplaceDomainResponse**](MarketplaceDomainResponse.md)

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
| **200** | Single MarketplaceDomain |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

