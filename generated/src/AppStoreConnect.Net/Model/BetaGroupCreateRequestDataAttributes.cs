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
    /// BetaGroupCreateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "BetaGroupCreateRequest_data_attributes")]
    public partial class BetaGroupCreateRequestDataAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BetaGroupCreateRequestDataAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="isInternalGroup">isInternalGroup.</param>
        /// <param name="hasAccessToAllBuilds">hasAccessToAllBuilds.</param>
        /// <param name="publicLinkEnabled">publicLinkEnabled.</param>
        /// <param name="publicLinkLimitEnabled">publicLinkLimitEnabled.</param>
        /// <param name="publicLinkLimit">publicLinkLimit.</param>
        /// <param name="feedbackEnabled">feedbackEnabled.</param>
        public BetaGroupCreateRequestDataAttributes(string name = default(string), bool isInternalGroup = default(bool), bool hasAccessToAllBuilds = default(bool), bool publicLinkEnabled = default(bool), bool publicLinkLimitEnabled = default(bool), int publicLinkLimit = default(int), bool feedbackEnabled = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for BetaGroupCreateRequestDataAttributes and cannot be null");
            }
            this.Name = name;
            this.IsInternalGroup = isInternalGroup;
            this.HasAccessToAllBuilds = hasAccessToAllBuilds;
            this.PublicLinkEnabled = publicLinkEnabled;
            this.PublicLinkLimitEnabled = publicLinkLimitEnabled;
            this.PublicLinkLimit = publicLinkLimit;
            this.FeedbackEnabled = feedbackEnabled;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsInternalGroup
        /// </summary>
        [DataMember(Name = "isInternalGroup", EmitDefaultValue = true)]
        public bool IsInternalGroup { get; set; }

        /// <summary>
        /// Gets or Sets HasAccessToAllBuilds
        /// </summary>
        [DataMember(Name = "hasAccessToAllBuilds", EmitDefaultValue = true)]
        public bool HasAccessToAllBuilds { get; set; }

        /// <summary>
        /// Gets or Sets PublicLinkEnabled
        /// </summary>
        [DataMember(Name = "publicLinkEnabled", EmitDefaultValue = true)]
        public bool PublicLinkEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PublicLinkLimitEnabled
        /// </summary>
        [DataMember(Name = "publicLinkLimitEnabled", EmitDefaultValue = true)]
        public bool PublicLinkLimitEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PublicLinkLimit
        /// </summary>
        [DataMember(Name = "publicLinkLimit", EmitDefaultValue = false)]
        public int PublicLinkLimit { get; set; }

        /// <summary>
        /// Gets or Sets FeedbackEnabled
        /// </summary>
        [DataMember(Name = "feedbackEnabled", EmitDefaultValue = true)]
        public bool FeedbackEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BetaGroupCreateRequestDataAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsInternalGroup: ").Append(IsInternalGroup).Append("\n");
            sb.Append("  HasAccessToAllBuilds: ").Append(HasAccessToAllBuilds).Append("\n");
            sb.Append("  PublicLinkEnabled: ").Append(PublicLinkEnabled).Append("\n");
            sb.Append("  PublicLinkLimitEnabled: ").Append(PublicLinkLimitEnabled).Append("\n");
            sb.Append("  PublicLinkLimit: ").Append(PublicLinkLimit).Append("\n");
            sb.Append("  FeedbackEnabled: ").Append(FeedbackEnabled).Append("\n");
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
