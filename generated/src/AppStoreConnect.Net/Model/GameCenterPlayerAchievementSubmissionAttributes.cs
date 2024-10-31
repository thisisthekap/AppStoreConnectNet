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
    /// GameCenterPlayerAchievementSubmissionAttributes
    /// </summary>
    [DataContract(Name = "GameCenterPlayerAchievementSubmission_attributes")]
    public partial class GameCenterPlayerAchievementSubmissionAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterPlayerAchievementSubmissionAttributes" /> class.
        /// </summary>
        /// <param name="bundleId">bundleId.</param>
        /// <param name="challengeIds">challengeIds.</param>
        /// <param name="percentageAchieved">percentageAchieved.</param>
        /// <param name="scopedPlayerId">scopedPlayerId.</param>
        /// <param name="submittedDate">submittedDate.</param>
        /// <param name="vendorIdentifier">vendorIdentifier.</param>
        public GameCenterPlayerAchievementSubmissionAttributes(string bundleId = default(string), List<string> challengeIds = default(List<string>), int percentageAchieved = default(int), string scopedPlayerId = default(string), DateTimeOffset submittedDate = default(DateTimeOffset), string vendorIdentifier = default(string))
        {
            this.BundleId = bundleId;
            this.ChallengeIds = challengeIds;
            this.PercentageAchieved = percentageAchieved;
            this.ScopedPlayerId = scopedPlayerId;
            this.SubmittedDate = submittedDate;
            this.VendorIdentifier = vendorIdentifier;
        }

        /// <summary>
        /// Gets or Sets BundleId
        /// </summary>
        [DataMember(Name = "bundleId", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// Gets or Sets ChallengeIds
        /// </summary>
        [DataMember(Name = "challengeIds", EmitDefaultValue = false)]
        public List<string> ChallengeIds { get; set; }

        /// <summary>
        /// Gets or Sets PercentageAchieved
        /// </summary>
        [DataMember(Name = "percentageAchieved", EmitDefaultValue = false)]
        public int PercentageAchieved { get; set; }

        /// <summary>
        /// Gets or Sets ScopedPlayerId
        /// </summary>
        [DataMember(Name = "scopedPlayerId", EmitDefaultValue = false)]
        public string ScopedPlayerId { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedDate
        /// </summary>
        [DataMember(Name = "submittedDate", EmitDefaultValue = false)]
        public DateTimeOffset SubmittedDate { get; set; }

        /// <summary>
        /// Gets or Sets VendorIdentifier
        /// </summary>
        [DataMember(Name = "vendorIdentifier", EmitDefaultValue = false)]
        public string VendorIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameCenterPlayerAchievementSubmissionAttributes {\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  ChallengeIds: ").Append(ChallengeIds).Append("\n");
            sb.Append("  PercentageAchieved: ").Append(PercentageAchieved).Append("\n");
            sb.Append("  ScopedPlayerId: ").Append(ScopedPlayerId).Append("\n");
            sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
            sb.Append("  VendorIdentifier: ").Append(VendorIdentifier).Append("\n");
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
