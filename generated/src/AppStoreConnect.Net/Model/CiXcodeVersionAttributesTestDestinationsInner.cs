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
    /// CiXcodeVersionAttributesTestDestinationsInner
    /// </summary>
    [DataContract(Name = "CiXcodeVersion_attributes_testDestinations_inner")]
    public partial class CiXcodeVersionAttributesTestDestinationsInner : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public CiTestDestinationKind? Kind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CiXcodeVersionAttributesTestDestinationsInner" /> class.
        /// </summary>
        /// <param name="deviceTypeName">deviceTypeName.</param>
        /// <param name="deviceTypeIdentifier">deviceTypeIdentifier.</param>
        /// <param name="availableRuntimes">availableRuntimes.</param>
        /// <param name="kind">kind.</param>
        public CiXcodeVersionAttributesTestDestinationsInner(string deviceTypeName = default(string), string deviceTypeIdentifier = default(string), List<CiXcodeVersionAttributesTestDestinationsInnerAvailableRuntimesInner> availableRuntimes = default(List<CiXcodeVersionAttributesTestDestinationsInnerAvailableRuntimesInner>), CiTestDestinationKind? kind = default(CiTestDestinationKind?))
        {
            this.DeviceTypeName = deviceTypeName;
            this.DeviceTypeIdentifier = deviceTypeIdentifier;
            this.AvailableRuntimes = availableRuntimes;
            this.Kind = kind;
        }

        /// <summary>
        /// Gets or Sets DeviceTypeName
        /// </summary>
        [DataMember(Name = "deviceTypeName", EmitDefaultValue = false)]
        public string DeviceTypeName { get; set; }

        /// <summary>
        /// Gets or Sets DeviceTypeIdentifier
        /// </summary>
        [DataMember(Name = "deviceTypeIdentifier", EmitDefaultValue = false)]
        public string DeviceTypeIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets AvailableRuntimes
        /// </summary>
        [DataMember(Name = "availableRuntimes", EmitDefaultValue = false)]
        public List<CiXcodeVersionAttributesTestDestinationsInnerAvailableRuntimesInner> AvailableRuntimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiXcodeVersionAttributesTestDestinationsInner {\n");
            sb.Append("  DeviceTypeName: ").Append(DeviceTypeName).Append("\n");
            sb.Append("  DeviceTypeIdentifier: ").Append(DeviceTypeIdentifier).Append("\n");
            sb.Append("  AvailableRuntimes: ").Append(AvailableRuntimes).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
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
