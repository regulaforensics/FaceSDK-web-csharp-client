/*
 * Regula FaceSDK Web api
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 5.2.0
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
    /// Request search data.
    /// </summary>
    [DataContract]
    public partial class SearchParameters :  IEquatable<SearchParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchParameters" /> class.
        /// </summary>
        /// <param name="createPerson">createPerson.</param>
        /// <param name="groupIds">IDs of the groups in which the search is performed..</param>
        public SearchParameters(SearchParametersCreatePerson createPerson = default(SearchParametersCreatePerson), List<int> groupIds = default(List<int>))
        {
            this.CreatePerson = createPerson;
            this.GroupIds = groupIds;
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
        public List<int> GroupIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchParameters {\n");
            sb.Append("  CreatePerson: ").Append(CreatePerson).Append("\n");
            sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
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
            return this.Equals(input as SearchParameters);
        }

        /// <summary>
        /// Returns true if SearchParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchParameters input)
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
