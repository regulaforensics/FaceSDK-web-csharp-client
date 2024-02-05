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
    /// SearchRequest
    /// </summary>
    [DataContract(Name = "SearchRequest")]
    public partial class SearchRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="createPerson">createPerson.</param>
        /// <param name="groupIds">IDs of the groups in which the search is performed..</param>
        /// <param name="tag">Session identificator..</param>
        /// <param name="image">image.</param>
        /// <param name="outputImageParams">outputImageParams.</param>
        /// <param name="detectAll">Whether to detect all faces in the image. If set to false, only the most central face is detected. (default to false).</param>
        /// <param name="threshold">The similarity threshold..</param>
        /// <param name="limit">The maximum number of results to be returned..</param>
        public SearchRequest(SearchParametersCreatePerson createPerson = default(SearchParametersCreatePerson), List<Guid> groupIds = default(List<Guid>), string tag = default(string), ImageFieldsImage image = default(ImageFieldsImage), OutputImageParams outputImageParams = default(OutputImageParams), bool detectAll = false, float threshold = default(float), int limit = default(int))
        {
            this.CreatePerson = createPerson;
            this.GroupIds = groupIds;
            this.Tag = tag;
            this.Image = image;
            this.OutputImageParams = outputImageParams;
            this.DetectAll = detectAll;
            this.Threshold = threshold;
            this.Limit = limit;
        }

        /// <summary>
        /// Gets or Sets CreatePerson
        /// </summary>
        [DataMember(Name = "createPerson", EmitDefaultValue = false)]
        public SearchParametersCreatePerson CreatePerson { get; set; }

        /// <summary>
        /// IDs of the groups in which the search is performed.
        /// </summary>
        /// <value>IDs of the groups in which the search is performed.</value>
        [DataMember(Name = "groupIds", EmitDefaultValue = false)]
        public List<Guid> GroupIds { get; set; }

        /// <summary>
        /// Session identificator.
        /// </summary>
        /// <value>Session identificator.</value>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public ImageFieldsImage Image { get; set; }

        /// <summary>
        /// Gets or Sets OutputImageParams
        /// </summary>
        [DataMember(Name = "outputImageParams", EmitDefaultValue = false)]
        public OutputImageParams OutputImageParams { get; set; }

        /// <summary>
        /// Whether to detect all faces in the image. If set to false, only the most central face is detected.
        /// </summary>
        /// <value>Whether to detect all faces in the image. If set to false, only the most central face is detected.</value>
        [DataMember(Name = "detectAll", EmitDefaultValue = true)]
        public bool DetectAll { get; set; }

        /// <summary>
        /// The similarity threshold.
        /// </summary>
        /// <value>The similarity threshold.</value>
        [DataMember(Name = "threshold", EmitDefaultValue = false)]
        public float Threshold { get; set; }

        /// <summary>
        /// The maximum number of results to be returned.
        /// </summary>
        /// <value>The maximum number of results to be returned.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchRequest {\n");
            sb.Append("  CreatePerson: ").Append(CreatePerson).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
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
