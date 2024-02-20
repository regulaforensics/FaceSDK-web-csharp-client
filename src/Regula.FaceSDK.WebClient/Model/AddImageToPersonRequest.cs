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
    public partial class AddImageToPersonRequest :  IEquatable<AddImageToPersonRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddImageToPersonRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddImageToPersonRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddImageToPersonRequest" /> class.
        /// </summary>
        /// <param name="tag">Session identificator..</param>
        /// <param name="image">image (required).</param>
        /// <param name="threshold">The similarity threshold..</param>
        /// <param name="limit">The maximum number of results to be returned..</param>
        public AddImageToPersonRequest(string tag = default(string), AddImageToPersonRequestImage image = default(AddImageToPersonRequestImage), float threshold = default(float), int limit = default(int))
        {
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new InvalidDataException("image is a required property for AddImageToPersonRequest and cannot be null");
            }
            else
            {
                this.Image = image;
            }

            this.Tag = tag;
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
        [DataMember(Name="image", EmitDefaultValue=true)]
        public AddImageToPersonRequestImage Image { get; set; }

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
            sb.Append("class AddImageToPersonRequest {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(input as AddImageToPersonRequest);
        }

        /// <summary>
        /// Returns true if AddImageToPersonRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddImageToPersonRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddImageToPersonRequest input)
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
