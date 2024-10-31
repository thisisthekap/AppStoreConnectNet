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
    /// BetaBuildUsagesV1MetricResponseDataInnerDataPointsValues
    /// </summary>
    [DataContract(Name = "BetaBuildUsagesV1MetricResponse_data_inner_dataPoints_values")]
    public partial class BetaBuildUsagesV1MetricResponseDataInnerDataPointsValues : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildUsagesV1MetricResponseDataInnerDataPointsValues" /> class.
        /// </summary>
        /// <param name="crashCount">crashCount.</param>
        /// <param name="installCount">installCount.</param>
        /// <param name="sessionCount">sessionCount.</param>
        /// <param name="feedbackCount">feedbackCount.</param>
        /// <param name="inviteCount">inviteCount.</param>
        public BetaBuildUsagesV1MetricResponseDataInnerDataPointsValues(int crashCount = default(int), int installCount = default(int), int sessionCount = default(int), int feedbackCount = default(int), int inviteCount = default(int))
        {
            this.CrashCount = crashCount;
            this.InstallCount = installCount;
            this.SessionCount = sessionCount;
            this.FeedbackCount = feedbackCount;
            this.InviteCount = inviteCount;
        }

        /// <summary>
        /// Gets or Sets CrashCount
        /// </summary>
        [DataMember(Name = "crashCount", EmitDefaultValue = false)]
        public int CrashCount { get; set; }

        /// <summary>
        /// Gets or Sets InstallCount
        /// </summary>
        [DataMember(Name = "installCount", EmitDefaultValue = false)]
        public int InstallCount { get; set; }

        /// <summary>
        /// Gets or Sets SessionCount
        /// </summary>
        [DataMember(Name = "sessionCount", EmitDefaultValue = false)]
        public int SessionCount { get; set; }

        /// <summary>
        /// Gets or Sets FeedbackCount
        /// </summary>
        [DataMember(Name = "feedbackCount", EmitDefaultValue = false)]
        public int FeedbackCount { get; set; }

        /// <summary>
        /// Gets or Sets InviteCount
        /// </summary>
        [DataMember(Name = "inviteCount", EmitDefaultValue = false)]
        public int InviteCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BetaBuildUsagesV1MetricResponseDataInnerDataPointsValues {\n");
            sb.Append("  CrashCount: ").Append(CrashCount).Append("\n");
            sb.Append("  InstallCount: ").Append(InstallCount).Append("\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  FeedbackCount: ").Append(FeedbackCount).Append("\n");
            sb.Append("  InviteCount: ").Append(InviteCount).Append("\n");
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
