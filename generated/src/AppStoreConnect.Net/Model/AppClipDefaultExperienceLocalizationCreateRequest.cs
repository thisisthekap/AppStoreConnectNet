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
    /// AppClipDefaultExperienceLocalizationCreateRequest
    /// </summary>
    [DataContract(Name = "AppClipDefaultExperienceLocalizationCreateRequest")]
    public partial class AppClipDefaultExperienceLocalizationCreateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppClipDefaultExperienceLocalizationCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationCreateRequest" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        public AppClipDefaultExperienceLocalizationCreateRequest(AppClipDefaultExperienceLocalizationCreateRequestData data = default(AppClipDefaultExperienceLocalizationCreateRequestData))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for AppClipDefaultExperienceLocalizationCreateRequest and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public AppClipDefaultExperienceLocalizationCreateRequestData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipDefaultExperienceLocalizationCreateRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
