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
    /// AppStoreVersionAttributes
    /// </summary>
    [DataContract(Name = "AppStoreVersion_attributes")]
    public partial class AppStoreVersionAttributes : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public Platform? Platform { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreState
        /// </summary>
        [DataMember(Name = "appStoreState", EmitDefaultValue = false)]
        public AppStoreVersionState? AppStoreState { get; set; }

        /// <summary>
        /// Gets or Sets AppVersionState
        /// </summary>
        [DataMember(Name = "appVersionState", EmitDefaultValue = false)]
        public AppVersionState? AppVersionState { get; set; }
        /// <summary>
        /// Defines ReviewType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReviewTypeEnum
        {
            /// <summary>
            /// Enum APPSTORE for value: APP_STORE
            /// </summary>
            [EnumMember(Value = "APP_STORE")]
            APPSTORE = 1,

            /// <summary>
            /// Enum NOTARIZATION for value: NOTARIZATION
            /// </summary>
            [EnumMember(Value = "NOTARIZATION")]
            NOTARIZATION = 2
        }


        /// <summary>
        /// Gets or Sets ReviewType
        /// </summary>
        [DataMember(Name = "reviewType", EmitDefaultValue = false)]
        public ReviewTypeEnum? ReviewType { get; set; }
        /// <summary>
        /// Defines ReleaseType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReleaseTypeEnum
        {
            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL = 1,

            /// <summary>
            /// Enum AFTERAPPROVAL for value: AFTER_APPROVAL
            /// </summary>
            [EnumMember(Value = "AFTER_APPROVAL")]
            AFTERAPPROVAL = 2,

            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            [EnumMember(Value = "SCHEDULED")]
            SCHEDULED = 3
        }


        /// <summary>
        /// Gets or Sets ReleaseType
        /// </summary>
        [DataMember(Name = "releaseType", EmitDefaultValue = false)]
        public ReleaseTypeEnum? ReleaseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionAttributes" /> class.
        /// </summary>
        /// <param name="platform">platform.</param>
        /// <param name="versionString">versionString.</param>
        /// <param name="appStoreState">appStoreState.</param>
        /// <param name="appVersionState">appVersionState.</param>
        /// <param name="copyright">copyright.</param>
        /// <param name="reviewType">reviewType.</param>
        /// <param name="releaseType">releaseType.</param>
        /// <param name="earliestReleaseDate">earliestReleaseDate.</param>
        /// <param name="downloadable">downloadable.</param>
        /// <param name="createdDate">createdDate.</param>
        public AppStoreVersionAttributes(Platform? platform = default(Platform?), string versionString = default(string), AppStoreVersionState? appStoreState = default(AppStoreVersionState?), AppVersionState? appVersionState = default(AppVersionState?), string copyright = default(string), ReviewTypeEnum? reviewType = default(ReviewTypeEnum?), ReleaseTypeEnum? releaseType = default(ReleaseTypeEnum?), DateTimeOffset earliestReleaseDate = default(DateTimeOffset), bool downloadable = default(bool), DateTimeOffset createdDate = default(DateTimeOffset))
        {
            this.Platform = platform;
            this.VersionString = versionString;
            this.AppStoreState = appStoreState;
            this.AppVersionState = appVersionState;
            this.Copyright = copyright;
            this.ReviewType = reviewType;
            this.ReleaseType = releaseType;
            this.EarliestReleaseDate = earliestReleaseDate;
            this.Downloadable = downloadable;
            this.CreatedDate = createdDate;
        }

        /// <summary>
        /// Gets or Sets VersionString
        /// </summary>
        [DataMember(Name = "versionString", EmitDefaultValue = false)]
        public string VersionString { get; set; }

        /// <summary>
        /// Gets or Sets Copyright
        /// </summary>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or Sets EarliestReleaseDate
        /// </summary>
        [DataMember(Name = "earliestReleaseDate", EmitDefaultValue = false)]
        public DateTimeOffset EarliestReleaseDate { get; set; }

        /// <summary>
        /// Gets or Sets Downloadable
        /// </summary>
        [DataMember(Name = "downloadable", EmitDefaultValue = true)]
        public bool Downloadable { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreVersionAttributes {\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  VersionString: ").Append(VersionString).Append("\n");
            sb.Append("  AppStoreState: ").Append(AppStoreState).Append("\n");
            sb.Append("  AppVersionState: ").Append(AppVersionState).Append("\n");
            sb.Append("  Copyright: ").Append(Copyright).Append("\n");
            sb.Append("  ReviewType: ").Append(ReviewType).Append("\n");
            sb.Append("  ReleaseType: ").Append(ReleaseType).Append("\n");
            sb.Append("  EarliestReleaseDate: ").Append(EarliestReleaseDate).Append("\n");
            sb.Append("  Downloadable: ").Append(Downloadable).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
