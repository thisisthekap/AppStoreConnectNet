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
    /// AppCustomProductPageVersionRelationships
    /// </summary>
    [DataContract(Name = "AppCustomProductPageVersion_relationships")]
    public partial class AppCustomProductPageVersionRelationships : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionRelationships" /> class.
        /// </summary>
        /// <param name="appCustomProductPage">appCustomProductPage.</param>
        /// <param name="appCustomProductPageLocalizations">appCustomProductPageLocalizations.</param>
        public AppCustomProductPageVersionRelationships(AppCustomProductPageVersionRelationshipsAppCustomProductPage appCustomProductPage = default(AppCustomProductPageVersionRelationshipsAppCustomProductPage), AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizations appCustomProductPageLocalizations = default(AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizations))
        {
            this.AppCustomProductPage = appCustomProductPage;
            this.AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
        }

        /// <summary>
        /// Gets or Sets AppCustomProductPage
        /// </summary>
        [DataMember(Name = "appCustomProductPage", EmitDefaultValue = false)]
        public AppCustomProductPageVersionRelationshipsAppCustomProductPage AppCustomProductPage { get; set; }

        /// <summary>
        /// Gets or Sets AppCustomProductPageLocalizations
        /// </summary>
        [DataMember(Name = "appCustomProductPageLocalizations", EmitDefaultValue = false)]
        public AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizations AppCustomProductPageLocalizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppCustomProductPageVersionRelationships {\n");
            sb.Append("  AppCustomProductPage: ").Append(AppCustomProductPage).Append("\n");
            sb.Append("  AppCustomProductPageLocalizations: ").Append(AppCustomProductPageLocalizations).Append("\n");
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
