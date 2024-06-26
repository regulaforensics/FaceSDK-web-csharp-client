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
    /// If set, a Base64-encoded aligned and cropped by the indicated settings portrait is returned in the &#x60;crop&#x60; field.
    /// </summary>
    [DataContract]
    public partial class MatchRequestOutputImageParamsCrop :  IEquatable<MatchRequestOutputImageParamsCrop>, IValidatableObject
    {
        /// <summary>
        /// The aspect ratio according to which face alignment is performed. See the [FaceImageQualityAlignType enum](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-image-quality-align-type/). To get a thumbnail with aspect ratio 3:4, set &#x60;0&#x60;.
        /// </summary>
        /// <value>The aspect ratio according to which face alignment is performed. See the [FaceImageQualityAlignType enum](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-image-quality-align-type/). To get a thumbnail with aspect ratio 3:4, set &#x60;0&#x60;.</value>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4

        }

        /// <summary>
        /// The aspect ratio according to which face alignment is performed. See the [FaceImageQualityAlignType enum](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-image-quality-align-type/). To get a thumbnail with aspect ratio 3:4, set &#x60;0&#x60;.
        /// </summary>
        /// <value>The aspect ratio according to which face alignment is performed. See the [FaceImageQualityAlignType enum](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-image-quality-align-type/). To get a thumbnail with aspect ratio 3:4, set &#x60;0&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchRequestOutputImageParamsCrop" /> class.
        /// </summary>
        /// <param name="padColor">The RGB value of a color for filling background behind a person&#39;s silhouette and for aligning the image..</param>
        /// <param name="returnOriginalRect">Whether to return the coordinates of the rectangle with the face in the original image prepared for the face crop..</param>
        /// <param name="size">The resize value in case &#x60;type&#x60; matches this value. If it doesn&#39;t, no resize is performed..</param>
        /// <param name="type">The aspect ratio according to which face alignment is performed. See the [FaceImageQualityAlignType enum](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-image-quality-align-type/). To get a thumbnail with aspect ratio 3:4, set &#x60;0&#x60;..</param>
        public MatchRequestOutputImageParamsCrop(List<int> padColor = default(List<int>), bool returnOriginalRect = default(bool), List<int> size = default(List<int>), TypeEnum? type = default(TypeEnum?))
        {
            this.PadColor = padColor;
            this.ReturnOriginalRect = returnOriginalRect;
            this.Size = size;
            this.Type = type;
        }

        /// <summary>
        /// The RGB value of a color for filling background behind a person&#39;s silhouette and for aligning the image.
        /// </summary>
        /// <value>The RGB value of a color for filling background behind a person&#39;s silhouette and for aligning the image.</value>
        [DataMember(Name="padColor", EmitDefaultValue=false)]
        public List<int> PadColor { get; set; }

        /// <summary>
        /// Whether to return the coordinates of the rectangle with the face in the original image prepared for the face crop.
        /// </summary>
        /// <value>Whether to return the coordinates of the rectangle with the face in the original image prepared for the face crop.</value>
        [DataMember(Name="returnOriginalRect", EmitDefaultValue=false)]
        public bool ReturnOriginalRect { get; set; }

        /// <summary>
        /// The resize value in case &#x60;type&#x60; matches this value. If it doesn&#39;t, no resize is performed.
        /// </summary>
        /// <value>The resize value in case &#x60;type&#x60; matches this value. If it doesn&#39;t, no resize is performed.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public List<int> Size { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchRequestOutputImageParamsCrop {\n");
            sb.Append("  PadColor: ").Append(PadColor).Append("\n");
            sb.Append("  ReturnOriginalRect: ").Append(ReturnOriginalRect).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as MatchRequestOutputImageParamsCrop);
        }

        /// <summary>
        /// Returns true if MatchRequestOutputImageParamsCrop instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchRequestOutputImageParamsCrop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchRequestOutputImageParamsCrop input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PadColor == input.PadColor ||
                    this.PadColor != null &&
                    input.PadColor != null &&
                    this.PadColor.SequenceEqual(input.PadColor)
                ) && 
                (
                    this.ReturnOriginalRect == input.ReturnOriginalRect ||
                    (this.ReturnOriginalRect != null &&
                    this.ReturnOriginalRect.Equals(input.ReturnOriginalRect))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size != null &&
                    input.Size != null &&
                    this.Size.SequenceEqual(input.Size)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.PadColor != null)
                    hashCode = hashCode * 59 + this.PadColor.GetHashCode();
                if (this.ReturnOriginalRect != null)
                    hashCode = hashCode * 59 + this.ReturnOriginalRect.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
