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
    /// Defines AppClipAction
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppClipAction
    {
        /// <summary>
        /// Enum OPEN for value: OPEN
        /// </summary>
        [EnumMember(Value = "OPEN")]
        OPEN = 1,

        /// <summary>
        /// Enum VIEW for value: VIEW
        /// </summary>
        [EnumMember(Value = "VIEW")]
        VIEW = 2,

        /// <summary>
        /// Enum PLAY for value: PLAY
        /// </summary>
        [EnumMember(Value = "PLAY")]
        PLAY = 3
    }

}
