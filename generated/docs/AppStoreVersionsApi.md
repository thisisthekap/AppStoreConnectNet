# AppStoreConnect.Net.Api.AppStoreVersionsApi

All URIs are relative to *https://api.appstoreconnect.apple.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppStoreVersionsAgeRatingDeclarationGetToOneRelated**](AppStoreVersionsApi.md#appstoreversionsageratingdeclarationgettoonerelated) | **GET** /v1/appStoreVersions/{id}/ageRatingDeclaration |  |
| [**AppStoreVersionsAlternativeDistributionPackageGetToOneRelated**](AppStoreVersionsApi.md#appstoreversionsalternativedistributionpackagegettoonerelated) | **GET** /v1/appStoreVersions/{id}/alternativeDistributionPackage |  |
| [**AppStoreVersionsAppClipDefaultExperienceGetToOneRelated**](AppStoreVersionsApi.md#appstoreversionsappclipdefaultexperiencegettoonerelated) | **GET** /v1/appStoreVersions/{id}/appClipDefaultExperience |  |
| [**AppStoreVersionsAppClipDefaultExperienceGetToOneRelationship**](AppStoreVersionsApi.md#appstoreversionsappclipdefaultexperiencegettoonerelationship) | **GET** /v1/appStoreVersions/{id}/relationships/appClipDefaultExperience |  |
| [**AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationship**](AppStoreVersionsApi.md#appstoreversionsappclipdefaultexperienceupdatetoonerelationship) | **PATCH** /v1/appStoreVersions/{id}/relationships/appClipDefaultExperience |  |
| [**AppStoreVersionsAppStoreReviewDetailGetToOneRelated**](AppStoreVersionsApi.md#appstoreversionsappstorereviewdetailgettoonerelated) | **GET** /v1/appStoreVersions/{id}/appStoreReviewDetail |  |
| [**AppStoreVersionsAppStoreVersionExperimentsGetToManyRelated**](AppStoreVersionsApi.md#appstoreversionsappstoreversionexperimentsgettomanyrelated) | **GET** /v1/appStoreVersions/{id}/appStoreVersionExperiments |  |
| [**AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelated**](AppStoreVersionsApi.md#appstoreversionsappstoreversionexperimentsv2gettomanyrelated) | **GET** /v1/appStoreVersions/{id}/appStoreVersionExperimentsV2 |  |
| [**AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelated**](AppStoreVersionsApi.md#appstoreversionsappstoreversionlocalizationsgettomanyrelated) | **GET** /v1/appStoreVersions/{id}/appStoreVersionLocalizations |  |
| [**AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelated**](AppStoreVersionsApi.md#appstoreversionsappstoreversionphasedreleasegettoonerelated) | **GET** /v1/appStoreVersions/{id}/appStoreVersionPhasedRelease |  |
| [**AppStoreVersionsAppStoreVersionSubmissionGetToOneRelated**](AppStoreVersionsApi.md#appstoreversionsappstoreversionsubmissiongettoonerelated) | **GET** /v1/appStoreVersions/{id}/appStoreVersionSubmission |  |
| [**AppStoreVersionsBuildGetToOneRelated**](AppStoreVersionsApi.md#appstoreversionsbuildgettoonerelated) | **GET** /v1/appStoreVersions/{id}/build |  |
| [**AppStoreVersionsBuildGetToOneRelationship**](AppStoreVersionsApi.md#appstoreversionsbuildgettoonerelationship) | **GET** /v1/appStoreVersions/{id}/relationships/build |  |
| [**AppStoreVersionsBuildUpdateToOneRelationship**](AppStoreVersionsApi.md#appstoreversionsbuildupdatetoonerelationship) | **PATCH** /v1/appStoreVersions/{id}/relationships/build |  |
| [**AppStoreVersionsCreateInstance**](AppStoreVersionsApi.md#appstoreversionscreateinstance) | **POST** /v1/appStoreVersions |  |
| [**AppStoreVersionsCustomerReviewsGetToManyRelated**](AppStoreVersionsApi.md#appstoreversionscustomerreviewsgettomanyrelated) | **GET** /v1/appStoreVersions/{id}/customerReviews |  |
| [**AppStoreVersionsDeleteInstance**](AppStoreVersionsApi.md#appstoreversionsdeleteinstance) | **DELETE** /v1/appStoreVersions/{id} |  |
| [**AppStoreVersionsGameCenterAppVersionGetToOneRelated**](AppStoreVersionsApi.md#appstoreversionsgamecenterappversiongettoonerelated) | **GET** /v1/appStoreVersions/{id}/gameCenterAppVersion |  |
| [**AppStoreVersionsGetInstance**](AppStoreVersionsApi.md#appstoreversionsgetinstance) | **GET** /v1/appStoreVersions/{id} |  |
| [**AppStoreVersionsRoutingAppCoverageGetToOneRelated**](AppStoreVersionsApi.md#appstoreversionsroutingappcoveragegettoonerelated) | **GET** /v1/appStoreVersions/{id}/routingAppCoverage |  |
| [**AppStoreVersionsUpdateInstance**](AppStoreVersionsApi.md#appstoreversionsupdateinstance) | **PATCH** /v1/appStoreVersions/{id} |  |

<a id="appstoreversionsageratingdeclarationgettoonerelated"></a>
# **AppStoreVersionsAgeRatingDeclarationGetToOneRelated**
> AgeRatingDeclarationWithoutIncludesResponse AppStoreVersionsAgeRatingDeclarationGetToOneRelated (string id, List<string>? fieldsAgeRatingDeclarations = null)



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
    public class AppStoreVersionsAgeRatingDeclarationGetToOneRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAgeRatingDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type ageRatingDeclarations (optional) 

            try
            {
                AgeRatingDeclarationWithoutIncludesResponse result = apiInstance.AppStoreVersionsAgeRatingDeclarationGetToOneRelated(id, fieldsAgeRatingDeclarations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAgeRatingDeclarationGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAgeRatingDeclarationGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgeRatingDeclarationWithoutIncludesResponse> response = apiInstance.AppStoreVersionsAgeRatingDeclarationGetToOneRelatedWithHttpInfo(id, fieldsAgeRatingDeclarations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAgeRatingDeclarationGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAgeRatingDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ageRatingDeclarations | [optional]  |

### Return type

[**AgeRatingDeclarationWithoutIncludesResponse**](AgeRatingDeclarationWithoutIncludesResponse.md)

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
| **200** | Single AgeRatingDeclaration with get |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsalternativedistributionpackagegettoonerelated"></a>
# **AppStoreVersionsAlternativeDistributionPackageGetToOneRelated**
> AlternativeDistributionPackageResponse AppStoreVersionsAlternativeDistributionPackageGetToOneRelated (string id, List<string>? fieldsAlternativeDistributionPackages = null, List<string>? fieldsAlternativeDistributionPackageVersions = null, List<string>? include = null, int? limitVersions = null)



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
    public class AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAlternativeDistributionPackages = new List<string>?(); // List<string>? | the fields to include for returned resources of type alternativeDistributionPackages (optional) 
            var fieldsAlternativeDistributionPackageVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type alternativeDistributionPackageVersions (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitVersions = 56;  // int? | maximum number of related versions returned (when they are included) (optional) 

            try
            {
                AlternativeDistributionPackageResponse result = apiInstance.AppStoreVersionsAlternativeDistributionPackageGetToOneRelated(id, fieldsAlternativeDistributionPackages, fieldsAlternativeDistributionPackageVersions, include, limitVersions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAlternativeDistributionPackageGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlternativeDistributionPackageResponse> response = apiInstance.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedWithHttpInfo(id, fieldsAlternativeDistributionPackages, fieldsAlternativeDistributionPackageVersions, include, limitVersions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAlternativeDistributionPackages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type alternativeDistributionPackages | [optional]  |
| **fieldsAlternativeDistributionPackageVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type alternativeDistributionPackageVersions | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitVersions** | **int?** | maximum number of related versions returned (when they are included) | [optional]  |

### Return type

[**AlternativeDistributionPackageResponse**](AlternativeDistributionPackageResponse.md)

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
| **200** | Single AlternativeDistributionPackage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsappclipdefaultexperiencegettoonerelated"></a>
# **AppStoreVersionsAppClipDefaultExperienceGetToOneRelated**
> AppClipDefaultExperienceResponse AppStoreVersionsAppClipDefaultExperienceGetToOneRelated (string id, List<string>? fieldsAppClipDefaultExperiences = null, List<string>? fieldsAppClips = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppClipDefaultExperienceLocalizations = null, List<string>? fieldsAppClipAppStoreReviewDetails = null, List<string>? include = null, int? limitAppClipDefaultExperienceLocalizations = null)



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
    public class AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var fieldsAppClips = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClips (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppClipDefaultExperienceLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperienceLocalizations (optional) 
            var fieldsAppClipAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipAppStoreReviewDetails (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitAppClipDefaultExperienceLocalizations = 56;  // int? | maximum number of related appClipDefaultExperienceLocalizations returned (when they are included) (optional) 

            try
            {
                AppClipDefaultExperienceResponse result = apiInstance.AppStoreVersionsAppClipDefaultExperienceGetToOneRelated(id, fieldsAppClipDefaultExperiences, fieldsAppClips, fieldsAppStoreVersions, fieldsAppClipDefaultExperienceLocalizations, fieldsAppClipAppStoreReviewDetails, include, limitAppClipDefaultExperienceLocalizations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppClipDefaultExperienceGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppClipDefaultExperienceResponse> response = apiInstance.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedWithHttpInfo(id, fieldsAppClipDefaultExperiences, fieldsAppClips, fieldsAppStoreVersions, fieldsAppClipDefaultExperienceLocalizations, fieldsAppClipAppStoreReviewDetails, include, limitAppClipDefaultExperienceLocalizations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **fieldsAppClips** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClips | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppClipDefaultExperienceLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperienceLocalizations | [optional]  |
| **fieldsAppClipAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipAppStoreReviewDetails | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitAppClipDefaultExperienceLocalizations** | **int?** | maximum number of related appClipDefaultExperienceLocalizations returned (when they are included) | [optional]  |

### Return type

[**AppClipDefaultExperienceResponse**](AppClipDefaultExperienceResponse.md)

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
| **200** | Single AppClipDefaultExperience |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsappclipdefaultexperiencegettoonerelationship"></a>
# **AppStoreVersionsAppClipDefaultExperienceGetToOneRelationship**
> AppStoreVersionAppClipDefaultExperienceLinkageResponse AppStoreVersionsAppClipDefaultExperienceGetToOneRelationship (string id)



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
    public class AppStoreVersionsAppClipDefaultExperienceGetToOneRelationshipExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                AppStoreVersionAppClipDefaultExperienceLinkageResponse result = apiInstance.AppStoreVersionsAppClipDefaultExperienceGetToOneRelationship(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppClipDefaultExperienceGetToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAppClipDefaultExperienceGetToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionAppClipDefaultExperienceLinkageResponse> response = apiInstance.AppStoreVersionsAppClipDefaultExperienceGetToOneRelationshipWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppClipDefaultExperienceGetToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

[**AppStoreVersionAppClipDefaultExperienceLinkageResponse**](AppStoreVersionAppClipDefaultExperienceLinkageResponse.md)

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

<a id="appstoreversionsappclipdefaultexperienceupdatetoonerelationship"></a>
# **AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationship**
> void AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationship (string id, AppStoreVersionAppClipDefaultExperienceLinkageRequest appStoreVersionAppClipDefaultExperienceLinkageRequest)



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
    public class AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationshipExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appStoreVersionAppClipDefaultExperienceLinkageRequest = new AppStoreVersionAppClipDefaultExperienceLinkageRequest(); // AppStoreVersionAppClipDefaultExperienceLinkageRequest | Related linkage

            try
            {
                apiInstance.AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationship(id, appStoreVersionAppClipDefaultExperienceLinkageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationshipWithHttpInfo(id, appStoreVersionAppClipDefaultExperienceLinkageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppClipDefaultExperienceUpdateToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appStoreVersionAppClipDefaultExperienceLinkageRequest** | [**AppStoreVersionAppClipDefaultExperienceLinkageRequest**](AppStoreVersionAppClipDefaultExperienceLinkageRequest.md) | Related linkage |  |

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

<a id="appstoreversionsappstorereviewdetailgettoonerelated"></a>
# **AppStoreVersionsAppStoreReviewDetailGetToOneRelated**
> AppStoreReviewDetailResponse AppStoreVersionsAppStoreReviewDetailGetToOneRelated (string id, List<string>? fieldsAppStoreReviewDetails = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppStoreReviewAttachments = null, List<string>? include = null, int? limitAppStoreReviewAttachments = null)



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
    public class AppStoreVersionsAppStoreReviewDetailGetToOneRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewDetails (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppStoreReviewAttachments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewAttachments (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitAppStoreReviewAttachments = 56;  // int? | maximum number of related appStoreReviewAttachments returned (when they are included) (optional) 

            try
            {
                AppStoreReviewDetailResponse result = apiInstance.AppStoreVersionsAppStoreReviewDetailGetToOneRelated(id, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsAppStoreReviewAttachments, include, limitAppStoreReviewAttachments);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreReviewDetailGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAppStoreReviewDetailGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreReviewDetailResponse> response = apiInstance.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedWithHttpInfo(id, fieldsAppStoreReviewDetails, fieldsAppStoreVersions, fieldsAppStoreReviewAttachments, include, limitAppStoreReviewAttachments);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewDetails | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppStoreReviewAttachments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewAttachments | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitAppStoreReviewAttachments** | **int?** | maximum number of related appStoreReviewAttachments returned (when they are included) | [optional]  |

### Return type

[**AppStoreReviewDetailResponse**](AppStoreReviewDetailResponse.md)

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
| **200** | Single AppStoreReviewDetail |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsappstoreversionexperimentsgettomanyrelated"></a>
# **AppStoreVersionsAppStoreVersionExperimentsGetToManyRelated**
> AppStoreVersionExperimentsResponse AppStoreVersionsAppStoreVersionExperimentsGetToManyRelated (string id, List<string>? filterState = null, List<string>? fieldsAppStoreVersionExperiments = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppStoreVersionExperimentTreatments = null, int? limit = null, List<string>? include = null, int? limitAppStoreVersionExperimentTreatments = null)



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
    public class AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterState = new List<string>?(); // List<string>? | filter by attribute 'state' (optional) 
            var fieldsAppStoreVersionExperiments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperiments (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppStoreVersionExperimentTreatments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperimentTreatments (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitAppStoreVersionExperimentTreatments = 56;  // int? | maximum number of related appStoreVersionExperimentTreatments returned (when they are included) (optional) 

            try
            {
                AppStoreVersionExperimentsResponse result = apiInstance.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelated(id, filterState, fieldsAppStoreVersionExperiments, fieldsAppStoreVersions, fieldsAppStoreVersionExperimentTreatments, limit, include, limitAppStoreVersionExperimentTreatments);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionExperimentsResponse> response = apiInstance.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedWithHttpInfo(id, filterState, fieldsAppStoreVersionExperiments, fieldsAppStoreVersions, fieldsAppStoreVersionExperimentTreatments, limit, include, limitAppStoreVersionExperimentTreatments);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;state&#39; | [optional]  |
| **fieldsAppStoreVersionExperiments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperiments | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppStoreVersionExperimentTreatments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperimentTreatments | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitAppStoreVersionExperimentTreatments** | **int?** | maximum number of related appStoreVersionExperimentTreatments returned (when they are included) | [optional]  |

### Return type

[**AppStoreVersionExperimentsResponse**](AppStoreVersionExperimentsResponse.md)

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
| **200** | List of AppStoreVersionExperiments |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsappstoreversionexperimentsv2gettomanyrelated"></a>
# **AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelated**
> AppStoreVersionExperimentsV2Response AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelated (string id, List<string>? filterState = null, List<string>? fieldsAppStoreVersionExperiments = null, List<string>? fieldsApps = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppStoreVersionExperimentTreatments = null, int? limit = null, List<string>? include = null, int? limitControlVersions = null, int? limitAppStoreVersionExperimentTreatments = null)



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
    public class AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterState = new List<string>?(); // List<string>? | filter by attribute 'state' (optional) 
            var fieldsAppStoreVersionExperiments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperiments (optional) 
            var fieldsApps = new List<string>?(); // List<string>? | the fields to include for returned resources of type apps (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppStoreVersionExperimentTreatments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperimentTreatments (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitControlVersions = 56;  // int? | maximum number of related controlVersions returned (when they are included) (optional) 
            var limitAppStoreVersionExperimentTreatments = 56;  // int? | maximum number of related appStoreVersionExperimentTreatments returned (when they are included) (optional) 

            try
            {
                AppStoreVersionExperimentsV2Response result = apiInstance.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelated(id, filterState, fieldsAppStoreVersionExperiments, fieldsApps, fieldsAppStoreVersions, fieldsAppStoreVersionExperimentTreatments, limit, include, limitControlVersions, limitAppStoreVersionExperimentTreatments);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionExperimentsV2Response> response = apiInstance.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedWithHttpInfo(id, filterState, fieldsAppStoreVersionExperiments, fieldsApps, fieldsAppStoreVersions, fieldsAppStoreVersionExperimentTreatments, limit, include, limitControlVersions, limitAppStoreVersionExperimentTreatments);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterState** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;state&#39; | [optional]  |
| **fieldsAppStoreVersionExperiments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperiments | [optional]  |
| **fieldsApps** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type apps | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppStoreVersionExperimentTreatments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperimentTreatments | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitControlVersions** | **int?** | maximum number of related controlVersions returned (when they are included) | [optional]  |
| **limitAppStoreVersionExperimentTreatments** | **int?** | maximum number of related appStoreVersionExperimentTreatments returned (when they are included) | [optional]  |

### Return type

[**AppStoreVersionExperimentsV2Response**](AppStoreVersionExperimentsV2Response.md)

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
| **200** | List of AppStoreVersionExperiments |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsappstoreversionlocalizationsgettomanyrelated"></a>
# **AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelated**
> AppStoreVersionLocalizationsResponse AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelated (string id, List<string>? filterLocale = null, List<string>? fieldsAppStoreVersionLocalizations = null, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAppScreenshotSets = null, List<string>? fieldsAppPreviewSets = null, int? limit = null, List<string>? include = null, int? limitAppScreenshotSets = null, int? limitAppPreviewSets = null)



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
    public class AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterLocale = new List<string>?(); // List<string>? | filter by attribute 'locale' (optional) 
            var fieldsAppStoreVersionLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionLocalizations (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAppScreenshotSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type appScreenshotSets (optional) 
            var fieldsAppPreviewSets = new List<string>?(); // List<string>? | the fields to include for returned resources of type appPreviewSets (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitAppScreenshotSets = 56;  // int? | maximum number of related appScreenshotSets returned (when they are included) (optional) 
            var limitAppPreviewSets = 56;  // int? | maximum number of related appPreviewSets returned (when they are included) (optional) 

            try
            {
                AppStoreVersionLocalizationsResponse result = apiInstance.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelated(id, filterLocale, fieldsAppStoreVersionLocalizations, fieldsAppStoreVersions, fieldsAppScreenshotSets, fieldsAppPreviewSets, limit, include, limitAppScreenshotSets, limitAppPreviewSets);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionLocalizationsResponse> response = apiInstance.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedWithHttpInfo(id, filterLocale, fieldsAppStoreVersionLocalizations, fieldsAppStoreVersions, fieldsAppScreenshotSets, fieldsAppPreviewSets, limit, include, limitAppScreenshotSets, limitAppPreviewSets);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterLocale** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;locale&#39; | [optional]  |
| **fieldsAppStoreVersionLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionLocalizations | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAppScreenshotSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appScreenshotSets | [optional]  |
| **fieldsAppPreviewSets** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appPreviewSets | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitAppScreenshotSets** | **int?** | maximum number of related appScreenshotSets returned (when they are included) | [optional]  |
| **limitAppPreviewSets** | **int?** | maximum number of related appPreviewSets returned (when they are included) | [optional]  |

### Return type

[**AppStoreVersionLocalizationsResponse**](AppStoreVersionLocalizationsResponse.md)

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
| **200** | List of AppStoreVersionLocalizations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsappstoreversionphasedreleasegettoonerelated"></a>
# **AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelated**
> AppStoreVersionPhasedReleaseWithoutIncludesResponse AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelated (string id, List<string>? fieldsAppStoreVersionPhasedReleases = null)



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
    public class AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreVersionPhasedReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionPhasedReleases (optional) 

            try
            {
                AppStoreVersionPhasedReleaseWithoutIncludesResponse result = apiInstance.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelated(id, fieldsAppStoreVersionPhasedReleases);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionPhasedReleaseWithoutIncludesResponse> response = apiInstance.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedWithHttpInfo(id, fieldsAppStoreVersionPhasedReleases);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreVersionPhasedReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionPhasedReleases | [optional]  |

### Return type

[**AppStoreVersionPhasedReleaseWithoutIncludesResponse**](AppStoreVersionPhasedReleaseWithoutIncludesResponse.md)

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
| **200** | Single AppStoreVersionPhasedRelease with get |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsappstoreversionsubmissiongettoonerelated"></a>
# **AppStoreVersionsAppStoreVersionSubmissionGetToOneRelated**
> AppStoreVersionSubmissionResponse AppStoreVersionsAppStoreVersionSubmissionGetToOneRelated (string id, List<string>? fieldsAppStoreVersionSubmissions = null, List<string>? fieldsAppStoreVersions = null, List<string>? include = null)



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
    public class AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreVersionSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionSubmissions (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                AppStoreVersionSubmissionResponse result = apiInstance.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelated(id, fieldsAppStoreVersionSubmissions, fieldsAppStoreVersions, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionSubmissionResponse> response = apiInstance.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedWithHttpInfo(id, fieldsAppStoreVersionSubmissions, fieldsAppStoreVersions, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreVersionSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionSubmissions | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**AppStoreVersionSubmissionResponse**](AppStoreVersionSubmissionResponse.md)

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
| **200** | Single AppStoreVersionSubmission |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsbuildgettoonerelated"></a>
# **AppStoreVersionsBuildGetToOneRelated**
> BuildWithoutIncludesResponse AppStoreVersionsBuildGetToOneRelated (string id, List<string>? fieldsBuilds = null)



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
    public class AppStoreVersionsBuildGetToOneRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 

            try
            {
                BuildWithoutIncludesResponse result = apiInstance.AppStoreVersionsBuildGetToOneRelated(id, fieldsBuilds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsBuildGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsBuildGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BuildWithoutIncludesResponse> response = apiInstance.AppStoreVersionsBuildGetToOneRelatedWithHttpInfo(id, fieldsBuilds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsBuildGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |

### Return type

[**BuildWithoutIncludesResponse**](BuildWithoutIncludesResponse.md)

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
| **200** | Single Build with get |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsbuildgettoonerelationship"></a>
# **AppStoreVersionsBuildGetToOneRelationship**
> AppStoreVersionBuildLinkageResponse AppStoreVersionsBuildGetToOneRelationship (string id)



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
    public class AppStoreVersionsBuildGetToOneRelationshipExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                AppStoreVersionBuildLinkageResponse result = apiInstance.AppStoreVersionsBuildGetToOneRelationship(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsBuildGetToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsBuildGetToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionBuildLinkageResponse> response = apiInstance.AppStoreVersionsBuildGetToOneRelationshipWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsBuildGetToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |

### Return type

[**AppStoreVersionBuildLinkageResponse**](AppStoreVersionBuildLinkageResponse.md)

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

<a id="appstoreversionsbuildupdatetoonerelationship"></a>
# **AppStoreVersionsBuildUpdateToOneRelationship**
> void AppStoreVersionsBuildUpdateToOneRelationship (string id, AppStoreVersionBuildLinkageRequest appStoreVersionBuildLinkageRequest)



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
    public class AppStoreVersionsBuildUpdateToOneRelationshipExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appStoreVersionBuildLinkageRequest = new AppStoreVersionBuildLinkageRequest(); // AppStoreVersionBuildLinkageRequest | Related linkage

            try
            {
                apiInstance.AppStoreVersionsBuildUpdateToOneRelationship(id, appStoreVersionBuildLinkageRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsBuildUpdateToOneRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsBuildUpdateToOneRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppStoreVersionsBuildUpdateToOneRelationshipWithHttpInfo(id, appStoreVersionBuildLinkageRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsBuildUpdateToOneRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appStoreVersionBuildLinkageRequest** | [**AppStoreVersionBuildLinkageRequest**](AppStoreVersionBuildLinkageRequest.md) | Related linkage |  |

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

<a id="appstoreversionscreateinstance"></a>
# **AppStoreVersionsCreateInstance**
> AppStoreVersionResponse AppStoreVersionsCreateInstance (AppStoreVersionCreateRequest appStoreVersionCreateRequest)



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
    public class AppStoreVersionsCreateInstanceExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var appStoreVersionCreateRequest = new AppStoreVersionCreateRequest(); // AppStoreVersionCreateRequest | AppStoreVersion representation

            try
            {
                AppStoreVersionResponse result = apiInstance.AppStoreVersionsCreateInstance(appStoreVersionCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsCreateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsCreateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionResponse> response = apiInstance.AppStoreVersionsCreateInstanceWithHttpInfo(appStoreVersionCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsCreateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appStoreVersionCreateRequest** | [**AppStoreVersionCreateRequest**](AppStoreVersionCreateRequest.md) | AppStoreVersion representation |  |

### Return type

[**AppStoreVersionResponse**](AppStoreVersionResponse.md)

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
| **201** | Single AppStoreVersion |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionscustomerreviewsgettomanyrelated"></a>
# **AppStoreVersionsCustomerReviewsGetToManyRelated**
> CustomerReviewsResponse AppStoreVersionsCustomerReviewsGetToManyRelated (string id, List<string>? filterTerritory = null, List<string>? filterRating = null, bool? existsPublishedResponse = null, List<string>? sort = null, List<string>? fieldsCustomerReviews = null, List<string>? fieldsCustomerReviewResponses = null, int? limit = null, List<string>? include = null)



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
    public class AppStoreVersionsCustomerReviewsGetToManyRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var filterTerritory = new List<string>?(); // List<string>? | filter by attribute 'territory' (optional) 
            var filterRating = new List<string>?(); // List<string>? | filter by attribute 'rating' (optional) 
            var existsPublishedResponse = true;  // bool? | filter by publishedResponse (optional) 
            var sort = new List<string>?(); // List<string>? | comma-separated list of sort expressions; resources will be sorted as specified (optional) 
            var fieldsCustomerReviews = new List<string>?(); // List<string>? | the fields to include for returned resources of type customerReviews (optional) 
            var fieldsCustomerReviewResponses = new List<string>?(); // List<string>? | the fields to include for returned resources of type customerReviewResponses (optional) 
            var limit = 56;  // int? | maximum resources per page (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 

            try
            {
                CustomerReviewsResponse result = apiInstance.AppStoreVersionsCustomerReviewsGetToManyRelated(id, filterTerritory, filterRating, existsPublishedResponse, sort, fieldsCustomerReviews, fieldsCustomerReviewResponses, limit, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsCustomerReviewsGetToManyRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsCustomerReviewsGetToManyRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CustomerReviewsResponse> response = apiInstance.AppStoreVersionsCustomerReviewsGetToManyRelatedWithHttpInfo(id, filterTerritory, filterRating, existsPublishedResponse, sort, fieldsCustomerReviews, fieldsCustomerReviewResponses, limit, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsCustomerReviewsGetToManyRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **filterTerritory** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;territory&#39; | [optional]  |
| **filterRating** | [**List&lt;string&gt;?**](string.md) | filter by attribute &#39;rating&#39; | [optional]  |
| **existsPublishedResponse** | **bool?** | filter by publishedResponse | [optional]  |
| **sort** | [**List&lt;string&gt;?**](string.md) | comma-separated list of sort expressions; resources will be sorted as specified | [optional]  |
| **fieldsCustomerReviews** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type customerReviews | [optional]  |
| **fieldsCustomerReviewResponses** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type customerReviewResponses | [optional]  |
| **limit** | **int?** | maximum resources per page | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |

### Return type

[**CustomerReviewsResponse**](CustomerReviewsResponse.md)

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
| **200** | List of CustomerReviews |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsdeleteinstance"></a>
# **AppStoreVersionsDeleteInstance**
> void AppStoreVersionsDeleteInstance (string id)



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
    public class AppStoreVersionsDeleteInstanceExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource

            try
            {
                apiInstance.AppStoreVersionsDeleteInstance(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsDeleteInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsDeleteInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AppStoreVersionsDeleteInstanceWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsDeleteInstanceWithHttpInfo: " + e.Message);
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

<a id="appstoreversionsgamecenterappversiongettoonerelated"></a>
# **AppStoreVersionsGameCenterAppVersionGetToOneRelated**
> GameCenterAppVersionResponse AppStoreVersionsGameCenterAppVersionGetToOneRelated (string id, List<string>? fieldsGameCenterAppVersions = null, List<string>? fieldsAppStoreVersions = null, List<string>? include = null, int? limitCompatibilityVersions = null)



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
    public class AppStoreVersionsGameCenterAppVersionGetToOneRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsGameCenterAppVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAppVersions (optional) 
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitCompatibilityVersions = 56;  // int? | maximum number of related compatibilityVersions returned (when they are included) (optional) 

            try
            {
                GameCenterAppVersionResponse result = apiInstance.AppStoreVersionsGameCenterAppVersionGetToOneRelated(id, fieldsGameCenterAppVersions, fieldsAppStoreVersions, include, limitCompatibilityVersions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsGameCenterAppVersionGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsGameCenterAppVersionGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GameCenterAppVersionResponse> response = apiInstance.AppStoreVersionsGameCenterAppVersionGetToOneRelatedWithHttpInfo(id, fieldsGameCenterAppVersions, fieldsAppStoreVersions, include, limitCompatibilityVersions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsGameCenterAppVersionGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsGameCenterAppVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAppVersions | [optional]  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitCompatibilityVersions** | **int?** | maximum number of related compatibilityVersions returned (when they are included) | [optional]  |

### Return type

[**GameCenterAppVersionResponse**](GameCenterAppVersionResponse.md)

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
| **200** | Single GameCenterAppVersion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsgetinstance"></a>
# **AppStoreVersionsGetInstance**
> AppStoreVersionResponse AppStoreVersionsGetInstance (string id, List<string>? fieldsAppStoreVersions = null, List<string>? fieldsAgeRatingDeclarations = null, List<string>? fieldsAppStoreVersionLocalizations = null, List<string>? fieldsBuilds = null, List<string>? fieldsAppStoreVersionPhasedReleases = null, List<string>? fieldsGameCenterAppVersions = null, List<string>? fieldsRoutingAppCoverages = null, List<string>? fieldsAppStoreReviewDetails = null, List<string>? fieldsAppStoreVersionSubmissions = null, List<string>? fieldsAppClipDefaultExperiences = null, List<string>? fieldsAppStoreVersionExperiments = null, List<string>? fieldsAlternativeDistributionPackages = null, List<string>? include = null, int? limitAppStoreVersionExperiments = null, int? limitAppStoreVersionExperimentsV2 = null, int? limitAppStoreVersionLocalizations = null)



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
    public class AppStoreVersionsGetInstanceExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsAppStoreVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersions (optional) 
            var fieldsAgeRatingDeclarations = new List<string>?(); // List<string>? | the fields to include for returned resources of type ageRatingDeclarations (optional) 
            var fieldsAppStoreVersionLocalizations = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionLocalizations (optional) 
            var fieldsBuilds = new List<string>?(); // List<string>? | the fields to include for returned resources of type builds (optional) 
            var fieldsAppStoreVersionPhasedReleases = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionPhasedReleases (optional) 
            var fieldsGameCenterAppVersions = new List<string>?(); // List<string>? | the fields to include for returned resources of type gameCenterAppVersions (optional) 
            var fieldsRoutingAppCoverages = new List<string>?(); // List<string>? | the fields to include for returned resources of type routingAppCoverages (optional) 
            var fieldsAppStoreReviewDetails = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreReviewDetails (optional) 
            var fieldsAppStoreVersionSubmissions = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionSubmissions (optional) 
            var fieldsAppClipDefaultExperiences = new List<string>?(); // List<string>? | the fields to include for returned resources of type appClipDefaultExperiences (optional) 
            var fieldsAppStoreVersionExperiments = new List<string>?(); // List<string>? | the fields to include for returned resources of type appStoreVersionExperiments (optional) 
            var fieldsAlternativeDistributionPackages = new List<string>?(); // List<string>? | the fields to include for returned resources of type alternativeDistributionPackages (optional) 
            var include = new List<string>?(); // List<string>? | comma-separated list of relationships to include (optional) 
            var limitAppStoreVersionExperiments = 56;  // int? | maximum number of related appStoreVersionExperiments returned (when they are included) (optional) 
            var limitAppStoreVersionExperimentsV2 = 56;  // int? | maximum number of related appStoreVersionExperimentsV2 returned (when they are included) (optional) 
            var limitAppStoreVersionLocalizations = 56;  // int? | maximum number of related appStoreVersionLocalizations returned (when they are included) (optional) 

            try
            {
                AppStoreVersionResponse result = apiInstance.AppStoreVersionsGetInstance(id, fieldsAppStoreVersions, fieldsAgeRatingDeclarations, fieldsAppStoreVersionLocalizations, fieldsBuilds, fieldsAppStoreVersionPhasedReleases, fieldsGameCenterAppVersions, fieldsRoutingAppCoverages, fieldsAppStoreReviewDetails, fieldsAppStoreVersionSubmissions, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionExperiments, fieldsAlternativeDistributionPackages, include, limitAppStoreVersionExperiments, limitAppStoreVersionExperimentsV2, limitAppStoreVersionLocalizations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsGetInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsGetInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionResponse> response = apiInstance.AppStoreVersionsGetInstanceWithHttpInfo(id, fieldsAppStoreVersions, fieldsAgeRatingDeclarations, fieldsAppStoreVersionLocalizations, fieldsBuilds, fieldsAppStoreVersionPhasedReleases, fieldsGameCenterAppVersions, fieldsRoutingAppCoverages, fieldsAppStoreReviewDetails, fieldsAppStoreVersionSubmissions, fieldsAppClipDefaultExperiences, fieldsAppStoreVersionExperiments, fieldsAlternativeDistributionPackages, include, limitAppStoreVersionExperiments, limitAppStoreVersionExperimentsV2, limitAppStoreVersionLocalizations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsGetInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsAppStoreVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersions | [optional]  |
| **fieldsAgeRatingDeclarations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type ageRatingDeclarations | [optional]  |
| **fieldsAppStoreVersionLocalizations** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionLocalizations | [optional]  |
| **fieldsBuilds** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type builds | [optional]  |
| **fieldsAppStoreVersionPhasedReleases** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionPhasedReleases | [optional]  |
| **fieldsGameCenterAppVersions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type gameCenterAppVersions | [optional]  |
| **fieldsRoutingAppCoverages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type routingAppCoverages | [optional]  |
| **fieldsAppStoreReviewDetails** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreReviewDetails | [optional]  |
| **fieldsAppStoreVersionSubmissions** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionSubmissions | [optional]  |
| **fieldsAppClipDefaultExperiences** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appClipDefaultExperiences | [optional]  |
| **fieldsAppStoreVersionExperiments** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type appStoreVersionExperiments | [optional]  |
| **fieldsAlternativeDistributionPackages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type alternativeDistributionPackages | [optional]  |
| **include** | [**List&lt;string&gt;?**](string.md) | comma-separated list of relationships to include | [optional]  |
| **limitAppStoreVersionExperiments** | **int?** | maximum number of related appStoreVersionExperiments returned (when they are included) | [optional]  |
| **limitAppStoreVersionExperimentsV2** | **int?** | maximum number of related appStoreVersionExperimentsV2 returned (when they are included) | [optional]  |
| **limitAppStoreVersionLocalizations** | **int?** | maximum number of related appStoreVersionLocalizations returned (when they are included) | [optional]  |

### Return type

[**AppStoreVersionResponse**](AppStoreVersionResponse.md)

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
| **200** | Single AppStoreVersion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsroutingappcoveragegettoonerelated"></a>
# **AppStoreVersionsRoutingAppCoverageGetToOneRelated**
> RoutingAppCoverageWithoutIncludesResponse AppStoreVersionsRoutingAppCoverageGetToOneRelated (string id, List<string>? fieldsRoutingAppCoverages = null)



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
    public class AppStoreVersionsRoutingAppCoverageGetToOneRelatedExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var fieldsRoutingAppCoverages = new List<string>?(); // List<string>? | the fields to include for returned resources of type routingAppCoverages (optional) 

            try
            {
                RoutingAppCoverageWithoutIncludesResponse result = apiInstance.AppStoreVersionsRoutingAppCoverageGetToOneRelated(id, fieldsRoutingAppCoverages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsRoutingAppCoverageGetToOneRelated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsRoutingAppCoverageGetToOneRelatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RoutingAppCoverageWithoutIncludesResponse> response = apiInstance.AppStoreVersionsRoutingAppCoverageGetToOneRelatedWithHttpInfo(id, fieldsRoutingAppCoverages);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsRoutingAppCoverageGetToOneRelatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **fieldsRoutingAppCoverages** | [**List&lt;string&gt;?**](string.md) | the fields to include for returned resources of type routingAppCoverages | [optional]  |

### Return type

[**RoutingAppCoverageWithoutIncludesResponse**](RoutingAppCoverageWithoutIncludesResponse.md)

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
| **200** | Single RoutingAppCoverage with get |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="appstoreversionsupdateinstance"></a>
# **AppStoreVersionsUpdateInstance**
> AppStoreVersionResponse AppStoreVersionsUpdateInstance (string id, AppStoreVersionUpdateRequest appStoreVersionUpdateRequest)



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
    public class AppStoreVersionsUpdateInstanceExample
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
            var apiInstance = new AppStoreVersionsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | the id of the requested resource
            var appStoreVersionUpdateRequest = new AppStoreVersionUpdateRequest(); // AppStoreVersionUpdateRequest | AppStoreVersion representation

            try
            {
                AppStoreVersionResponse result = apiInstance.AppStoreVersionsUpdateInstance(id, appStoreVersionUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsUpdateInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppStoreVersionsUpdateInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AppStoreVersionResponse> response = apiInstance.AppStoreVersionsUpdateInstanceWithHttpInfo(id, appStoreVersionUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppStoreVersionsApi.AppStoreVersionsUpdateInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | the id of the requested resource |  |
| **appStoreVersionUpdateRequest** | [**AppStoreVersionUpdateRequest**](AppStoreVersionUpdateRequest.md) | AppStoreVersion representation |  |

### Return type

[**AppStoreVersionResponse**](AppStoreVersionResponse.md)

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
| **200** | Single AppStoreVersion |  -  |
| **409** | Request entity error(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

