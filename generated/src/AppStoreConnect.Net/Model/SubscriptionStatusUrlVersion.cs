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
    /// Defines SubscriptionStatusUrlVersion
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionStatusUrlVersion
    {
        /// <summary>
        /// Enum V1 for value: V1
        /// </summary>
        [EnumMember(Value = "V1")]
        V1 = 1,

        /// <summary>
        /// Enum V2 for value: V2
        /// </summary>
        [EnumMember(Value = "V2")]
        V2 = 2
    }

}
