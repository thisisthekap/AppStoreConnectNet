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
    /// AppClipAdvancedExperienceImageCreateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "AppClipAdvancedExperienceImageCreateRequest_data_attributes")]
    public partial class AppClipAdvancedExperienceImageCreateRequestDataAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceImageCreateRequestDataAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppClipAdvancedExperienceImageCreateRequestDataAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceImageCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="fileSize">fileSize (required).</param>
        /// <param name="fileName">fileName (required).</param>
        public AppClipAdvancedExperienceImageCreateRequestDataAttributes(int fileSize = default(int), string fileName = default(string))
        {
            this.FileSize = fileSize;
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName is a required property for AppClipAdvancedExperienceImageCreateRequestDataAttributes and cannot be null");
            }
            this.FileName = fileName;
        }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name = "fileSize", IsRequired = true, EmitDefaultValue = true)]
        public int FileSize { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppClipAdvancedExperienceImageCreateRequestDataAttributes {\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
