/* 
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API
 *
 * The version of the OpenAPI document: 3.2.0
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
    /// DetectionQuality
    /// </summary>
    [DataContract]
    public partial class DetectionQuality :  IEquatable<DetectionQuality>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionQuality" /> class.
        /// </summary>
        /// <param name="aligned">aligned.</param>
        /// <param name="compliant">compliant.</param>
        /// <param name="details">details.</param>
        /// <param name="resized">resized.</param>
        /// <param name="score">score.</param>
        public DetectionQuality(bool aligned = default(bool), bool compliant = default(bool), List<QualityDetail> details = default(List<QualityDetail>), bool resized = default(bool), float score = default(float))
        {
            this.Aligned = aligned;
            this.Compliant = compliant;
            this.Details = details;
            this.Resized = resized;
            this.Score = score;
        }
        
        /// <summary>
        /// Gets or Sets Aligned
        /// </summary>
        [DataMember(Name="aligned", EmitDefaultValue=false)]
        public bool Aligned { get; set; }

        /// <summary>
        /// Gets or Sets Compliant
        /// </summary>
        [DataMember(Name="compliant", EmitDefaultValue=false)]
        public bool Compliant { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<QualityDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets Resized
        /// </summary>
        [DataMember(Name="resized", EmitDefaultValue=false)]
        public bool Resized { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public float Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectionQuality {\n");
            sb.Append("  Aligned: ").Append(Aligned).Append("\n");
            sb.Append("  Compliant: ").Append(Compliant).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Resized: ").Append(Resized).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectionQuality);
        }

        /// <summary>
        /// Returns true if DetectionQuality instances are equal
        /// </summary>
        /// <param name="input">Instance of DetectionQuality to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectionQuality input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aligned == input.Aligned ||
                    (this.Aligned != null &&
                    this.Aligned.Equals(input.Aligned))
                ) && 
                (
                    this.Compliant == input.Compliant ||
                    (this.Compliant != null &&
                    this.Compliant.Equals(input.Compliant))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Resized == input.Resized ||
                    (this.Resized != null &&
                    this.Resized.Equals(input.Resized))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
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
                if (this.Aligned != null)
                    hashCode = hashCode * 59 + this.Aligned.GetHashCode();
                if (this.Compliant != null)
                    hashCode = hashCode * 59 + this.Compliant.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Resized != null)
                    hashCode = hashCode * 59 + this.Resized.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
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
