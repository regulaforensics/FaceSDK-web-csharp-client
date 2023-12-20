/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
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
    /// MatchAndSearchResponseAllOfDetections
    /// </summary>
    [DataContract]
    public partial class MatchAndSearchResponseAllOfDetections :  IEquatable<MatchAndSearchResponseAllOfDetections>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public FaceSDKResultCode? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchAndSearchResponseAllOfDetections" /> class.
        /// </summary>
        /// <param name="faces">faces.</param>
        /// <param name="imageIndex">The image index number. Can be given; if not given, the index numbers are set automatically starting from 0. All index numbers must be whole and unique—not repeated..</param>
        /// <param name="status">status.</param>
        public MatchAndSearchResponseAllOfDetections(List<FacesResponse> faces = default(List<FacesResponse>), int imageIndex = default(int), FaceSDKResultCode? status = default(FaceSDKResultCode?))
        {
            this.Faces = faces;
            this.ImageIndex = imageIndex;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Faces
        /// </summary>
        [DataMember(Name="faces", EmitDefaultValue=false)]
        public List<FacesResponse> Faces { get; set; }

        /// <summary>
        /// The image index number. Can be given; if not given, the index numbers are set automatically starting from 0. All index numbers must be whole and unique—not repeated.
        /// </summary>
        /// <value>The image index number. Can be given; if not given, the index numbers are set automatically starting from 0. All index numbers must be whole and unique—not repeated.</value>
        [DataMember(Name="imageIndex", EmitDefaultValue=false)]
        public int ImageIndex { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchAndSearchResponseAllOfDetections {\n");
            sb.Append("  Faces: ").Append(Faces).Append("\n");
            sb.Append("  ImageIndex: ").Append(ImageIndex).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as MatchAndSearchResponseAllOfDetections);
        }

        /// <summary>
        /// Returns true if MatchAndSearchResponseAllOfDetections instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchAndSearchResponseAllOfDetections to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchAndSearchResponseAllOfDetections input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Faces == input.Faces ||
                    this.Faces != null &&
                    input.Faces != null &&
                    this.Faces.SequenceEqual(input.Faces)
                ) && 
                (
                    this.ImageIndex == input.ImageIndex ||
                    (this.ImageIndex != null &&
                    this.ImageIndex.Equals(input.ImageIndex))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Faces != null)
                    hashCode = hashCode * 59 + this.Faces.GetHashCode();
                if (this.ImageIndex != null)
                    hashCode = hashCode * 59 + this.ImageIndex.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
