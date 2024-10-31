/*
 * App Store Connect API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 3.6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = AppStoreConnect.Net.Client.FileParameter;
using OpenAPIDateConverter = AppStoreConnect.Net.Client.OpenAPIDateConverter;

namespace AppStoreConnect.Net.Model
{
    /// <summary>
    /// Defines CiActionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CiActionType
    {
        /// <summary>
        /// Enum BUILD for value: BUILD
        /// </summary>
        [EnumMember(Value = "BUILD")]
        BUILD = 1,

        /// <summary>
        /// Enum ANALYZE for value: ANALYZE
        /// </summary>
        [EnumMember(Value = "ANALYZE")]
        ANALYZE = 2,

        /// <summary>
        /// Enum TEST for value: TEST
        /// </summary>
        [EnumMember(Value = "TEST")]
        TEST = 3,

        /// <summary>
        /// Enum ARCHIVE for value: ARCHIVE
        /// </summary>
        [EnumMember(Value = "ARCHIVE")]
        ARCHIVE = 4
    }

}
