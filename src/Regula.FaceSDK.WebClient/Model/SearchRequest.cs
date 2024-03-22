/*
 * Regula Face SDK Web API
 *
 * <a href=\"https://regulaforensics.com/products/face-recognition-sdk/  \" target=\"_blank\">Regula Face SDK</a> is a cross-platform biometric verification solution for a digital identity verification process. The SDK enables convenient and reliable face capture on the client side (mobile, web, and desktop) and further processing on the client or server side.  The Face SDK includes the following features:  * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#face-detection\" target=\"_blank\">Face Detection</a> * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#face-comparison-11\" target=\"_blank\">Face Match (1:1)</a> * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#face-identification-1n\" target=\"_blank\">Face Search (1:N)</a> * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#liveness-assessment\" target=\"_blank\">Liveness Assessment</a>  Here is the <a href=\"https://github.com/regulaforensics/FaceSDK-web-openapi  \" target=\"_blank\">OpenAPI specification on GitHub</a>.   ### Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
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
    /// SearchRequest
    /// </summary>
    [DataContract]
    public partial class SearchRequest :  IEquatable<SearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="createPerson">createPerson.</param>
        /// <param name="groupIds">IDs of the groups in which the search is performed..</param>
        /// <param name="tag">Session identificator, should be unique for each session..</param>
        /// <param name="image">image.</param>
        /// <param name="outputImageParams">outputImageParams.</param>
        /// <param name="detectAll">Whether to detect all faces in the image. If set to &#x60;false&#x60;, only the most central face is detected. (default to false).</param>
        /// <param name="threshold">The similarity threshold..</param>
        /// <param name="limit">The maximum number of results to be returned..</param>
        public SearchRequest(SearchParametersCreatePerson createPerson = default(SearchParametersCreatePerson), List<Guid> groupIds = default(List<Guid>), string tag = default(string), AddImageToPersonRequestImage image = default(AddImageToPersonRequestImage), OutputImageParams outputImageParams = default(OutputImageParams), bool detectAll = false, float threshold = default(float), int limit = default(int))
        {
            this.CreatePerson = createPerson;
            this.GroupIds = groupIds;
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
        /// Gets or Sets CreatePerson
        /// </summary>
        [DataMember(Name="createPerson", EmitDefaultValue=false)]
        public SearchParametersCreatePerson CreatePerson { get; set; }

        /// <summary>
        /// IDs of the groups in which the search is performed.
        /// </summary>
        /// <value>IDs of the groups in which the search is performed.</value>
        [DataMember(Name="groupIds", EmitDefaultValue=false)]
        public List<Guid> GroupIds { get; set; }

        /// <summary>
        /// Session identificator, should be unique for each session.
        /// </summary>
        /// <value>Session identificator, should be unique for each session.</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public AddImageToPersonRequestImage Image { get; set; }

        /// <summary>
        /// Gets or Sets OutputImageParams
        /// </summary>
        [DataMember(Name="outputImageParams", EmitDefaultValue=false)]
        public OutputImageParams OutputImageParams { get; set; }

        /// <summary>
        /// Whether to detect all faces in the image. If set to &#x60;false&#x60;, only the most central face is detected.
        /// </summary>
        /// <value>Whether to detect all faces in the image. If set to &#x60;false&#x60;, only the most central face is detected.</value>
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchRequest);
        }

        /// <summary>
        /// Returns true if SearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatePerson == input.CreatePerson ||
                    (this.CreatePerson != null &&
                    this.CreatePerson.Equals(input.CreatePerson))
                ) && 
                (
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    input.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
                ) && 
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
                if (this.CreatePerson != null)
                    hashCode = hashCode * 59 + this.CreatePerson.GetHashCode();
                if (this.GroupIds != null)
                    hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
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
