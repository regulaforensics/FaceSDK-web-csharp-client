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
    /// Detection
    /// </summary>
    [DataContract]
    public partial class Detection :  IEquatable<Detection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Detection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Detection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Detection" /> class.
        /// </summary>
        /// <param name="crop">Base64-encoded image..</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="landmarks">Absolute coordinates (x,y) of five points of each detected face: left eye, right eye, nose, left point of lips, right point of lips. (required).</param>
        /// <param name="quality">quality.</param>
        /// <param name="roi">The rectangular area of a detected face that is represented by a set of four elements: the X and Y coordinates of the top-left point, and the width and height dimensions of the rectangle. (required).</param>
        /// <param name="thumbnail">See &#x60;crop&#x60; instead..</param>
        public Detection(byte[] crop = default(byte[]), DetectionAttributes attributes = default(DetectionAttributes), List<List<int>> landmarks = default(List<List<int>>), DetectionQuality quality = default(DetectionQuality), List<decimal> roi = default(List<decimal>), byte[] thumbnail = default(byte[]))
        {
            // to ensure "landmarks" is required (not null)
            if (landmarks == null)
            {
                throw new InvalidDataException("landmarks is a required property for Detection and cannot be null");
            }
            else
            {
                this.Landmarks = landmarks;
            }

            // to ensure "roi" is required (not null)
            if (roi == null)
            {
                throw new InvalidDataException("roi is a required property for Detection and cannot be null");
            }
            else
            {
                this.Roi = roi;
            }

            this.Crop = crop;
            this.Attributes = attributes;
            this.Quality = quality;
            this.Thumbnail = thumbnail;
        }

        /// <summary>
        /// Base64-encoded image.
        /// </summary>
        /// <value>Base64-encoded image.</value>
        [DataMember(Name="crop", EmitDefaultValue=false)]
        public byte[] Crop { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public DetectionAttributes Attributes { get; set; }

        /// <summary>
        /// Absolute coordinates (x,y) of five points of each detected face: left eye, right eye, nose, left point of lips, right point of lips.
        /// </summary>
        /// <value>Absolute coordinates (x,y) of five points of each detected face: left eye, right eye, nose, left point of lips, right point of lips.</value>
        [DataMember(Name="landmarks", EmitDefaultValue=true)]
        public List<List<int>> Landmarks { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name="quality", EmitDefaultValue=false)]
        public DetectionQuality Quality { get; set; }

        /// <summary>
        /// The rectangular area of a detected face that is represented by a set of four elements: the X and Y coordinates of the top-left point, and the width and height dimensions of the rectangle.
        /// </summary>
        /// <value>The rectangular area of a detected face that is represented by a set of four elements: the X and Y coordinates of the top-left point, and the width and height dimensions of the rectangle.</value>
        [DataMember(Name="roi", EmitDefaultValue=true)]
        public List<decimal> Roi { get; set; }

        /// <summary>
        /// See &#x60;crop&#x60; instead.
        /// </summary>
        /// <value>See &#x60;crop&#x60; instead.</value>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        [Obsolete]
        public byte[] Thumbnail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Detection {\n");
            sb.Append("  Crop: ").Append(Crop).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Landmarks: ").Append(Landmarks).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Roi: ").Append(Roi).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
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
            return this.Equals(input as Detection);
        }

        /// <summary>
        /// Returns true if Detection instances are equal
        /// </summary>
        /// <param name="input">Instance of Detection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Detection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Crop == input.Crop ||
                    (this.Crop != null &&
                    this.Crop.Equals(input.Crop))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Landmarks == input.Landmarks ||
                    this.Landmarks != null &&
                    input.Landmarks != null &&
                    this.Landmarks.SequenceEqual(input.Landmarks)
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
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
                if (this.Crop != null)
                    hashCode = hashCode * 59 + this.Crop.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Landmarks != null)
                    hashCode = hashCode * 59 + this.Landmarks.GetHashCode();
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.Roi != null)
                    hashCode = hashCode * 59 + this.Roi.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
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
