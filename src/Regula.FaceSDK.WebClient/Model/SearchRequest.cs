/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 4.1.3
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
        /// <param name="limit">The number of returned Persons limit. (default to 100).</param>
        /// <param name="threshold">The similarity distance threshold..</param>
        /// <param name="groupIds">The IDs of the groups in which the search is performed..</param>
        /// <param name="image">image.</param>
        public SearchRequest(int limit = 100, float threshold = default(float), List<int> groupIds = default(List<int>), ImageFieldsImage image = default(ImageFieldsImage))
        {
            // use default value if no "limit" provided
            if (limit == null)
            {
                this.Limit = 100;
            }
            else
            {
                this.Limit = limit;
            }
            this.Threshold = threshold;
            this.GroupIds = groupIds;
            this.Image = image;
        }

        /// <summary>
        /// The number of returned Persons limit.
        /// </summary>
        /// <value>The number of returned Persons limit.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int Limit { get; set; }

        /// <summary>
        /// The similarity distance threshold.
        /// </summary>
        /// <value>The similarity distance threshold.</value>
        [DataMember(Name="threshold", EmitDefaultValue=false)]
        public float Threshold { get; set; }

        /// <summary>
        /// The IDs of the groups in which the search is performed.
        /// </summary>
        /// <value>The IDs of the groups in which the search is performed.</value>
        [DataMember(Name="group_ids", EmitDefaultValue=false)]
        public List<int> GroupIds { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public ImageFieldsImage Image { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchRequest {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    input.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.GroupIds != null)
                    hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
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
