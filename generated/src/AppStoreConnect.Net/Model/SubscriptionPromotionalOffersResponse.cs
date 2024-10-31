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
    /// SubscriptionPromotionalOffersResponse
    /// </summary>
    [DataContract(Name = "SubscriptionPromotionalOffersResponse")]
    public partial class SubscriptionPromotionalOffersResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOffersResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionPromotionalOffersResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPromotionalOffersResponse" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="included">included.</param>
        /// <param name="links">links (required).</param>
        /// <param name="meta">meta.</param>
        public SubscriptionPromotionalOffersResponse(List<SubscriptionPromotionalOffer> data = default(List<SubscriptionPromotionalOffer>), List<SubscriptionPromotionalOffersResponseIncludedInner> included = default(List<SubscriptionPromotionalOffersResponseIncludedInner>), PagedDocumentLinks links = default(PagedDocumentLinks), PagingInformation meta = default(PagingInformation))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for SubscriptionPromotionalOffersResponse and cannot be null");
            }
            this.Data = data;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for SubscriptionPromotionalOffersResponse and cannot be null");
            }
            this.Links = links;
            this.Included = included;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public List<SubscriptionPromotionalOffer> Data { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name = "included", EmitDefaultValue = false)]
        public List<SubscriptionPromotionalOffersResponseIncludedInner> Included { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public PagedDocumentLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public PagingInformation Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionPromotionalOffersResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
