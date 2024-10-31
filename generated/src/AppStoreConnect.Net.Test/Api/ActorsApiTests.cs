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
    ///  Class for testing ActorsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ActorsApiTests : IDisposable
    {
        private ActorsApi instance;

        public ActorsApiTests()
        {
            instance = new ActorsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ActorsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ActorsApi
            //Assert.IsType<ActorsApi>(instance);
        }

        /// <summary>
        /// Test ActorsGetCollection
        /// </summary>
        [Fact]
        public void ActorsGetCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> filterId = null;
            //List<string>? fieldsActors = null;
            //int? limit = null;
            //var response = instance.ActorsGetCollection(filterId, fieldsActors, limit);
            //Assert.IsType<ActorsResponse>(response);
        }

        /// <summary>
        /// Test ActorsGetInstance
        /// </summary>
        [Fact]
        public void ActorsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsActors = null;
            //var response = instance.ActorsGetInstance(id, fieldsActors);
            //Assert.IsType<ActorResponse>(response);
        }
    }
}
