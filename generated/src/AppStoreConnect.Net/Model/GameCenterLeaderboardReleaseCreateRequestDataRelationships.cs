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
    /// GameCenterLeaderboardReleaseCreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "GameCenterLeaderboardReleaseCreateRequest_data_relationships")]
    public partial class GameCenterLeaderboardReleaseCreateRequestDataRelationships : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardReleaseCreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GameCenterLeaderboardReleaseCreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardReleaseCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail">gameCenterDetail (required).</param>
        /// <param name="gameCenterLeaderboard">gameCenterLeaderboard (required).</param>
        public GameCenterLeaderboardReleaseCreateRequestDataRelationships(GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterDetail gameCenterDetail = default(GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterDetail), GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard gameCenterLeaderboard = default(GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard))
        {
            // to ensure "gameCenterDetail" is required (not null)
            if (gameCenterDetail == null)
            {
                throw new ArgumentNullException("gameCenterDetail is a required property for GameCenterLeaderboardReleaseCreateRequestDataRelationships and cannot be null");
            }
            this.GameCenterDetail = gameCenterDetail;
            // to ensure "gameCenterLeaderboard" is required (not null)
            if (gameCenterLeaderboard == null)
            {
                throw new ArgumentNullException("gameCenterLeaderboard is a required property for GameCenterLeaderboardReleaseCreateRequestDataRelationships and cannot be null");
            }
            this.GameCenterLeaderboard = gameCenterLeaderboard;
        }

        /// <summary>
        /// Gets or Sets GameCenterDetail
        /// </summary>
        [DataMember(Name = "gameCenterDetail", IsRequired = true, EmitDefaultValue = true)]
        public GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterDetail GameCenterDetail { get; set; }

        /// <summary>
        /// Gets or Sets GameCenterLeaderboard
        /// </summary>
        [DataMember(Name = "gameCenterLeaderboard", IsRequired = true, EmitDefaultValue = true)]
        public GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard GameCenterLeaderboard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameCenterLeaderboardReleaseCreateRequestDataRelationships {\n");
            sb.Append("  GameCenterDetail: ").Append(GameCenterDetail).Append("\n");
            sb.Append("  GameCenterLeaderboard: ").Append(GameCenterLeaderboard).Append("\n");
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
