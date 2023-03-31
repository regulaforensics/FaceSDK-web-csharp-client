/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 5.1.0
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
    /// The configuration that defines the list of returned quality check characteristics. For every characteristic, includes name, range, unit.
    /// </summary>
    [DataContract]
    public partial class QualityConfig :  IEquatable<QualityConfig>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public FaceQualityConfigName? Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityConfig" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="range">The range of applicable values for this characteristic. If the returned in the Response value fits this range, the value is identified as compliant with the requirements..</param>
        public QualityConfig(FaceQualityConfigName? name = default(FaceQualityConfigName?), List<float> range = default(List<float>))
        {
            this.Name = name;
            this.Range = range;
        }


        /// <summary>
        /// The range of applicable values for this characteristic. If the returned in the Response value fits this range, the value is identified as compliant with the requirements.
        /// </summary>
        /// <value>The range of applicable values for this characteristic. If the returned in the Response value fits this range, the value is identified as compliant with the requirements.</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public List<float> Range { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityConfig {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(input as QualityConfig);
        }

        /// <summary>
        /// Returns true if QualityConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of QualityConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityConfig input)
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
                    this.Range == input.Range ||
                    this.Range != null &&
                    input.Range != null &&
                    this.Range.SequenceEqual(input.Range)
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
                if (this.Range != null)
                    hashCode = hashCode * 59 + this.Range.GetHashCode();
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
