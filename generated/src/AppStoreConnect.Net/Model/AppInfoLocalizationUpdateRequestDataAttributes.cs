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
    /// AppInfoLocalizationUpdateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "AppInfoLocalizationUpdateRequest_data_attributes")]
    public partial class AppInfoLocalizationUpdateRequestDataAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="subtitle">subtitle.</param>
        /// <param name="privacyPolicyUrl">privacyPolicyUrl.</param>
        /// <param name="privacyChoicesUrl">privacyChoicesUrl.</param>
        /// <param name="privacyPolicyText">privacyPolicyText.</param>
        public AppInfoLocalizationUpdateRequestDataAttributes(string name = default(string), string subtitle = default(string), string privacyPolicyUrl = default(string), string privacyChoicesUrl = default(string), string privacyPolicyText = default(string))
        {
            this.Name = name;
            this.Subtitle = subtitle;
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.PrivacyChoicesUrl = privacyChoicesUrl;
            this.PrivacyPolicyText = privacyPolicyText;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Subtitle
        /// </summary>
        [DataMember(Name = "subtitle", EmitDefaultValue = false)]
        public string Subtitle { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyPolicyUrl
        /// </summary>
        [DataMember(Name = "privacyPolicyUrl", EmitDefaultValue = false)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyChoicesUrl
        /// </summary>
        [DataMember(Name = "privacyChoicesUrl", EmitDefaultValue = false)]
        public string PrivacyChoicesUrl { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyPolicyText
        /// </summary>
        [DataMember(Name = "privacyPolicyText", EmitDefaultValue = false)]
        public string PrivacyPolicyText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppInfoLocalizationUpdateRequestDataAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  PrivacyPolicyUrl: ").Append(PrivacyPolicyUrl).Append("\n");
            sb.Append("  PrivacyChoicesUrl: ").Append(PrivacyChoicesUrl).Append("\n");
            sb.Append("  PrivacyPolicyText: ").Append(PrivacyPolicyText).Append("\n");
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
