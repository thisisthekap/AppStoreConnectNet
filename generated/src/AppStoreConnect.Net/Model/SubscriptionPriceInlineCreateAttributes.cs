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
    /// SubscriptionPriceInlineCreateAttributes
    /// </summary>
    [DataContract(Name = "SubscriptionPriceInlineCreate_attributes")]
    public partial class SubscriptionPriceInlineCreateAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="startDate">startDate.</param>
        /// <param name="preserveCurrentPrice">preserveCurrentPrice.</param>
        public SubscriptionPriceInlineCreateAttributes(DateOnly startDate = default(DateOnly), bool preserveCurrentPrice = default(bool))
        {
            this.StartDate = startDate;
            this.PreserveCurrentPrice = preserveCurrentPrice;
        }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateOnly StartDate { get; set; }

        /// <summary>
        /// Gets or Sets PreserveCurrentPrice
        /// </summary>
        [DataMember(Name = "preserveCurrentPrice", EmitDefaultValue = true)]
        public bool PreserveCurrentPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionPriceInlineCreateAttributes {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  PreserveCurrentPrice: ").Append(PreserveCurrentPrice).Append("\n");
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
