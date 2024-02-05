/*
 * Regula FaceSDK Web API
 *
 * [Download OpenAPI specification](https://github.com/regulaforensics/FaceSDK-web-openapi) ### Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 6.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Regula.FaceSDK.WebClient.Client.OpenAPIDateConverter;

namespace Regula.FaceSDK.WebClient.Model
{
    /// <summary>
    /// DetectRequest
    /// </summary>
    [DataContract(Name = "DetectRequest")]
    public partial class DetectRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectRequest" /> class.
        /// </summary>
        /// <param name="tag">Session identificator..</param>
        /// <param name="processParam">processParam.</param>
        /// <param name="image">Base64 encoded image..</param>
        /// <param name="thumbnails">Deprecated, use the &#x60;crop&#x60; field in &#x60;processParam&#x60; instead. (default to false).</param>
        public DetectRequest(string tag = default(string), ProcessParam processParam = default(ProcessParam), byte[] image = default(byte[]), bool thumbnails = false)
        {
            this.Tag = tag;
            this.ProcessParam = processParam;
            this.Image = image;
            this.Thumbnails = thumbnails;
        }

        /// <summary>
        /// Session identificator.
        /// </summary>
        /// <value>Session identificator.</value>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets ProcessParam
        /// </summary>
        [DataMember(Name = "processParam", EmitDefaultValue = false)]
        public ProcessParam ProcessParam { get; set; }

        /// <summary>
        /// Base64 encoded image.
        /// </summary>
        /// <value>Base64 encoded image.</value>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public byte[] Image { get; set; }

        /// <summary>
        /// Deprecated, use the &#x60;crop&#x60; field in &#x60;processParam&#x60; instead.
        /// </summary>
        /// <value>Deprecated, use the &#x60;crop&#x60; field in &#x60;processParam&#x60; instead.</value>
        [DataMember(Name = "thumbnails", EmitDefaultValue = true)]
        public bool Thumbnails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DetectRequest {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  ProcessParam: ").Append(ProcessParam).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
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
