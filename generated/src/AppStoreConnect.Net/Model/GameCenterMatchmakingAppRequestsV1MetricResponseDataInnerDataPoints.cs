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
    /// GameCenterMatchmakingAppRequestsV1MetricResponseDataInnerDataPoints
    /// </summary>
    [DataContract(Name = "GameCenterMatchmakingAppRequestsV1MetricResponse_data_inner_dataPoints")]
    public partial class GameCenterMatchmakingAppRequestsV1MetricResponseDataInnerDataPoints : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingAppRequestsV1MetricResponseDataInnerDataPoints" /> class.
        /// </summary>
        /// <param name="start">start.</param>
        /// <param name="end">end.</param>
        /// <param name="values">values.</param>
        public GameCenterMatchmakingAppRequestsV1MetricResponseDataInnerDataPoints(DateTimeOffset start = default(DateTimeOffset), DateTimeOffset end = default(DateTimeOffset), GameCenterMatchmakingAppRequestsV1MetricResponseDataInnerDataPointsValues values = default(GameCenterMatchmakingAppRequestsV1MetricResponseDataInnerDataPointsValues))
        {
            this.Start = start;
            this.End = end;
            this.Values = values;
        }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public DateTimeOffset Start { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public DateTimeOffset End { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public GameCenterMatchmakingAppRequestsV1MetricResponseDataInnerDataPointsValues Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GameCenterMatchmakingAppRequestsV1MetricResponseDataInnerDataPoints {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
