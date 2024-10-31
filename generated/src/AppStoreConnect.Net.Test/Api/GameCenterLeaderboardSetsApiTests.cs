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
    ///  Class for testing GameCenterLeaderboardSetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GameCenterLeaderboardSetsApiTests : IDisposable
    {
        private GameCenterLeaderboardSetsApi instance;

        public GameCenterLeaderboardSetsApiTests()
        {
            instance = new GameCenterLeaderboardSetsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GameCenterLeaderboardSetsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GameCenterLeaderboardSetsApi
            //Assert.IsType<GameCenterLeaderboardSetsApi>(instance);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsCreateInstance
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsCreateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GameCenterLeaderboardSetCreateRequest gameCenterLeaderboardSetCreateRequest = null;
            //var response = instance.GameCenterLeaderboardSetsCreateInstance(gameCenterLeaderboardSetCreateRequest);
            //Assert.IsType<GameCenterLeaderboardSetResponse>(response);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsDeleteInstance
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsDeleteInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.GameCenterLeaderboardSetsDeleteInstance(id);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsGameCenterLeaderboardsCreateToManyRelationship
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsGameCenterLeaderboardsCreateToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest gameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest = null;
            //instance.GameCenterLeaderboardSetsGameCenterLeaderboardsCreateToManyRelationship(id, gameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsGameCenterLeaderboardsDeleteToManyRelationship
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsGameCenterLeaderboardsDeleteToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest gameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest = null;
            //instance.GameCenterLeaderboardSetsGameCenterLeaderboardsDeleteToManyRelationship(id, gameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelated
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterReferenceName = null;
            //List<string>? filterArchived = null;
            //List<string>? filterId = null;
            //List<string>? fieldsGameCenterLeaderboards = null;
            //List<string>? fieldsGameCenterDetails = null;
            //List<string>? fieldsGameCenterGroups = null;
            //List<string>? fieldsGameCenterLeaderboardSets = null;
            //List<string>? fieldsGameCenterLeaderboardLocalizations = null;
            //List<string>? fieldsGameCenterLeaderboardReleases = null;
            //int? limit = null;
            //List<string>? include = null;
            //int? limitGameCenterLeaderboardSets = null;
            //int? limitLocalizations = null;
            //int? limitReleases = null;
            //var response = instance.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelated(id, filterReferenceName, filterArchived, filterId, fieldsGameCenterLeaderboards, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSets, fieldsGameCenterLeaderboardLocalizations, fieldsGameCenterLeaderboardReleases, limit, include, limitGameCenterLeaderboardSets, limitLocalizations, limitReleases);
            //Assert.IsType<GameCenterLeaderboardsResponse>(response);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelationship
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //var response = instance.GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelationship(id, limit);
            //Assert.IsType<GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesResponse>(response);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsGameCenterLeaderboardsReplaceToManyRelationship
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsGameCenterLeaderboardsReplaceToManyRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest gameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest = null;
            //instance.GameCenterLeaderboardSetsGameCenterLeaderboardsReplaceToManyRelationship(id, gameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsGetInstance
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsGetInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsGameCenterLeaderboardSets = null;
            //List<string>? fieldsGameCenterLeaderboardSetLocalizations = null;
            //List<string>? fieldsGameCenterLeaderboards = null;
            //List<string>? fieldsGameCenterLeaderboardSetReleases = null;
            //List<string>? include = null;
            //int? limitGameCenterLeaderboards = null;
            //int? limitLocalizations = null;
            //int? limitReleases = null;
            //var response = instance.GameCenterLeaderboardSetsGetInstance(id, fieldsGameCenterLeaderboardSets, fieldsGameCenterLeaderboardSetLocalizations, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSetReleases, include, limitGameCenterLeaderboards, limitLocalizations, limitReleases);
            //Assert.IsType<GameCenterLeaderboardSetResponse>(response);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelated
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsGameCenterLeaderboardSets = null;
            //List<string>? fieldsGameCenterDetails = null;
            //List<string>? fieldsGameCenterGroups = null;
            //List<string>? fieldsGameCenterLeaderboardSetLocalizations = null;
            //List<string>? fieldsGameCenterLeaderboards = null;
            //List<string>? fieldsGameCenterLeaderboardSetReleases = null;
            //List<string>? include = null;
            //int? limitLocalizations = null;
            //int? limitGameCenterLeaderboards = null;
            //int? limitReleases = null;
            //var response = instance.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelated(id, fieldsGameCenterLeaderboardSets, fieldsGameCenterDetails, fieldsGameCenterGroups, fieldsGameCenterLeaderboardSetLocalizations, fieldsGameCenterLeaderboards, fieldsGameCenterLeaderboardSetReleases, include, limitLocalizations, limitGameCenterLeaderboards, limitReleases);
            //Assert.IsType<GameCenterLeaderboardSetResponse>(response);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelationship
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelationship(id);
            //Assert.IsType<GameCenterLeaderboardSetGroupLeaderboardSetLinkageResponse>(response);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsGroupLeaderboardSetUpdateToOneRelationship
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsGroupLeaderboardSetUpdateToOneRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //GameCenterLeaderboardSetGroupLeaderboardSetLinkageRequest gameCenterLeaderboardSetGroupLeaderboardSetLinkageRequest = null;
            //instance.GameCenterLeaderboardSetsGroupLeaderboardSetUpdateToOneRelationship(id, gameCenterLeaderboardSetGroupLeaderboardSetLinkageRequest);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsLocalizationsGetToManyRelated
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsLocalizationsGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? fieldsGameCenterLeaderboardSetLocalizations = null;
            //List<string>? fieldsGameCenterLeaderboardSets = null;
            //List<string>? fieldsGameCenterLeaderboardSetImages = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.GameCenterLeaderboardSetsLocalizationsGetToManyRelated(id, fieldsGameCenterLeaderboardSetLocalizations, fieldsGameCenterLeaderboardSets, fieldsGameCenterLeaderboardSetImages, limit, include);
            //Assert.IsType<GameCenterLeaderboardSetLocalizationsResponse>(response);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsReleasesGetToManyRelated
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsReleasesGetToManyRelatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? filterLive = null;
            //List<string>? filterGameCenterDetail = null;
            //List<string>? fieldsGameCenterLeaderboardSetReleases = null;
            //List<string>? fieldsGameCenterDetails = null;
            //List<string>? fieldsGameCenterLeaderboardSets = null;
            //int? limit = null;
            //List<string>? include = null;
            //var response = instance.GameCenterLeaderboardSetsReleasesGetToManyRelated(id, filterLive, filterGameCenterDetail, fieldsGameCenterLeaderboardSetReleases, fieldsGameCenterDetails, fieldsGameCenterLeaderboardSets, limit, include);
            //Assert.IsType<GameCenterLeaderboardSetReleasesResponse>(response);
        }

        /// <summary>
        /// Test GameCenterLeaderboardSetsUpdateInstance
        /// </summary>
        [Fact]
        public void GameCenterLeaderboardSetsUpdateInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //GameCenterLeaderboardSetUpdateRequest gameCenterLeaderboardSetUpdateRequest = null;
            //var response = instance.GameCenterLeaderboardSetsUpdateInstance(id, gameCenterLeaderboardSetUpdateRequest);
            //Assert.IsType<GameCenterLeaderboardSetResponse>(response);
        }
    }
}
