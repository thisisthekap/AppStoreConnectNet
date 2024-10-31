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
    /// SubscriptionAvailabilityRelationships
    /// </summary>
    [DataContract(Name = "SubscriptionAvailability_relationships")]
    public partial class SubscriptionAvailabilityRelationships : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAvailabilityRelationships" /> class.
        /// </summary>
        /// <param name="subscription">subscription.</param>
        /// <param name="availableTerritories">availableTerritories.</param>
        public SubscriptionAvailabilityRelationships(PromotedPurchaseRelationshipsSubscription subscription = default(PromotedPurchaseRelationshipsSubscription), AppAvailabilityRelationshipsAvailableTerritories availableTerritories = default(AppAvailabilityRelationshipsAvailableTerritories))
        {
            this.Subscription = subscription;
            this.AvailableTerritories = availableTerritories;
        }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public PromotedPurchaseRelationshipsSubscription Subscription { get; set; }

        /// <summary>
        /// Gets or Sets AvailableTerritories
        /// </summary>
        [DataMember(Name = "availableTerritories", EmitDefaultValue = false)]
        public AppAvailabilityRelationshipsAvailableTerritories AvailableTerritories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionAvailabilityRelationships {\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  AvailableTerritories: ").Append(AvailableTerritories).Append("\n");
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
