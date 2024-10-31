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
    /// CiBranchPatterns
    /// </summary>
    [DataContract(Name = "CiBranchPatterns")]
    public partial class CiBranchPatterns : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CiBranchPatterns" /> class.
        /// </summary>
        /// <param name="isAllMatch">isAllMatch.</param>
        /// <param name="patterns">patterns.</param>
        public CiBranchPatterns(bool isAllMatch = default(bool), List<CiBranchPatternsPatternsInner> patterns = default(List<CiBranchPatternsPatternsInner>))
        {
            this.IsAllMatch = isAllMatch;
            this.Patterns = patterns;
        }

        /// <summary>
        /// Gets or Sets IsAllMatch
        /// </summary>
        [DataMember(Name = "isAllMatch", EmitDefaultValue = true)]
        public bool IsAllMatch { get; set; }

        /// <summary>
        /// Gets or Sets Patterns
        /// </summary>
        [DataMember(Name = "patterns", EmitDefaultValue = false)]
        public List<CiBranchPatternsPatternsInner> Patterns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiBranchPatterns {\n");
            sb.Append("  IsAllMatch: ").Append(IsAllMatch).Append("\n");
            sb.Append("  Patterns: ").Append(Patterns).Append("\n");
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
