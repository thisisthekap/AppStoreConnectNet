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
    /// AppAvailabilityV2CreateRequestDataRelationships
    /// </summary>
    [DataContract(Name = "AppAvailabilityV2CreateRequest_data_relationships")]
    public partial class AppAvailabilityV2CreateRequestDataRelationships : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequestDataRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppAvailabilityV2CreateRequestDataRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app">app (required).</param>
        /// <param name="territoryAvailabilities">territoryAvailabilities (required).</param>
        public AppAvailabilityV2CreateRequestDataRelationships(AnalyticsReportRequestCreateRequestDataRelationshipsApp app = default(AnalyticsReportRequestCreateRequestDataRelationshipsApp), AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities territoryAvailabilities = default(AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities))
        {
            // to ensure "app" is required (not null)
            if (app == null)
            {
                throw new ArgumentNullException("app is a required property for AppAvailabilityV2CreateRequestDataRelationships and cannot be null");
            }
            this.App = app;
            // to ensure "territoryAvailabilities" is required (not null)
            if (territoryAvailabilities == null)
            {
                throw new ArgumentNullException("territoryAvailabilities is a required property for AppAvailabilityV2CreateRequestDataRelationships and cannot be null");
            }
            this.TerritoryAvailabilities = territoryAvailabilities;
        }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name = "app", IsRequired = true, EmitDefaultValue = true)]
        public AnalyticsReportRequestCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        /// Gets or Sets TerritoryAvailabilities
        /// </summary>
        [DataMember(Name = "territoryAvailabilities", IsRequired = true, EmitDefaultValue = true)]
        public AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities TerritoryAvailabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppAvailabilityV2CreateRequestDataRelationships {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  TerritoryAvailabilities: ").Append(TerritoryAvailabilities).Append("\n");
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
