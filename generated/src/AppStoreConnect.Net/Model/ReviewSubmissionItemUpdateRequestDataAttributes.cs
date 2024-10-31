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
    /// ReviewSubmissionItemUpdateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "ReviewSubmissionItemUpdateRequest_data_attributes")]
    public partial class ReviewSubmissionItemUpdateRequestDataAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="resolved">resolved.</param>
        /// <param name="removed">removed.</param>
        public ReviewSubmissionItemUpdateRequestDataAttributes(bool resolved = default(bool), bool removed = default(bool))
        {
            this.Resolved = resolved;
            this.Removed = removed;
        }

        /// <summary>
        /// Gets or Sets Resolved
        /// </summary>
        [DataMember(Name = "resolved", EmitDefaultValue = true)]
        public bool Resolved { get; set; }

        /// <summary>
        /// Gets or Sets Removed
        /// </summary>
        [DataMember(Name = "removed", EmitDefaultValue = true)]
        public bool Removed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReviewSubmissionItemUpdateRequestDataAttributes {\n");
            sb.Append("  Resolved: ").Append(Resolved).Append("\n");
            sb.Append("  Removed: ").Append(Removed).Append("\n");
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
