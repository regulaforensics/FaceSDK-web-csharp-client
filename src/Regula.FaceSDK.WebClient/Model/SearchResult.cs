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
    /// SearchResult
    /// </summary>
    [DataContract]
    public partial class SearchResult :  IEquatable<SearchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        /// <param name="code">Result code. It is returned only with response 200..</param>
        /// <param name="persons">Array of Person images. It is returned only with response 200..</param>
        /// <param name="id">Person ID. The list of persons is sorted by decreasing ID value..</param>
        /// <param name="createdAt">Person creation date..</param>
        /// <param name="updatedAt">Person update date..</param>
        /// <param name="groups">List of groups this person belongs to..</param>
        /// <param name="name">Person&#39;s name..</param>
        /// <param name="metadata">A free-form object containing person&#39;s extended attributes. Available when a person is being created.</param>
        public SearchResult(int code = default(int), List<SearchPerson> persons = default(List<SearchPerson>), Guid? id = default(Guid?), string createdAt = default(string), string updatedAt = default(string), List<Guid> groups = default(List<Guid>), string name = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Groups = groups;
            this.Name = name;
            this.Code = code;
            this.Persons = persons;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Groups = groups;
            this.Name = name;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Result code. It is returned only with response 200.
        /// </summary>
        /// <value>Result code. It is returned only with response 200.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int Code { get; set; }

        /// <summary>
        /// Array of Person images. It is returned only with response 200.
        /// </summary>
        /// <value>Array of Person images. It is returned only with response 200.</value>
        [DataMember(Name="persons", EmitDefaultValue=false)]
        public List<SearchPerson> Persons { get; set; }

        /// <summary>
        /// Person ID. The list of persons is sorted by decreasing ID value.
        /// </summary>
        /// <value>Person ID. The list of persons is sorted by decreasing ID value.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Person creation date.
        /// </summary>
        /// <value>Person creation date.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Person update date.
        /// </summary>
        /// <value>Person update date.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// List of groups this person belongs to.
        /// </summary>
        /// <value>List of groups this person belongs to.</value>
        [DataMember(Name="groups", EmitDefaultValue=true)]
        public List<Guid> Groups { get; set; }

        /// <summary>
        /// Person&#39;s name.
        /// </summary>
        /// <value>Person&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// A free-form object containing person&#39;s extended attributes. Available when a person is being created
        /// </summary>
        /// <value>A free-form object containing person&#39;s extended attributes. Available when a person is being created</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResult {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as SearchResult);
        }

        /// <summary>
        /// Returns true if SearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Persons == input.Persons ||
                    this.Persons != null &&
                    input.Persons != null &&
                    this.Persons.SequenceEqual(input.Persons)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Persons != null)
                    hashCode = hashCode * 59 + this.Persons.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
