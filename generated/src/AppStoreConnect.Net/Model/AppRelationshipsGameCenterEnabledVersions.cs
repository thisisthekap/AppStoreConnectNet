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
    /// AppRelationshipsGameCenterEnabledVersions
    /// </summary>
    [DataContract(Name = "App_relationships_gameCenterEnabledVersions")]
    public partial class AppRelationshipsGameCenterEnabledVersions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppRelationshipsGameCenterEnabledVersions" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        /// <param name="data">data.</param>
        public AppRelationshipsGameCenterEnabledVersions(RelationshipLinks links = default(RelationshipLinks), PagingInformation meta = default(PagingInformation), List<AppRelationshipsGameCenterEnabledVersionsDataInner> data = default(List<AppRelationshipsGameCenterEnabledVersionsDataInner>))
        {
            this.Links = links;
            this.Meta = meta;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public RelationshipLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public PagingInformation Meta { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<AppRelationshipsGameCenterEnabledVersionsDataInner> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppRelationshipsGameCenterEnabledVersions {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
