/*
 * Regula Face SDK Web API
 *
 * <a href=\"https://regulaforensics.com/products/face-recognition-sdk/  \" target=\"_blank\">Regula Face SDK</a> is a cross-platform biometric verification solution for a digital identity verification process and image quality assurance. The SDK enables convenient and reliable face capture on the client side (mobile, web, and desktop) and further processing on the client or server side.   The Face SDK includes the following features:  * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#face-detection\" target=\"_blank\">Face detection and image quality assessment</a> * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#face-comparison-11\" target=\"_blank\">Face match (1:1)</a> * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#face-identification-1n\" target=\"_blank\">Face search (1:N)</a> * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#liveness-assessment\" target=\"_blank\">Liveness detection</a>  Here is the <a href=\"https://github.com/regulaforensics/FaceSDK-web-openapi  \" target=\"_blank\">OpenAPI specification on GitHub</a>.   ### Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 6.1.0
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
    /// MatchResponse
    /// </summary>
    [DataContract]
    public partial class MatchResponse :  IEquatable<MatchResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public FaceSDKResultCode Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchResponse" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="detections">The detection results..</param>
        /// <param name="results">The comparison results..</param>
        /// <param name="metadata">A free-form object containing person&#39;s extended attributes..</param>
        public MatchResponse(FaceSDKResultCode code = default(FaceSDKResultCode), List<MatchImageDetection> detections = default(List<MatchImageDetection>), List<MatchImageResult> results = default(List<MatchImageResult>), Dictionary<string, Object> metadata = default(Dictionary<string, Object>))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for MatchResponse and cannot be null");
            }
            else
            {
                this.Code = code;
            }

            this.Detections = detections;
            this.Results = results;
            this.Metadata = metadata;
        }


        /// <summary>
        /// The detection results.
        /// </summary>
        /// <value>The detection results.</value>
        [DataMember(Name="detections", EmitDefaultValue=false)]
        public List<MatchImageDetection> Detections { get; set; }

        /// <summary>
        /// The comparison results.
        /// </summary>
        /// <value>The comparison results.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<MatchImageResult> Results { get; set; }

        /// <summary>
        /// A free-form object containing person&#39;s extended attributes.
        /// </summary>
        /// <value>A free-form object containing person&#39;s extended attributes.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Detections: ").Append(Detections).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as MatchResponse);
        }

        /// <summary>
        /// Returns true if MatchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Detections == input.Detections ||
                    this.Detections != null &&
                    input.Detections != null &&
                    this.Detections.SequenceEqual(input.Detections)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Detections != null)
                    hashCode = hashCode * 59 + this.Detections.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
