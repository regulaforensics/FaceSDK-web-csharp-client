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
    /// DetectRequest
    /// </summary>
    [DataContract]
    public partial class DetectRequest :  IEquatable<DetectRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectRequest" /> class.
        /// </summary>
        /// <param name="tag">tag.</param>
        /// <param name="processParam">processParam.</param>
        /// <param name="image">Base64 encoded image.</param>
        /// <param name="thumbnails">Enable formatted detections&#39; thumbnails in the response (default to false).</param>
        /// <param name="attributes">Enable face attributions detection, such as age or emotion and etc. (default to false).</param>
        /// <param name="onlyCentralFace">True - main face; false - all faces. (default to false).</param>
        public DetectRequest(string tag = default(string), ProcessParam processParam = default(ProcessParam), byte[] image = default(byte[]), bool thumbnails = false, bool attributes = false, bool onlyCentralFace = false)
        {
            this.Tag = tag;
            this.ProcessParam = processParam;
            this.Image = image;
            // use default value if no "thumbnails" provided
            if (thumbnails == null)
            {
                this.Thumbnails = false;
            }
            else
            {
                this.Thumbnails = thumbnails;
            }
            // use default value if no "attributes" provided
            if (attributes == null)
            {
                this.Attributes = false;
            }
            else
            {
                this.Attributes = attributes;
            }
            // use default value if no "onlyCentralFace" provided
            if (onlyCentralFace == null)
            {
                this.OnlyCentralFace = false;
            }
            else
            {
                this.OnlyCentralFace = onlyCentralFace;
            }
        }
        
        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets ProcessParam
        /// </summary>
        [DataMember(Name="processParam", EmitDefaultValue=false)]
        public ProcessParam ProcessParam { get; set; }

        /// <summary>
        /// Base64 encoded image
        /// </summary>
        /// <value>Base64 encoded image</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public byte[] Image { get; set; }

        /// <summary>
        /// Enable formatted detections&#39; thumbnails in the response
        /// </summary>
        /// <value>Enable formatted detections&#39; thumbnails in the response</value>
        [DataMember(Name="thumbnails", EmitDefaultValue=false)]
        public bool Thumbnails { get; set; }

        /// <summary>
        /// Enable face attributions detection, such as age or emotion and etc.
        /// </summary>
        /// <value>Enable face attributions detection, such as age or emotion and etc.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public bool Attributes { get; set; }

        /// <summary>
        /// True - main face; false - all faces.
        /// </summary>
        /// <value>True - main face; false - all faces.</value>
        [DataMember(Name="onlyCentralFace", EmitDefaultValue=false)]
        public bool OnlyCentralFace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectRequest {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  ProcessParam: ").Append(ProcessParam).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  OnlyCentralFace: ").Append(OnlyCentralFace).Append("\n");
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
            return this.Equals(input as DetectRequest);
        }

        /// <summary>
        /// Returns true if DetectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DetectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectRequest input)
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
                    this.ProcessParam == input.ProcessParam ||
                    (this.ProcessParam != null &&
                    this.ProcessParam.Equals(input.ProcessParam))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Thumbnails == input.Thumbnails ||
                    (this.Thumbnails != null &&
                    this.Thumbnails.Equals(input.Thumbnails))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.OnlyCentralFace == input.OnlyCentralFace ||
                    (this.OnlyCentralFace != null &&
                    this.OnlyCentralFace.Equals(input.OnlyCentralFace))
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
                if (this.ProcessParam != null)
                    hashCode = hashCode * 59 + this.ProcessParam.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Thumbnails != null)
                    hashCode = hashCode * 59 + this.Thumbnails.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.OnlyCentralFace != null)
                    hashCode = hashCode * 59 + this.OnlyCentralFace.GetHashCode();
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
