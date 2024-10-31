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
    /// GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes
    /// </summary>
    [DataContract(Name = "GameCenterMatchmakingTestPlayerPropertyInlineCreate_attributes")]
    public partial class GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="playerId">playerId (required).</param>
        /// <param name="properties">properties.</param>
        public GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes(string playerId = default(string), List<Property> properties = default(List<Property>))
        {
            // to ensure "playerId" is required (not null)
            if (playerId == null)
            {
                throw new ArgumentNullException("playerId is a required property for GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes and cannot be null");
            }
            this.PlayerId = playerId;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets PlayerId
        /// </summary>
        [DataMember(Name = "playerId", IsRequired = true, EmitDefaultValue = true)]
        public string PlayerId { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes {\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
