/*
 * App Store Connect API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 3.6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Model;

namespace AppStoreConnect.Net.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFinanceReportsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="AppStoreConnect.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterVendorNumber">filter by attribute &#39;vendorNumber&#39;</param>
        /// <param name="filterReportType">filter by attribute &#39;reportType&#39;</param>
        /// <param name="filterRegionCode">filter by attribute &#39;regionCode&#39;</param>
        /// <param name="filterReportDate">filter by attribute &#39;reportDate&#39;</param>
        /// <returns>FileParameter</returns>
        FileParameter FinanceReportsGetCollection(List<string> filterVendorNumber, List<string> filterReportType, List<string> filterRegionCode, List<string> filterReportDate);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppStoreConnect.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterVendorNumber">filter by attribute &#39;vendorNumber&#39;</param>
        /// <param name="filterReportType">filter by attribute &#39;reportType&#39;</param>
        /// <param name="filterRegionCode">filter by attribute &#39;regionCode&#39;</param>
        /// <param name="filterReportDate">filter by attribute &#39;reportDate&#39;</param>
        /// <returns>ApiResponse of FileParameter</returns>
        ApiResponse<FileParameter> FinanceReportsGetCollectionWithHttpInfo(List<string> filterVendorNumber, List<string> filterReportType, List<string> filterRegionCode, List<string> filterReportDate);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFinanceReportsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppStoreConnect.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterVendorNumber">filter by attribute &#39;vendorNumber&#39;</param>
        /// <param name="filterReportType">filter by attribute &#39;reportType&#39;</param>
        /// <param name="filterRegionCode">filter by attribute &#39;regionCode&#39;</param>
        /// <param name="filterReportDate">filter by attribute &#39;reportDate&#39;</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        System.Threading.Tasks.Task<FileParameter> FinanceReportsGetCollectionAsync(List<string> filterVendorNumber, List<string> filterReportType, List<string> filterRegionCode, List<string> filterReportDate, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AppStoreConnect.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterVendorNumber">filter by attribute &#39;vendorNumber&#39;</param>
        /// <param name="filterReportType">filter by attribute &#39;reportType&#39;</param>
        /// <param name="filterRegionCode">filter by attribute &#39;regionCode&#39;</param>
        /// <param name="filterReportDate">filter by attribute &#39;reportDate&#39;</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileParameter>> FinanceReportsGetCollectionWithHttpInfoAsync(List<string> filterVendorNumber, List<string> filterReportType, List<string> filterRegionCode, List<string> filterReportDate, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFinanceReportsApi : IFinanceReportsApiSync, IFinanceReportsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FinanceReportsApi : IDisposable, IFinanceReportsApi
    {
        private AppStoreConnect.Net.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceReportsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public FinanceReportsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceReportsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public FinanceReportsApi(string basePath)
        {
            this.Configuration = AppStoreConnect.Net.Client.Configuration.MergeConfigurations(
                AppStoreConnect.Net.Client.GlobalConfiguration.Instance,
                new AppStoreConnect.Net.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new AppStoreConnect.Net.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = AppStoreConnect.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceReportsApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public FinanceReportsApi(AppStoreConnect.Net.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AppStoreConnect.Net.Client.Configuration.MergeConfigurations(
                AppStoreConnect.Net.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new AppStoreConnect.Net.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = AppStoreConnect.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceReportsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FinanceReportsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceReportsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FinanceReportsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = AppStoreConnect.Net.Client.Configuration.MergeConfigurations(
                AppStoreConnect.Net.Client.GlobalConfiguration.Instance,
                new AppStoreConnect.Net.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new AppStoreConnect.Net.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = AppStoreConnect.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceReportsApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FinanceReportsApi(HttpClient client, AppStoreConnect.Net.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = AppStoreConnect.Net.Client.Configuration.MergeConfigurations(
                AppStoreConnect.Net.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new AppStoreConnect.Net.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = AppStoreConnect.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceReportsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public FinanceReportsApi(AppStoreConnect.Net.Client.ISynchronousClient client, AppStoreConnect.Net.Client.IAsynchronousClient asyncClient, AppStoreConnect.Net.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AppStoreConnect.Net.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public AppStoreConnect.Net.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AppStoreConnect.Net.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AppStoreConnect.Net.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AppStoreConnect.Net.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AppStoreConnect.Net.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="AppStoreConnect.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterVendorNumber">filter by attribute &#39;vendorNumber&#39;</param>
        /// <param name="filterReportType">filter by attribute &#39;reportType&#39;</param>
        /// <param name="filterRegionCode">filter by attribute &#39;regionCode&#39;</param>
        /// <param name="filterReportDate">filter by attribute &#39;reportDate&#39;</param>
        /// <returns>FileParameter</returns>
        public FileParameter FinanceReportsGetCollection(List<string> filterVendorNumber, List<string> filterReportType, List<string> filterRegionCode, List<string> filterReportDate)
        {
            AppStoreConnect.Net.Client.ApiResponse<FileParameter> localVarResponse = FinanceReportsGetCollectionWithHttpInfo(filterVendorNumber, filterReportType, filterRegionCode, filterReportDate);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="AppStoreConnect.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterVendorNumber">filter by attribute &#39;vendorNumber&#39;</param>
        /// <param name="filterReportType">filter by attribute &#39;reportType&#39;</param>
        /// <param name="filterRegionCode">filter by attribute &#39;regionCode&#39;</param>
        /// <param name="filterReportDate">filter by attribute &#39;reportDate&#39;</param>
        /// <returns>ApiResponse of FileParameter</returns>
        public AppStoreConnect.Net.Client.ApiResponse<FileParameter> FinanceReportsGetCollectionWithHttpInfo(List<string> filterVendorNumber, List<string> filterReportType, List<string> filterRegionCode, List<string> filterReportDate)
        {
            // verify the required parameter 'filterVendorNumber' is set
            if (filterVendorNumber == null)
                throw new AppStoreConnect.Net.Client.ApiException(400, "Missing required parameter 'filterVendorNumber' when calling FinanceReportsApi->FinanceReportsGetCollection");

            // verify the required parameter 'filterReportType' is set
            if (filterReportType == null)
                throw new AppStoreConnect.Net.Client.ApiException(400, "Missing required parameter 'filterReportType' when calling FinanceReportsApi->FinanceReportsGetCollection");

            // verify the required parameter 'filterRegionCode' is set
            if (filterRegionCode == null)
                throw new AppStoreConnect.Net.Client.ApiException(400, "Missing required parameter 'filterRegionCode' when calling FinanceReportsApi->FinanceReportsGetCollection");

            // verify the required parameter 'filterReportDate' is set
            if (filterReportDate == null)
                throw new AppStoreConnect.Net.Client.ApiException(400, "Missing required parameter 'filterReportDate' when calling FinanceReportsApi->FinanceReportsGetCollection");

            AppStoreConnect.Net.Client.RequestOptions localVarRequestOptions = new AppStoreConnect.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/a-gzip"
            };

            var localVarContentType = AppStoreConnect.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AppStoreConnect.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(AppStoreConnect.Net.Client.ClientUtils.ParameterToMultiMap("csv", "filter[vendorNumber]", filterVendorNumber));
            localVarRequestOptions.QueryParameters.Add(AppStoreConnect.Net.Client.ClientUtils.ParameterToMultiMap("csv", "filter[reportType]", filterReportType));
            localVarRequestOptions.QueryParameters.Add(AppStoreConnect.Net.Client.ClientUtils.ParameterToMultiMap("csv", "filter[regionCode]", filterRegionCode));
            localVarRequestOptions.QueryParameters.Add(AppStoreConnect.Net.Client.ClientUtils.ParameterToMultiMap("csv", "filter[reportDate]", filterReportDate));

            // authentication (itc-bearer-token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<FileParameter>("/v1/financeReports", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FinanceReportsGetCollection", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="AppStoreConnect.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterVendorNumber">filter by attribute &#39;vendorNumber&#39;</param>
        /// <param name="filterReportType">filter by attribute &#39;reportType&#39;</param>
        /// <param name="filterRegionCode">filter by attribute &#39;regionCode&#39;</param>
        /// <param name="filterReportDate">filter by attribute &#39;reportDate&#39;</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FileParameter</returns>
        public async System.Threading.Tasks.Task<FileParameter> FinanceReportsGetCollectionAsync(List<string> filterVendorNumber, List<string> filterReportType, List<string> filterRegionCode, List<string> filterReportDate, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            AppStoreConnect.Net.Client.ApiResponse<FileParameter> localVarResponse = await FinanceReportsGetCollectionWithHttpInfoAsync(filterVendorNumber, filterReportType, filterRegionCode, filterReportDate, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="AppStoreConnect.Net.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterVendorNumber">filter by attribute &#39;vendorNumber&#39;</param>
        /// <param name="filterReportType">filter by attribute &#39;reportType&#39;</param>
        /// <param name="filterRegionCode">filter by attribute &#39;regionCode&#39;</param>
        /// <param name="filterReportDate">filter by attribute &#39;reportDate&#39;</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FileParameter)</returns>
        public async System.Threading.Tasks.Task<AppStoreConnect.Net.Client.ApiResponse<FileParameter>> FinanceReportsGetCollectionWithHttpInfoAsync(List<string> filterVendorNumber, List<string> filterReportType, List<string> filterRegionCode, List<string> filterReportDate, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'filterVendorNumber' is set
            if (filterVendorNumber == null)
                throw new AppStoreConnect.Net.Client.ApiException(400, "Missing required parameter 'filterVendorNumber' when calling FinanceReportsApi->FinanceReportsGetCollection");

            // verify the required parameter 'filterReportType' is set
            if (filterReportType == null)
                throw new AppStoreConnect.Net.Client.ApiException(400, "Missing required parameter 'filterReportType' when calling FinanceReportsApi->FinanceReportsGetCollection");

            // verify the required parameter 'filterRegionCode' is set
            if (filterRegionCode == null)
                throw new AppStoreConnect.Net.Client.ApiException(400, "Missing required parameter 'filterRegionCode' when calling FinanceReportsApi->FinanceReportsGetCollection");

            // verify the required parameter 'filterReportDate' is set
            if (filterReportDate == null)
                throw new AppStoreConnect.Net.Client.ApiException(400, "Missing required parameter 'filterReportDate' when calling FinanceReportsApi->FinanceReportsGetCollection");


            AppStoreConnect.Net.Client.RequestOptions localVarRequestOptions = new AppStoreConnect.Net.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/a-gzip"
            };


            var localVarContentType = AppStoreConnect.Net.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = AppStoreConnect.Net.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(AppStoreConnect.Net.Client.ClientUtils.ParameterToMultiMap("csv", "filter[vendorNumber]", filterVendorNumber));
            localVarRequestOptions.QueryParameters.Add(AppStoreConnect.Net.Client.ClientUtils.ParameterToMultiMap("csv", "filter[reportType]", filterReportType));
            localVarRequestOptions.QueryParameters.Add(AppStoreConnect.Net.Client.ClientUtils.ParameterToMultiMap("csv", "filter[regionCode]", filterRegionCode));
            localVarRequestOptions.QueryParameters.Add(AppStoreConnect.Net.Client.ClientUtils.ParameterToMultiMap("csv", "filter[reportDate]", filterReportDate));

            // authentication (itc-bearer-token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileParameter>("/v1/financeReports", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FinanceReportsGetCollection", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
