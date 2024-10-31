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
    /// GameCenterMatchmakingQueueAttributes
    /// </summary>
    [DataContract(Name = "GameCenterMatchmakingQueue_attributes")]
    public partial class GameCenterMatchmakingQueueAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueAttributes" /> class.
        /// </summary>
        /// <param name="referenceName">referenceName.</param>
        /// <param name="classicMatchmakingBundleIds">classicMatchmakingBundleIds.</param>
        public GameCenterMatchmakingQueueAttributes(string referenceName = default(string), List<string> classicMatchmakingBundleIds = default(List<string>))
        {
            this.ReferenceName = referenceName;
            this.ClassicMatchmakingBundleIds = classicMatchmakingBundleIds;
        }

        /// <summary>
        /// Gets or Sets ReferenceName
        /// </summary>
        [DataMember(Name = "referenceName", EmitDefaultValue = false)]
        public string ReferenceName { get; set; }

        /// <summary>
        /// Gets or Sets ClassicMatchmakingBundleIds
        /// </summary>
        [DataMember(Name = "classicMatchmakingBundleIds", EmitDefaultValue = false)]
        public List<string> ClassicMatchmakingBundleIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameCenterMatchmakingQueueAttributes {\n");
            sb.Append("  ReferenceName: ").Append(ReferenceName).Append("\n");
            sb.Append("  ClassicMatchmakingBundleIds: ").Append(ClassicMatchmakingBundleIds).Append("\n");
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
