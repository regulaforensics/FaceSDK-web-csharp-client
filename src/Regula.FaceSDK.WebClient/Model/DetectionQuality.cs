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
    /// Field for checking the portrait quality. If it is not mentioned, no quality check is performed.
    /// </summary>
    [DataContract]
    public partial class DetectionQuality :  IEquatable<DetectionQuality>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionQuality" /> class.
        /// </summary>
        /// <param name="nonCompliant">The array of all the non-compliant assessment characteristics..</param>
        /// <param name="detailsGroups">The array of the assessment results for each group of characteristics. Includes groupId, name, total, compliantCount..</param>
        /// <param name="details">The array of the assessment characteristics that were set in the request. Includes name, range, status, unit, value..</param>
        /// <param name="score">Returns the estimated portrait quality assessment result, a number from 0 to 1, where 1 is for absolute compliance..</param>
        /// <param name="timer">timer.</param>
        public DetectionQuality(List<FaceQualityConfigName> nonCompliant = default(List<FaceQualityConfigName>), List<QualityDetailsGroups> detailsGroups = default(List<QualityDetailsGroups>), List<QualityDetail> details = default(List<QualityDetail>), float score = default(float), float timer = default(float))
        {
            this.NonCompliant = nonCompliant;
            this.DetailsGroups = detailsGroups;
            this.Details = details;
            this.Score = score;
            this.Timer = timer;
        }
        
        /// <summary>
        /// The array of all the non-compliant assessment characteristics.
        /// </summary>
        /// <value>The array of all the non-compliant assessment characteristics.</value>
        [DataMember(Name="nonCompliant", EmitDefaultValue=false)]
        public List<FaceQualityConfigName> NonCompliant { get; set; }

        /// <summary>
        /// The array of the assessment results for each group of characteristics. Includes groupId, name, total, compliantCount.
        /// </summary>
        /// <value>The array of the assessment results for each group of characteristics. Includes groupId, name, total, compliantCount.</value>
        [DataMember(Name="detailsGroups", EmitDefaultValue=false)]
        public List<QualityDetailsGroups> DetailsGroups { get; set; }

        /// <summary>
        /// The array of the assessment characteristics that were set in the request. Includes name, range, status, unit, value.
        /// </summary>
        /// <value>The array of the assessment characteristics that were set in the request. Includes name, range, status, unit, value.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<QualityDetail> Details { get; set; }

        /// <summary>
        /// Returns the estimated portrait quality assessment result, a number from 0 to 1, where 1 is for absolute compliance.
        /// </summary>
        /// <value>Returns the estimated portrait quality assessment result, a number from 0 to 1, where 1 is for absolute compliance.</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public float Score { get; set; }

        /// <summary>
        /// Gets or Sets Timer
        /// </summary>
        [DataMember(Name="timer", EmitDefaultValue=false)]
        public float Timer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectionQuality {\n");
            sb.Append("  NonCompliant: ").Append(NonCompliant).Append("\n");
            sb.Append("  DetailsGroups: ").Append(DetailsGroups).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Timer: ").Append(Timer).Append("\n");
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
                    this.NonCompliant == input.NonCompliant ||
                    this.NonCompliant != null &&
                    input.NonCompliant != null &&
                    this.NonCompliant.SequenceEqual(input.NonCompliant)
                ) && 
                (
                    this.DetailsGroups == input.DetailsGroups ||
                    this.DetailsGroups != null &&
                    input.DetailsGroups != null &&
                    this.DetailsGroups.SequenceEqual(input.DetailsGroups)
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.Timer == input.Timer ||
                    (this.Timer != null &&
                    this.Timer.Equals(input.Timer))
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
                if (this.NonCompliant != null)
                    hashCode = hashCode * 59 + this.NonCompliant.GetHashCode();
                if (this.DetailsGroups != null)
                    hashCode = hashCode * 59 + this.DetailsGroups.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Timer != null)
                    hashCode = hashCode * 59 + this.Timer.GetHashCode();
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
