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
    /// ReviewSubmissionRelationships
    /// </summary>
    [DataContract(Name = "ReviewSubmission_relationships")]
    public partial class ReviewSubmissionRelationships : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionRelationships" /> class.
        /// </summary>
        /// <param name="app">app.</param>
        /// <param name="items">items.</param>
        /// <param name="appStoreVersionForReview">appStoreVersionForReview.</param>
        /// <param name="submittedByActor">submittedByActor.</param>
        /// <param name="lastUpdatedByActor">lastUpdatedByActor.</param>
        public ReviewSubmissionRelationships(AlternativeDistributionKeyCreateRequestDataRelationshipsApp app = default(AlternativeDistributionKeyCreateRequestDataRelationshipsApp), ReviewSubmissionRelationshipsItems items = default(ReviewSubmissionRelationshipsItems), AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion appStoreVersionForReview = default(AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion), ReviewSubmissionRelationshipsSubmittedByActor submittedByActor = default(ReviewSubmissionRelationshipsSubmittedByActor), ReviewSubmissionRelationshipsSubmittedByActor lastUpdatedByActor = default(ReviewSubmissionRelationshipsSubmittedByActor))
        {
            this.App = app;
            this.Items = items;
            this.AppStoreVersionForReview = appStoreVersionForReview;
            this.SubmittedByActor = submittedByActor;
            this.LastUpdatedByActor = lastUpdatedByActor;
        }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", EmitDefaultValue = false)]
        public AlternativeDistributionKeyCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public ReviewSubmissionRelationshipsItems Items { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreVersionForReview
        /// </summary>
        [DataMember(Name = "appStoreVersionForReview", EmitDefaultValue = false)]
        public AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion AppStoreVersionForReview { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedByActor
        /// </summary>
        [DataMember(Name = "submittedByActor", EmitDefaultValue = false)]
        public ReviewSubmissionRelationshipsSubmittedByActor SubmittedByActor { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedByActor
        /// </summary>
        [DataMember(Name = "lastUpdatedByActor", EmitDefaultValue = false)]
        public ReviewSubmissionRelationshipsSubmittedByActor LastUpdatedByActor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReviewSubmissionRelationships {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  AppStoreVersionForReview: ").Append(AppStoreVersionForReview).Append("\n");
            sb.Append("  SubmittedByActor: ").Append(SubmittedByActor).Append("\n");
            sb.Append("  LastUpdatedByActor: ").Append(LastUpdatedByActor).Append("\n");
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
