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
    /// The processing parameters.
    /// </summary>
    [DataContract]
    public partial class ProcessParam :  IEquatable<ProcessParam>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Scenario
        /// </summary>
        [DataMember(Name="scenario", EmitDefaultValue=false)]
        public FaceQualityScenarios? Scenario { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessParam" /> class.
        /// </summary>
        /// <param name="scenario">scenario.</param>
        /// <param name="onlyCentralFace">Whether to process only the central face on the image (true) or all the faces (false)..</param>
        /// <param name="outputImageParams">outputImageParams.</param>
        /// <param name="quality">quality.</param>
        /// <param name="attributes">Whether to evaluate attributes, such as age and emotions. (default to false).</param>
        public ProcessParam(FaceQualityScenarios? scenario = default(FaceQualityScenarios?), bool onlyCentralFace = default(bool), OutputImageParams outputImageParams = default(OutputImageParams), QualityRequest quality = default(QualityRequest), bool attributes = false)
        {
            this.Scenario = scenario;
            this.OnlyCentralFace = onlyCentralFace;
            this.OutputImageParams = outputImageParams;
            this.Quality = quality;
            // use default value if no "attributes" provided
            if (attributes == null)
            {
                this.Attributes = false;
            }
            else
            {
                this.Attributes = attributes;
            }
        }


        /// <summary>
        /// Whether to process only the central face on the image (true) or all the faces (false).
        /// </summary>
        /// <value>Whether to process only the central face on the image (true) or all the faces (false).</value>
        [DataMember(Name="onlyCentralFace", EmitDefaultValue=false)]
        public bool OnlyCentralFace { get; set; }

        /// <summary>
        /// Gets or Sets OutputImageParams
        /// </summary>
        [DataMember(Name="outputImageParams", EmitDefaultValue=false)]
        public OutputImageParams OutputImageParams { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name="quality", EmitDefaultValue=false)]
        public QualityRequest Quality { get; set; }

        /// <summary>
        /// Whether to evaluate attributes, such as age and emotions.
        /// </summary>
        /// <value>Whether to evaluate attributes, such as age and emotions.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public bool Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessParam {\n");
            sb.Append("  Scenario: ").Append(Scenario).Append("\n");
            sb.Append("  OnlyCentralFace: ").Append(OnlyCentralFace).Append("\n");
            sb.Append("  OutputImageParams: ").Append(OutputImageParams).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as ProcessParam);
        }

        /// <summary>
        /// Returns true if ProcessParam instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Scenario == input.Scenario ||
                    (this.Scenario != null &&
                    this.Scenario.Equals(input.Scenario))
                ) && 
                (
                    this.OnlyCentralFace == input.OnlyCentralFace ||
                    (this.OnlyCentralFace != null &&
                    this.OnlyCentralFace.Equals(input.OnlyCentralFace))
                ) && 
                (
                    this.OutputImageParams == input.OutputImageParams ||
                    (this.OutputImageParams != null &&
                    this.OutputImageParams.Equals(input.OutputImageParams))
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
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
                if (this.Scenario != null)
                    hashCode = hashCode * 59 + this.Scenario.GetHashCode();
                if (this.OnlyCentralFace != null)
                    hashCode = hashCode * 59 + this.OnlyCentralFace.GetHashCode();
                if (this.OutputImageParams != null)
                    hashCode = hashCode * 59 + this.OutputImageParams.GetHashCode();
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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