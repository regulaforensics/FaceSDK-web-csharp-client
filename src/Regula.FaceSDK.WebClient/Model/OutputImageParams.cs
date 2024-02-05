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
    /// Whether to process the uploaded image according to the indicated settings.
    /// </summary>
    [DataContract(Name = "OutputImageParams")]
    public partial class OutputImageParams : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputImageParams" /> class.
        /// </summary>
        /// <param name="backgroundColor">The RGB value of a color for filling background behind a person&#39;s silhouette and for aligning the image..</param>
        /// <param name="crop">crop.</param>
        public OutputImageParams(List<int> backgroundColor = default(List<int>), Crop crop = default(Crop))
        {
            this.BackgroundColor = backgroundColor;
            this.Crop = crop;
        }

        /// <summary>
        /// The RGB value of a color for filling background behind a person&#39;s silhouette and for aligning the image.
        /// </summary>
        /// <value>The RGB value of a color for filling background behind a person&#39;s silhouette and for aligning the image.</value>
        /// <example>[128,128,128]</example>
        [DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
        public List<int> BackgroundColor { get; set; }

        /// <summary>
        /// Gets or Sets Crop
        /// </summary>
        [DataMember(Name = "crop", EmitDefaultValue = false)]
        public Crop Crop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OutputImageParams {\n");
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
