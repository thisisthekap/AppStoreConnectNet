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
    /// AppStoreVersionExperimentTreatmentLocalizationRelationships
    /// </summary>
    [DataContract(Name = "AppStoreVersionExperimentTreatmentLocalization_relationships")]
    public partial class AppStoreVersionExperimentTreatmentLocalizationRelationships : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionExperimentTreatmentLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersionExperimentTreatment">appStoreVersionExperimentTreatment.</param>
        /// <param name="appScreenshotSets">appScreenshotSets.</param>
        /// <param name="appPreviewSets">appPreviewSets.</param>
        public AppStoreVersionExperimentTreatmentLocalizationRelationships(AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatment appStoreVersionExperimentTreatment = default(AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatment), AppCustomProductPageLocalizationRelationshipsAppScreenshotSets appScreenshotSets = default(AppCustomProductPageLocalizationRelationshipsAppScreenshotSets), AppCustomProductPageLocalizationRelationshipsAppPreviewSets appPreviewSets = default(AppCustomProductPageLocalizationRelationshipsAppPreviewSets))
        {
            this.AppStoreVersionExperimentTreatment = appStoreVersionExperimentTreatment;
            this.AppScreenshotSets = appScreenshotSets;
            this.AppPreviewSets = appPreviewSets;
        }

        /// <summary>
        /// Gets or Sets AppStoreVersionExperimentTreatment
        /// </summary>
        [DataMember(Name = "appStoreVersionExperimentTreatment", EmitDefaultValue = false)]
        public AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatment AppStoreVersionExperimentTreatment { get; set; }

        /// <summary>
        /// Gets or Sets AppScreenshotSets
        /// </summary>
        [DataMember(Name = "appScreenshotSets", EmitDefaultValue = false)]
        public AppCustomProductPageLocalizationRelationshipsAppScreenshotSets AppScreenshotSets { get; set; }

        /// <summary>
        /// Gets or Sets AppPreviewSets
        /// </summary>
        [DataMember(Name = "appPreviewSets", EmitDefaultValue = false)]
        public AppCustomProductPageLocalizationRelationshipsAppPreviewSets AppPreviewSets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppStoreVersionExperimentTreatmentLocalizationRelationships {\n");
            sb.Append("  AppStoreVersionExperimentTreatment: ").Append(AppStoreVersionExperimentTreatment).Append("\n");
            sb.Append("  AppScreenshotSets: ").Append(AppScreenshotSets).Append("\n");
            sb.Append("  AppPreviewSets: ").Append(AppPreviewSets).Append("\n");
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
