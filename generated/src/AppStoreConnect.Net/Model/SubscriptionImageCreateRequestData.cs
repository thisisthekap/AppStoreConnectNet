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
    /// SubscriptionImageCreateRequestData
    /// </summary>
    [DataContract(Name = "SubscriptionImageCreateRequest_data")]
    public partial class SubscriptionImageCreateRequestData : IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SubscriptionImages for value: subscriptionImages
            /// </summary>
            [EnumMember(Value = "subscriptionImages")]
            SubscriptionImages = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionImageCreateRequestData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionImageCreateRequestData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionImageCreateRequestData" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="attributes">attributes (required).</param>
        /// <param name="relationships">relationships (required).</param>
        public SubscriptionImageCreateRequestData(TypeEnum type = default(TypeEnum), AppClipAdvancedExperienceImageCreateRequestDataAttributes attributes = default(AppClipAdvancedExperienceImageCreateRequestDataAttributes), SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationships relationships = default(SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationships))
        {
            this.Type = type;
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes is a required property for SubscriptionImageCreateRequestData and cannot be null");
            }
            this.Attributes = attributes;
            // to ensure "relationships" is required (not null)
            if (relationships == null)
            {
                throw new ArgumentNullException("relationships is a required property for SubscriptionImageCreateRequestData and cannot be null");
            }
            this.Relationships = relationships;
        }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", IsRequired = true, EmitDefaultValue = true)]
        public AppClipAdvancedExperienceImageCreateRequestDataAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name = "relationships", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionImageCreateRequestData {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
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
