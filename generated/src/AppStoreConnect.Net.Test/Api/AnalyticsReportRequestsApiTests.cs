/*
 * App Store Connect API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 3.6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using AppStoreConnect.Net.Client;
using AppStoreConnect.Net.Api;
// uncomment below to import models
//using AppStoreConnect.Net.Model;

namespace AppStoreConnect.Net.Test.Api
{
    /// <summary>
    ///  Class for testing AnalyticsReportRequestsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AnalyticsReportRequestsApiTests : IDisposable
    {
        private AnalyticsReportRequestsApi instance;

        public AnalyticsReportRequestsApiTests()
        {
            instance = new AnalyticsReportRequestsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AnalyticsReportRequestsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AnalyticsReportRequestsApi
            //Assert.IsType<AnalyticsReportRequestsApi>(instance);
        }

        /// <summary>
        /// Test AnalyticsReportRequestsCreateInstance
        /// </summary>
        [Fact]
        public void AnalyticsReportRequestsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AnalyticsReportRequestCreateRequest analyticsReportRequestCreateRequest = null;
            //var response = instance.AnalyticsReportRequestsCreateInstance(analyticsReportRequestCreateRequest);
            //Assert.IsType<AnalyticsReportRequestResponse>(response);
        }

        /// <summary>
        /// Test AnalyticsReportRequestsDeleteInstance
        /// </summary>
        [Fact]
        public void AnalyticsReportRequestsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AnalyticsReportRequestsDeleteInstance(id);
        }

        /// <summary>
        /// Test AnalyticsReportRequestsGetInstance
        /// </summary>
        [Fact]
        public void AnalyticsReportRequestsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsAnalyticsReportRequests = null;
            //List<string>? fieldsAnalyticsReports = null;
            //List<string>? include = null;
            //int? limitReports = null;
            //var response = instance.AnalyticsReportRequestsGetInstance(id, fieldsAnalyticsReportRequests, fieldsAnalyticsReports, include, limitReports);
            //Assert.IsType<AnalyticsReportRequestResponse>(response);
        }

        /// <summary>
        /// Test AnalyticsReportRequestsReportsGetToManyRelated
        /// </summary>
        [Fact]
        public void AnalyticsReportRequestsReportsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterName = null;
            //List<string>? filterCategory = null;
            //List<string>? fieldsAnalyticsReports = null;
            //int? limit = null;
            //var response = instance.AnalyticsReportRequestsReportsGetToManyRelated(id, filterName, filterCategory, fieldsAnalyticsReports, limit);
            //Assert.IsType<AnalyticsReportsResponse>(response);
        }
    }
}
