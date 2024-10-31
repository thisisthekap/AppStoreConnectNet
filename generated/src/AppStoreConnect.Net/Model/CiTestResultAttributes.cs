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
    /// CiTestResultAttributes
    /// </summary>
    [DataContract(Name = "CiTestResult_attributes")]
    public partial class CiTestResultAttributes : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public CiTestStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CiTestResultAttributes" /> class.
        /// </summary>
        /// <param name="className">className.</param>
        /// <param name="name">name.</param>
        /// <param name="status">status.</param>
        /// <param name="fileSource">fileSource.</param>
        /// <param name="message">message.</param>
        /// <param name="destinationTestResults">destinationTestResults.</param>
        public CiTestResultAttributes(string className = default(string), string name = default(string), CiTestStatus? status = default(CiTestStatus?), FileLocation fileSource = default(FileLocation), string message = default(string), List<CiTestResultAttributesDestinationTestResultsInner> destinationTestResults = default(List<CiTestResultAttributesDestinationTestResultsInner>))
        {
            this.ClassName = className;
            this.Name = name;
            this.Status = status;
            this.FileSource = fileSource;
            this.Message = message;
            this.DestinationTestResults = destinationTestResults;
        }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name = "className", EmitDefaultValue = false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FileSource
        /// </summary>
        [DataMember(Name = "fileSource", EmitDefaultValue = false)]
        public FileLocation FileSource { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets DestinationTestResults
        /// </summary>
        [DataMember(Name = "destinationTestResults", EmitDefaultValue = false)]
        public List<CiTestResultAttributesDestinationTestResultsInner> DestinationTestResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CiTestResultAttributes {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FileSource: ").Append(FileSource).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  DestinationTestResults: ").Append(DestinationTestResults).Append("\n");
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
