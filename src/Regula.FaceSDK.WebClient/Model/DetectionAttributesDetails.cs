/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 5.2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Regula.FaceSDK.WebClient.Client.OpenAPIDateConverter;

namespace Regula.FaceSDK.WebClient.Model
{
    /// <summary>
    /// DetectionAttributesDetails
    /// </summary>
    [DataContract]
    public partial class DetectionAttributesDetails :  IEquatable<DetectionAttributesDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionAttributesDetails" /> class.
        /// </summary>
        /// <param name="name">The name of the attribute..</param>
        /// <param name="confidence">The confidence score for the attribute..</param>
        /// <param name="value">Value..</param>
        public DetectionAttributesDetails(string name = default(string), decimal confidence = default(decimal), Any value = default(Any))
        {
            this.Name = name;
            this.Confidence = confidence;
            this.Value = value;
        }

        /// <summary>
        /// The name of the attribute.
        /// </summary>
        /// <value>The name of the attribute.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The confidence score for the attribute.
        /// </summary>
        /// <value>The confidence score for the attribute.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public decimal Confidence { get; set; }

        /// <summary>
        /// Value.
        /// </summary>
        /// <value>Value.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Any Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectionAttributesDetails {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectionAttributesDetails);
        }

        /// <summary>
        /// Returns true if DetectionAttributesDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DetectionAttributesDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectionAttributesDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
