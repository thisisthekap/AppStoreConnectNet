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
    /// AppEncryptionDeclarationDocumentAttributes
    /// </summary>
    [DataContract(Name = "AppEncryptionDeclarationDocument_attributes")]
    public partial class AppEncryptionDeclarationDocumentAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationDocumentAttributes" /> class.
        /// </summary>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="assetToken">assetToken.</param>
        /// <param name="downloadUrl">downloadUrl.</param>
        /// <param name="sourceFileChecksum">sourceFileChecksum.</param>
        /// <param name="uploadOperations">uploadOperations.</param>
        /// <param name="assetDeliveryState">assetDeliveryState.</param>
        public AppEncryptionDeclarationDocumentAttributes(int fileSize = default(int), string fileName = default(string), string assetToken = default(string), string downloadUrl = default(string), string sourceFileChecksum = default(string), List<UploadOperation> uploadOperations = default(List<UploadOperation>), AppMediaAssetState assetDeliveryState = default(AppMediaAssetState))
        {
            this.FileSize = fileSize;
            this.FileName = fileName;
            this.AssetToken = assetToken;
            this.DownloadUrl = downloadUrl;
            this.SourceFileChecksum = sourceFileChecksum;
            this.UploadOperations = uploadOperations;
            this.AssetDeliveryState = assetDeliveryState;
        }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        public int FileSize { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name = "fileName", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets AssetToken
        /// </summary>
        [DataMember(Name = "assetToken", EmitDefaultValue = false)]
        public string AssetToken { get; set; }

        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or Sets SourceFileChecksum
        /// </summary>
        [DataMember(Name = "sourceFileChecksum", EmitDefaultValue = false)]
        public string SourceFileChecksum { get; set; }

        /// <summary>
        /// Gets or Sets UploadOperations
        /// </summary>
        [DataMember(Name = "uploadOperations", EmitDefaultValue = false)]
        public List<UploadOperation> UploadOperations { get; set; }

        /// <summary>
        /// Gets or Sets AssetDeliveryState
        /// </summary>
        [DataMember(Name = "assetDeliveryState", EmitDefaultValue = false)]
        public AppMediaAssetState AssetDeliveryState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppEncryptionDeclarationDocumentAttributes {\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  AssetToken: ").Append(AssetToken).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  SourceFileChecksum: ").Append(SourceFileChecksum).Append("\n");
            sb.Append("  UploadOperations: ").Append(UploadOperations).Append("\n");
            sb.Append("  AssetDeliveryState: ").Append(AssetDeliveryState).Append("\n");
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
