/*
 * Regula FaceSDK Web API
 *
 * [Download OpenAPI specification](https://github.com/regulaforensics/FaceSDK-web-openapi) ### Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
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
    /// Image in the request data, includes image and contentType.
    /// </summary>
    [DataContract]
    public partial class ImageFields :  IEquatable<ImageFields>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFields" /> class.
        /// </summary>
        /// <param name="tag">Session identificator..</param>
        /// <param name="image">image.</param>
        /// <param name="outputImageParams">outputImageParams.</param>
        /// <param name="detectAll">Whether to detect all faces in the image. If set to false, only the most central face is detected. (default to false).</param>
        /// <param name="threshold">The similarity threshold..</param>
        /// <param name="limit">The maximum number of results to be returned..</param>
        public ImageFields(string tag = default(string), ImageFieldsImage image = default(ImageFieldsImage), OutputImageParams outputImageParams = default(OutputImageParams), bool detectAll = false, float threshold = default(float), int limit = default(int))
        {
            this.Tag = tag;
            this.Image = image;
            this.OutputImageParams = outputImageParams;
            // use default value if no "detectAll" provided
            if (detectAll == null)
            {
                this.DetectAll = false;
            }
            else
            {
                this.DetectAll = detectAll;
            }
            this.Threshold = threshold;
            this.Limit = limit;
        }

        /// <summary>
        /// Session identificator.
        /// </summary>
        /// <value>Session identificator.</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public ImageFieldsImage Image { get; set; }

        /// <summary>
        /// Gets or Sets OutputImageParams
        /// </summary>
        [DataMember(Name="outputImageParams", EmitDefaultValue=false)]
        public OutputImageParams OutputImageParams { get; set; }

        /// <summary>
        /// Whether to detect all faces in the image. If set to false, only the most central face is detected.
        /// </summary>
        /// <value>Whether to detect all faces in the image. If set to false, only the most central face is detected.</value>
        [DataMember(Name="detectAll", EmitDefaultValue=false)]
        public bool DetectAll { get; set; }

        /// <summary>
        /// The similarity threshold.
        /// </summary>
        /// <value>The similarity threshold.</value>
        [DataMember(Name="threshold", EmitDefaultValue=false)]
        public float Threshold { get; set; }

        /// <summary>
        /// The maximum number of results to be returned.
        /// </summary>
        /// <value>The maximum number of results to be returned.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageFields {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  OutputImageParams: ").Append(OutputImageParams).Append("\n");
            sb.Append("  DetectAll: ").Append(DetectAll).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as ImageFields);
        }

        /// <summary>
        /// Returns true if ImageFields instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.OutputImageParams == input.OutputImageParams ||
                    (this.OutputImageParams != null &&
                    this.OutputImageParams.Equals(input.OutputImageParams))
                ) && 
                (
                    this.DetectAll == input.DetectAll ||
                    (this.DetectAll != null &&
                    this.DetectAll.Equals(input.DetectAll))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.OutputImageParams != null)
                    hashCode = hashCode * 59 + this.OutputImageParams.GetHashCode();
                if (this.DetectAll != null)
                    hashCode = hashCode * 59 + this.DetectAll.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
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
