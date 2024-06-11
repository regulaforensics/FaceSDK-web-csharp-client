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
    /// SearchPerson
    /// </summary>
    [DataContract]
    public partial class SearchPerson :  IEquatable<SearchPerson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPerson" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchPerson() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPerson" /> class.
        /// </summary>
        /// <param name="name">Person&#39;s name. (required).</param>
        /// <param name="externalId">Person&#39;s ID, used for linking search results to an ID in an external system. Can be set when creating a Person, stored in the database, and included in the search to return only Persons with the specified ID. Optional..</param>
        /// <param name="metadata">A free-form object containing person&#39;s extended attributes..</param>
        /// <param name="groups">List of groups this person belongs to..</param>
        /// <param name="id">Person ID. The list of persons is sorted by decreasing ID value..</param>
        /// <param name="createdAt">Person creation date..</param>
        /// <param name="updatedAt">Person update date..</param>
        /// <param name="detection">detection.</param>
        /// <param name="images">Array of Person images..</param>
        public SearchPerson(string name = default(string), string externalId = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), List<Guid> groups = default(List<Guid>), Guid id = default(Guid), string createdAt = default(string), string updatedAt = default(string), SearchDetection detection = default(SearchDetection), List<RecognizeImage> images = default(List<RecognizeImage>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SearchPerson and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.ExternalId = externalId;
            this.Metadata = metadata;
            this.Groups = groups;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Detection = detection;
            this.Images = images;
        }

        /// <summary>
        /// Person&#39;s name.
        /// </summary>
        /// <value>Person&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Person&#39;s ID, used for linking search results to an ID in an external system. Can be set when creating a Person, stored in the database, and included in the search to return only Persons with the specified ID. Optional.
        /// </summary>
        /// <value>Person&#39;s ID, used for linking search results to an ID in an external system. Can be set when creating a Person, stored in the database, and included in the search to return only Persons with the specified ID. Optional.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// A free-form object containing person&#39;s extended attributes.
        /// </summary>
        /// <value>A free-form object containing person&#39;s extended attributes.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// List of groups this person belongs to.
        /// </summary>
        /// <value>List of groups this person belongs to.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<Guid> Groups { get; set; }

        /// <summary>
        /// Person ID. The list of persons is sorted by decreasing ID value.
        /// </summary>
        /// <value>Person ID. The list of persons is sorted by decreasing ID value.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Person creation date.
        /// </summary>
        /// <value>Person creation date.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Person update date.
        /// </summary>
        /// <value>Person update date.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Detection
        /// </summary>
        [DataMember(Name="detection", EmitDefaultValue=false)]
        public SearchDetection Detection { get; set; }

        /// <summary>
        /// Array of Person images.
        /// </summary>
        /// <value>Array of Person images.</value>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<RecognizeImage> Images { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchPerson {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Detection: ").Append(Detection).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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
            return this.Equals(input as SearchPerson);
        }

        /// <summary>
        /// Returns true if SearchPerson instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchPerson input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                    this.Detection == input.Detection ||
                    (this.Detection != null &&
                    this.Detection.Equals(input.Detection))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Detection != null)
                    hashCode = hashCode * 59 + this.Detection.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
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
