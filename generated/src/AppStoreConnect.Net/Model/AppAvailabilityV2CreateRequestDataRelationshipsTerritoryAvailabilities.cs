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
    /// AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities
    /// </summary>
    [DataContract(Name = "AppAvailabilityV2CreateRequest_data_relationships_territoryAvailabilities")]
    public partial class AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        public AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities(List<AppAvailabilityV2RelationshipsTerritoryAvailabilitiesDataInner> data = default(List<AppAvailabilityV2RelationshipsTerritoryAvailabilitiesDataInner>))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public List<AppAvailabilityV2RelationshipsTerritoryAvailabilitiesDataInner> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppAvailabilityV2CreateRequestDataRelationshipsTerritoryAvailabilities {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
