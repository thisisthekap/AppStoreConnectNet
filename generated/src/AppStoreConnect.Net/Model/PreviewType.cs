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
    /// Defines PreviewType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PreviewType
    {
        /// <summary>
        /// Enum IPHONE67 for value: IPHONE_67
        /// </summary>
        [EnumMember(Value = "IPHONE_67")]
        IPHONE67 = 1,

        /// <summary>
        /// Enum IPHONE61 for value: IPHONE_61
        /// </summary>
        [EnumMember(Value = "IPHONE_61")]
        IPHONE61 = 2,

        /// <summary>
        /// Enum IPHONE65 for value: IPHONE_65
        /// </summary>
        [EnumMember(Value = "IPHONE_65")]
        IPHONE65 = 3,

        /// <summary>
        /// Enum IPHONE58 for value: IPHONE_58
        /// </summary>
        [EnumMember(Value = "IPHONE_58")]
        IPHONE58 = 4,

        /// <summary>
        /// Enum IPHONE55 for value: IPHONE_55
        /// </summary>
        [EnumMember(Value = "IPHONE_55")]
        IPHONE55 = 5,

        /// <summary>
        /// Enum IPHONE47 for value: IPHONE_47
        /// </summary>
        [EnumMember(Value = "IPHONE_47")]
        IPHONE47 = 6,

        /// <summary>
        /// Enum IPHONE40 for value: IPHONE_40
        /// </summary>
        [EnumMember(Value = "IPHONE_40")]
        IPHONE40 = 7,

        /// <summary>
        /// Enum IPHONE35 for value: IPHONE_35
        /// </summary>
        [EnumMember(Value = "IPHONE_35")]
        IPHONE35 = 8,

        /// <summary>
        /// Enum IPADPRO3GEN129 for value: IPAD_PRO_3GEN_129
        /// </summary>
        [EnumMember(Value = "IPAD_PRO_3GEN_129")]
        IPADPRO3GEN129 = 9,

        /// <summary>
        /// Enum IPADPRO3GEN11 for value: IPAD_PRO_3GEN_11
        /// </summary>
        [EnumMember(Value = "IPAD_PRO_3GEN_11")]
        IPADPRO3GEN11 = 10,

        /// <summary>
        /// Enum IPADPRO129 for value: IPAD_PRO_129
        /// </summary>
        [EnumMember(Value = "IPAD_PRO_129")]
        IPADPRO129 = 11,

        /// <summary>
        /// Enum IPAD105 for value: IPAD_105
        /// </summary>
        [EnumMember(Value = "IPAD_105")]
        IPAD105 = 12,

        /// <summary>
        /// Enum IPAD97 for value: IPAD_97
        /// </summary>
        [EnumMember(Value = "IPAD_97")]
        IPAD97 = 13,

        /// <summary>
        /// Enum DESKTOP for value: DESKTOP
        /// </summary>
        [EnumMember(Value = "DESKTOP")]
        DESKTOP = 14,

        /// <summary>
        /// Enum APPLETV for value: APPLE_TV
        /// </summary>
        [EnumMember(Value = "APPLE_TV")]
        APPLETV = 15,

        /// <summary>
        /// Enum APPLEVISIONPRO for value: APPLE_VISION_PRO
        /// </summary>
        [EnumMember(Value = "APPLE_VISION_PRO")]
        APPLEVISIONPRO = 16
    }

}
