/*
 * Regula FaceSDK Web api
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
    /// FacesResponse
    /// </summary>
    [DataContract]
    public partial class FacesResponse :  IEquatable<FacesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacesResponse" /> class.
        /// </summary>
        /// <param name="faceIndex">The detected face index number..</param>
        /// <param name="landmarks">Absolute coordinates (x,y) of five points of each detected face: left eye, right eye, nose, left point of lips, right point of lips..</param>
        /// <param name="rotationAngle">rotationAngle.</param>
        /// <param name="roi">The rectangular area of a detected face that is represented by a set of four elements: the X and Y coordinates of the top-left point, and the width and height dimensions of the rectangle..</param>
        /// <param name="thumbnail">Base64 of the cropped portrait..</param>
        /// <param name="persons">persons.</param>
        public FacesResponse(decimal faceIndex = default(decimal), List<List<decimal>> landmarks = default(List<List<decimal>>), float rotationAngle = default(float), List<decimal> roi = default(List<decimal>), byte[] thumbnail = default(byte[]), List<PersonWithImages> persons = default(List<PersonWithImages>))
        {
            this.FaceIndex = faceIndex;
            this.Landmarks = landmarks;
            this.RotationAngle = rotationAngle;
            this.Roi = roi;
            this.Thumbnail = thumbnail;
            this.Persons = persons;
        }

        /// <summary>
        /// The detected face index number.
        /// </summary>
        /// <value>The detected face index number.</value>
        [DataMember(Name="faceIndex", EmitDefaultValue=false)]
        public decimal FaceIndex { get; set; }

        /// <summary>
        /// Absolute coordinates (x,y) of five points of each detected face: left eye, right eye, nose, left point of lips, right point of lips.
        /// </summary>
        /// <value>Absolute coordinates (x,y) of five points of each detected face: left eye, right eye, nose, left point of lips, right point of lips.</value>
        [DataMember(Name="landmarks", EmitDefaultValue=false)]
        public List<List<decimal>> Landmarks { get; set; }

        /// <summary>
        /// Gets or Sets RotationAngle
        /// </summary>
        [DataMember(Name="rotationAngle", EmitDefaultValue=false)]
        public float RotationAngle { get; set; }

        /// <summary>
        /// The rectangular area of a detected face that is represented by a set of four elements: the X and Y coordinates of the top-left point, and the width and height dimensions of the rectangle.
        /// </summary>
        /// <value>The rectangular area of a detected face that is represented by a set of four elements: the X and Y coordinates of the top-left point, and the width and height dimensions of the rectangle.</value>
        [DataMember(Name="roi", EmitDefaultValue=false)]
        public List<decimal> Roi { get; set; }

        /// <summary>
        /// Base64 of the cropped portrait.
        /// </summary>
        /// <value>Base64 of the cropped portrait.</value>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public byte[] Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Persons
        /// </summary>
        [DataMember(Name="persons", EmitDefaultValue=false)]
        public List<PersonWithImages> Persons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacesResponse {\n");
            sb.Append("  FaceIndex: ").Append(FaceIndex).Append("\n");
            sb.Append("  Landmarks: ").Append(Landmarks).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
            sb.Append("  Roi: ").Append(Roi).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
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
            return this.Equals(input as FacesResponse);
        }

        /// <summary>
        /// Returns true if FacesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FacesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaceIndex == input.FaceIndex ||
                    (this.FaceIndex != null &&
                    this.FaceIndex.Equals(input.FaceIndex))
                ) && 
                (
                    this.Landmarks == input.Landmarks ||
                    this.Landmarks != null &&
                    input.Landmarks != null &&
                    this.Landmarks.SequenceEqual(input.Landmarks)
                ) && 
                (
                    this.RotationAngle == input.RotationAngle ||
                    (this.RotationAngle != null &&
                    this.RotationAngle.Equals(input.RotationAngle))
                ) && 
                (
                    this.Roi == input.Roi ||
                    this.Roi != null &&
                    input.Roi != null &&
                    this.Roi.SequenceEqual(input.Roi)
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.Persons == input.Persons ||
                    this.Persons != null &&
                    input.Persons != null &&
                    this.Persons.SequenceEqual(input.Persons)
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
                if (this.FaceIndex != null)
                    hashCode = hashCode * 59 + this.FaceIndex.GetHashCode();
                if (this.Landmarks != null)
                    hashCode = hashCode * 59 + this.Landmarks.GetHashCode();
                if (this.RotationAngle != null)
                    hashCode = hashCode * 59 + this.RotationAngle.GetHashCode();
                if (this.Roi != null)
                    hashCode = hashCode * 59 + this.Roi.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.Persons != null)
                    hashCode = hashCode * 59 + this.Persons.GetHashCode();
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
