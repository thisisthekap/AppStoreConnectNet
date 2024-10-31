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
    /// AppEncryptionDeclarationAttributes
    /// </summary>
    [DataContract(Name = "AppEncryptionDeclaration_attributes")]
    public partial class AppEncryptionDeclarationAttributes : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public Platform? Platform { get; set; }

        /// <summary>
        /// Gets or Sets AppEncryptionDeclarationState
        /// </summary>
        [DataMember(Name = "appEncryptionDeclarationState", EmitDefaultValue = false)]
        public AppEncryptionDeclarationState? AppEncryptionDeclarationState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationAttributes" /> class.
        /// </summary>
        /// <param name="appDescription">appDescription.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="usesEncryption">usesEncryption.</param>
        /// <param name="exempt">exempt.</param>
        /// <param name="containsProprietaryCryptography">containsProprietaryCryptography.</param>
        /// <param name="containsThirdPartyCryptography">containsThirdPartyCryptography.</param>
        /// <param name="availableOnFrenchStore">availableOnFrenchStore.</param>
        /// <param name="platform">platform.</param>
        /// <param name="uploadedDate">uploadedDate.</param>
        /// <param name="documentUrl">documentUrl.</param>
        /// <param name="documentName">documentName.</param>
        /// <param name="documentType">documentType.</param>
        /// <param name="appEncryptionDeclarationState">appEncryptionDeclarationState.</param>
        /// <param name="codeValue">codeValue.</param>
        public AppEncryptionDeclarationAttributes(string appDescription = default(string), DateTimeOffset createdDate = default(DateTimeOffset), bool usesEncryption = default(bool), bool exempt = default(bool), bool containsProprietaryCryptography = default(bool), bool containsThirdPartyCryptography = default(bool), bool availableOnFrenchStore = default(bool), Platform? platform = default(Platform?), DateTimeOffset uploadedDate = default(DateTimeOffset), string documentUrl = default(string), string documentName = default(string), string documentType = default(string), AppEncryptionDeclarationState? appEncryptionDeclarationState = default(AppEncryptionDeclarationState?), string codeValue = default(string))
        {
            this.AppDescription = appDescription;
            this.CreatedDate = createdDate;
            this.UsesEncryption = usesEncryption;
            this.Exempt = exempt;
            this.ContainsProprietaryCryptography = containsProprietaryCryptography;
            this.ContainsThirdPartyCryptography = containsThirdPartyCryptography;
            this.AvailableOnFrenchStore = availableOnFrenchStore;
            this.Platform = platform;
            this.UploadedDate = uploadedDate;
            this.DocumentUrl = documentUrl;
            this.DocumentName = documentName;
            this.DocumentType = documentType;
            this.AppEncryptionDeclarationState = appEncryptionDeclarationState;
            this.CodeValue = codeValue;
        }

        /// <summary>
        /// Gets or Sets AppDescription
        /// </summary>
        [DataMember(Name = "appDescription", EmitDefaultValue = false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets UsesEncryption
        /// </summary>
        [DataMember(Name = "usesEncryption", EmitDefaultValue = true)]
        [Obsolete]
        public bool UsesEncryption { get; set; }

        /// <summary>
        /// Gets or Sets Exempt
        /// </summary>
        [DataMember(Name = "exempt", EmitDefaultValue = true)]
        public bool Exempt { get; set; }

        /// <summary>
        /// Gets or Sets ContainsProprietaryCryptography
        /// </summary>
        [DataMember(Name = "containsProprietaryCryptography", EmitDefaultValue = true)]
        public bool ContainsProprietaryCryptography { get; set; }

        /// <summary>
        /// Gets or Sets ContainsThirdPartyCryptography
        /// </summary>
        [DataMember(Name = "containsThirdPartyCryptography", EmitDefaultValue = true)]
        public bool ContainsThirdPartyCryptography { get; set; }

        /// <summary>
        /// Gets or Sets AvailableOnFrenchStore
        /// </summary>
        [DataMember(Name = "availableOnFrenchStore", EmitDefaultValue = true)]
        public bool AvailableOnFrenchStore { get; set; }

        /// <summary>
        /// Gets or Sets UploadedDate
        /// </summary>
        [DataMember(Name = "uploadedDate", EmitDefaultValue = false)]
        [Obsolete]
        public DateTimeOffset UploadedDate { get; set; }

        /// <summary>
        /// Gets or Sets DocumentUrl
        /// </summary>
        [DataMember(Name = "documentUrl", EmitDefaultValue = false)]
        [Obsolete]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// Gets or Sets DocumentName
        /// </summary>
        [DataMember(Name = "documentName", EmitDefaultValue = false)]
        [Obsolete]
        public string DocumentName { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [DataMember(Name = "documentType", EmitDefaultValue = false)]
        [Obsolete]
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets CodeValue
        /// </summary>
        [DataMember(Name = "codeValue", EmitDefaultValue = false)]
        public string CodeValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppEncryptionDeclarationAttributes {\n");
            sb.Append("  AppDescription: ").Append(AppDescription).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  UsesEncryption: ").Append(UsesEncryption).Append("\n");
            sb.Append("  Exempt: ").Append(Exempt).Append("\n");
            sb.Append("  ContainsProprietaryCryptography: ").Append(ContainsProprietaryCryptography).Append("\n");
            sb.Append("  ContainsThirdPartyCryptography: ").Append(ContainsThirdPartyCryptography).Append("\n");
            sb.Append("  AvailableOnFrenchStore: ").Append(AvailableOnFrenchStore).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  UploadedDate: ").Append(UploadedDate).Append("\n");
            sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
            sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  AppEncryptionDeclarationState: ").Append(AppEncryptionDeclarationState).Append("\n");
            sb.Append("  CodeValue: ").Append(CodeValue).Append("\n");
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
