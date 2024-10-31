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
    /// AnalyticsReportAttributes
    /// </summary>
    [DataContract(Name = "AnalyticsReport_attributes")]
    public partial class AnalyticsReportAttributes : IValidatableObject
    {
        /// <summary>
        /// Defines Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum APPUSAGE for value: APP_USAGE
            /// </summary>
            [EnumMember(Value = "APP_USAGE")]
            APPUSAGE = 1,

            /// <summary>
            /// Enum APPSTOREENGAGEMENT for value: APP_STORE_ENGAGEMENT
            /// </summary>
            [EnumMember(Value = "APP_STORE_ENGAGEMENT")]
            APPSTOREENGAGEMENT = 2,

            /// <summary>
            /// Enum COMMERCE for value: COMMERCE
            /// </summary>
            [EnumMember(Value = "COMMERCE")]
            COMMERCE = 3,

            /// <summary>
            /// Enum FRAMEWORKUSAGE for value: FRAMEWORK_USAGE
            /// </summary>
            [EnumMember(Value = "FRAMEWORK_USAGE")]
            FRAMEWORKUSAGE = 4,

            /// <summary>
            /// Enum PERFORMANCE for value: PERFORMANCE
            /// </summary>
            [EnumMember(Value = "PERFORMANCE")]
            PERFORMANCE = 5
        }


        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsReportAttributes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="category">category.</param>
        public AnalyticsReportAttributes(string name = default(string), CategoryEnum? category = default(CategoryEnum?))
        {
            this.Name = name;
            this.Category = category;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AnalyticsReportAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
