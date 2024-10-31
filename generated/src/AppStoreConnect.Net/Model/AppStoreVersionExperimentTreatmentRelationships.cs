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
    /// AppStoreVersionExperimentTreatmentRelationships
    /// </summary>
    [DataContract(Name = "AppStoreVersionExperimentTreatment_relationships")]
    public partial class AppStoreVersionExperimentTreatmentRelationships : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionExperiment">appStoreVersionExperiment.</param>
        /// <param name="appStoreVersionExperimentV2">appStoreVersionExperimentV2.</param>
        /// <param name="appStoreVersionExperimentTreatmentLocalizations">appStoreVersionExperimentTreatmentLocalizations.</param>
        public AppStoreVersionExperimentTreatmentRelationships(AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment appStoreVersionExperiment = default(AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment), AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment appStoreVersionExperimentV2 = default(AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment), AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizations appStoreVersionExperimentTreatmentLocalizations = default(AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizations))
        {
            this.AppStoreVersionExperiment = appStoreVersionExperiment;
            this.AppStoreVersionExperimentV2 = appStoreVersionExperimentV2;
            this.AppStoreVersionExperimentTreatmentLocalizations = appStoreVersionExperimentTreatmentLocalizations;
        }

        /// <summary>
        /// Gets or Sets AppStoreVersionExperiment
        /// </summary>
        [DataMember(Name = "appStoreVersionExperiment", EmitDefaultValue = false)]
        public AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment AppStoreVersionExperiment { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreVersionExperimentV2
        /// </summary>
        [DataMember(Name = "appStoreVersionExperimentV2", EmitDefaultValue = false)]
        public AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperiment AppStoreVersionExperimentV2 { get; set; }

        /// <summary>
        /// Gets or Sets AppStoreVersionExperimentTreatmentLocalizations
        /// </summary>
        [DataMember(Name = "appStoreVersionExperimentTreatmentLocalizations", EmitDefaultValue = false)]
        public AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentTreatmentLocalizations AppStoreVersionExperimentTreatmentLocalizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreVersionExperimentTreatmentRelationships {\n");
            sb.Append("  AppStoreVersionExperiment: ").Append(AppStoreVersionExperiment).Append("\n");
            sb.Append("  AppStoreVersionExperimentV2: ").Append(AppStoreVersionExperimentV2).Append("\n");
            sb.Append("  AppStoreVersionExperimentTreatmentLocalizations: ").Append(AppStoreVersionExperimentTreatmentLocalizations).Append("\n");
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
