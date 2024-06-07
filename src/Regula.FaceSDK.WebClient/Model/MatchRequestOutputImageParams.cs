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
    /// Whether to process the uploaded image according to the indicated settings.
    /// </summary>
    [DataContract]
    public partial class MatchRequestOutputImageParams :  IEquatable<MatchRequestOutputImageParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchRequestOutputImageParams" /> class.
        /// </summary>
        /// <param name="backgroundColor">The RGB value of a color for filling background behind a person&#39;s silhouette and for aligning the image..</param>
        /// <param name="crop">crop.</param>
        public MatchRequestOutputImageParams(List<int> backgroundColor = default(List<int>), MatchRequestOutputImageParamsCrop crop = default(MatchRequestOutputImageParamsCrop))
        {
            this.BackgroundColor = backgroundColor;
            this.Crop = crop;
        }

        /// <summary>
        /// The RGB value of a color for filling background behind a person&#39;s silhouette and for aligning the image.
        /// </summary>
        /// <value>The RGB value of a color for filling background behind a person&#39;s silhouette and for aligning the image.</value>
        [DataMember(Name="backgroundColor", EmitDefaultValue=false)]
        public List<int> BackgroundColor { get; set; }

        /// <summary>
        /// Gets or Sets Crop
        /// </summary>
        [DataMember(Name="crop", EmitDefaultValue=false)]
        public MatchRequestOutputImageParamsCrop Crop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchRequestOutputImageParams {\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  Crop: ").Append(Crop).Append("\n");
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
            return this.Equals(input as MatchRequestOutputImageParams);
        }

        /// <summary>
        /// Returns true if MatchRequestOutputImageParams instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchRequestOutputImageParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchRequestOutputImageParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackgroundColor == input.BackgroundColor ||
                    this.BackgroundColor != null &&
                    input.BackgroundColor != null &&
                    this.BackgroundColor.SequenceEqual(input.BackgroundColor)
                ) && 
                (
                    this.Crop == input.Crop ||
                    (this.Crop != null &&
                    this.Crop.Equals(input.Crop))
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
                if (this.BackgroundColor != null)
                    hashCode = hashCode * 59 + this.BackgroundColor.GetHashCode();
                if (this.Crop != null)
                    hashCode = hashCode * 59 + this.Crop.GetHashCode();
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
