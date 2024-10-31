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
    /// GameCenterGroupRelationships
    /// </summary>
    [DataContract(Name = "GameCenterGroup_relationships")]
    public partial class GameCenterGroupRelationships : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterGroupRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetails">gameCenterDetails.</param>
        /// <param name="gameCenterLeaderboards">gameCenterLeaderboards.</param>
        /// <param name="gameCenterLeaderboardSets">gameCenterLeaderboardSets.</param>
        /// <param name="gameCenterAchievements">gameCenterAchievements.</param>
        public GameCenterGroupRelationships(GameCenterGroupRelationshipsGameCenterDetails gameCenterDetails = default(GameCenterGroupRelationshipsGameCenterDetails), GameCenterDetailRelationshipsGameCenterLeaderboards gameCenterLeaderboards = default(GameCenterDetailRelationshipsGameCenterLeaderboards), GameCenterDetailRelationshipsGameCenterLeaderboardSets gameCenterLeaderboardSets = default(GameCenterDetailRelationshipsGameCenterLeaderboardSets), GameCenterDetailRelationshipsGameCenterAchievements gameCenterAchievements = default(GameCenterDetailRelationshipsGameCenterAchievements))
        {
            this.GameCenterDetails = gameCenterDetails;
            this.GameCenterLeaderboards = gameCenterLeaderboards;
            this.GameCenterLeaderboardSets = gameCenterLeaderboardSets;
            this.GameCenterAchievements = gameCenterAchievements;
        }

        /// <summary>
        /// Gets or Sets GameCenterDetails
        /// </summary>
        [DataMember(Name = "gameCenterDetails", EmitDefaultValue = false)]
        public GameCenterGroupRelationshipsGameCenterDetails GameCenterDetails { get; set; }

        /// <summary>
        /// Gets or Sets GameCenterLeaderboards
        /// </summary>
        [DataMember(Name = "gameCenterLeaderboards", EmitDefaultValue = false)]
        public GameCenterDetailRelationshipsGameCenterLeaderboards GameCenterLeaderboards { get; set; }

        /// <summary>
        /// Gets or Sets GameCenterLeaderboardSets
        /// </summary>
        [DataMember(Name = "gameCenterLeaderboardSets", EmitDefaultValue = false)]
        public GameCenterDetailRelationshipsGameCenterLeaderboardSets GameCenterLeaderboardSets { get; set; }

        /// <summary>
        /// Gets or Sets GameCenterAchievements
        /// </summary>
        [DataMember(Name = "gameCenterAchievements", EmitDefaultValue = false)]
        public GameCenterDetailRelationshipsGameCenterAchievements GameCenterAchievements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameCenterGroupRelationships {\n");
            sb.Append("  GameCenterDetails: ").Append(GameCenterDetails).Append("\n");
            sb.Append("  GameCenterLeaderboards: ").Append(GameCenterLeaderboards).Append("\n");
            sb.Append("  GameCenterLeaderboardSets: ").Append(GameCenterLeaderboardSets).Append("\n");
            sb.Append("  GameCenterAchievements: ").Append(GameCenterAchievements).Append("\n");
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
