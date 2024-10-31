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
    /// AppEncryptionDeclarationBuildsLinkagesRequest
    /// </summary>
    [DataContract(Name = "AppEncryptionDeclarationBuildsLinkagesRequest")]
    public partial class AppEncryptionDeclarationBuildsLinkagesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationBuildsLinkagesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppEncryptionDeclarationBuildsLinkagesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEncryptionDeclarationBuildsLinkagesRequest" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        public AppEncryptionDeclarationBuildsLinkagesRequest(List<AppEncryptionDeclarationRelationshipsBuildsDataInner> data = default(List<AppEncryptionDeclarationRelationshipsBuildsDataInner>))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for AppEncryptionDeclarationBuildsLinkagesRequest and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public List<AppEncryptionDeclarationRelationshipsBuildsDataInner> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppEncryptionDeclarationBuildsLinkagesRequest {\n");
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
