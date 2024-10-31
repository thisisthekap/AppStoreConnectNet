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
    /// WinBackOfferUpdateRequestDataAttributes
    /// </summary>
    [DataContract(Name = "WinBackOfferUpdateRequest_data_attributes")]
    public partial class WinBackOfferUpdateRequestDataAttributes : IValidatableObject
    {
        /// <summary>
        /// Defines Priority
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            /// <summary>
            /// Enum HIGH for value: HIGH
            /// </summary>
            [EnumMember(Value = "HIGH")]
            HIGH = 1,

            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            [EnumMember(Value = "NORMAL")]
            NORMAL = 2
        }


        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Defines PromotionIntent
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PromotionIntentEnum
        {
            /// <summary>
            /// Enum NOTPROMOTED for value: NOT_PROMOTED
            /// </summary>
            [EnumMember(Value = "NOT_PROMOTED")]
            NOTPROMOTED = 1,

            /// <summary>
            /// Enum USEAUTOGENERATEDASSETS for value: USE_AUTO_GENERATED_ASSETS
            /// </summary>
            [EnumMember(Value = "USE_AUTO_GENERATED_ASSETS")]
            USEAUTOGENERATEDASSETS = 2
        }


        /// <summary>
        /// Gets or Sets PromotionIntent
        /// </summary>
        [DataMember(Name = "promotionIntent", EmitDefaultValue = false)]
        public PromotionIntentEnum? PromotionIntent { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WinBackOfferUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="customerEligibilityPaidSubscriptionDurationInMonths">customerEligibilityPaidSubscriptionDurationInMonths.</param>
        /// <param name="customerEligibilityTimeSinceLastSubscribedInMonths">customerEligibilityTimeSinceLastSubscribedInMonths.</param>
        /// <param name="customerEligibilityWaitBetweenOffersInMonths">customerEligibilityWaitBetweenOffersInMonths.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="priority">priority.</param>
        /// <param name="promotionIntent">promotionIntent.</param>
        public WinBackOfferUpdateRequestDataAttributes(int customerEligibilityPaidSubscriptionDurationInMonths = default(int), IntegerRange customerEligibilityTimeSinceLastSubscribedInMonths = default(IntegerRange), int customerEligibilityWaitBetweenOffersInMonths = default(int), DateOnly startDate = default(DateOnly), DateOnly endDate = default(DateOnly), PriorityEnum? priority = default(PriorityEnum?), PromotionIntentEnum? promotionIntent = default(PromotionIntentEnum?))
        {
            this.CustomerEligibilityPaidSubscriptionDurationInMonths = customerEligibilityPaidSubscriptionDurationInMonths;
            this.CustomerEligibilityTimeSinceLastSubscribedInMonths = customerEligibilityTimeSinceLastSubscribedInMonths;
            this.CustomerEligibilityWaitBetweenOffersInMonths = customerEligibilityWaitBetweenOffersInMonths;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Priority = priority;
            this.PromotionIntent = promotionIntent;
        }

        /// <summary>
        /// Gets or Sets CustomerEligibilityPaidSubscriptionDurationInMonths
        /// </summary>
        [DataMember(Name = "customerEligibilityPaidSubscriptionDurationInMonths", EmitDefaultValue = false)]
        public int CustomerEligibilityPaidSubscriptionDurationInMonths { get; set; }

        /// <summary>
        /// Gets or Sets CustomerEligibilityTimeSinceLastSubscribedInMonths
        /// </summary>
        [DataMember(Name = "customerEligibilityTimeSinceLastSubscribedInMonths", EmitDefaultValue = false)]
        public IntegerRange CustomerEligibilityTimeSinceLastSubscribedInMonths { get; set; }

        /// <summary>
        /// Gets or Sets CustomerEligibilityWaitBetweenOffersInMonths
        /// </summary>
        [DataMember(Name = "customerEligibilityWaitBetweenOffersInMonths", EmitDefaultValue = false)]
        public int CustomerEligibilityWaitBetweenOffersInMonths { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateOnly StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateOnly EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WinBackOfferUpdateRequestDataAttributes {\n");
            sb.Append("  CustomerEligibilityPaidSubscriptionDurationInMonths: ").Append(CustomerEligibilityPaidSubscriptionDurationInMonths).Append("\n");
            sb.Append("  CustomerEligibilityTimeSinceLastSubscribedInMonths: ").Append(CustomerEligibilityTimeSinceLastSubscribedInMonths).Append("\n");
            sb.Append("  CustomerEligibilityWaitBetweenOffersInMonths: ").Append(CustomerEligibilityWaitBetweenOffersInMonths).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  PromotionIntent: ").Append(PromotionIntent).Append("\n");
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
