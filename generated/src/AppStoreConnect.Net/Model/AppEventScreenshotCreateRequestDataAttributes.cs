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
    /// AppEventScreenshotCreateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "AppEventScreenshotCreateRequest_data_attributes")]
    public partial class AppEventScreenshotCreateRequestDataAttributes : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AppEventAssetType
        /// </summary>
        [DataMember(Name = "appEventAssetType", IsRequired = true, EmitDefaultValue = true)]
        public AppEventAssetType AppEventAssetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventScreenshotCreateRequestDataAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppEventScreenshotCreateRequestDataAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventScreenshotCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="fileSize">fileSize (required).</param>
        /// <param name="fileName">fileName (required).</param>
        /// <param name="appEventAssetType">appEventAssetType (required).</param>
        public AppEventScreenshotCreateRequestDataAttributes(int fileSize = default(int), string fileName = default(string), AppEventAssetType appEventAssetType = default(AppEventAssetType))
        {
            this.FileSize = fileSize;
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName is a required property for AppEventScreenshotCreateRequestDataAttributes and cannot be null");
            }
            this.FileName = fileName;
            this.AppEventAssetType = appEventAssetType;
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
            sb.Append("class AppEventScreenshotCreateRequestDataAttributes {\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  AppEventAssetType: ").Append(AppEventAssetType).Append("\n");
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
