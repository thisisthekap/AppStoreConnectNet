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
    /// AppPreOrderAttributes
    /// </summary>
    [DataContract(Name = "AppPreOrder_attributes")]
    public partial class AppPreOrderAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreOrderAttributes" /> class.
        /// </summary>
        /// <param name="preOrderAvailableDate">preOrderAvailableDate.</param>
        /// <param name="appReleaseDate">appReleaseDate.</param>
        public AppPreOrderAttributes(DateOnly preOrderAvailableDate = default(DateOnly), DateOnly appReleaseDate = default(DateOnly))
        {
            this.PreOrderAvailableDate = preOrderAvailableDate;
            this.AppReleaseDate = appReleaseDate;
        }

        /// <summary>
        /// Gets or Sets PreOrderAvailableDate
        /// </summary>
        [DataMember(Name = "preOrderAvailableDate", EmitDefaultValue = false)]
        public DateOnly PreOrderAvailableDate { get; set; }

        /// <summary>
        /// Gets or Sets AppReleaseDate
        /// </summary>
        [DataMember(Name = "appReleaseDate", EmitDefaultValue = false)]
        public DateOnly AppReleaseDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppPreOrderAttributes {\n");
            sb.Append("  PreOrderAvailableDate: ").Append(PreOrderAvailableDate).Append("\n");
            sb.Append("  AppReleaseDate: ").Append(AppReleaseDate).Append("\n");
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
