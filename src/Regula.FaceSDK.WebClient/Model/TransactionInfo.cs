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
    /// TransactionInfo
    /// </summary>
    [DataContract]
    public partial class TransactionInfo :  IEquatable<TransactionInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public LivenessType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInfo" /> class.
        /// </summary>
        /// <param name="code">Result code, see the [FaceSDKResultCode enum](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-sdk-result-code/)..</param>
        /// <param name="status">Whether the liveness detection is confirmed &#x60;0&#x60; or not &#x60;1&#x60;..</param>
        /// <param name="tag">Session identificator, should be unique for each session..</param>
        /// <param name="transactionId">Transaction ID, there can be several transactions within one session..</param>
        /// <param name="video">Link to the session video, depends on the selected storage type. [Learn more](https://docs.regulaforensics.com/develop/face-sdk/web-service/administration/storage/).</param>
        /// <param name="age">Approximate age with an accuracy of +/-3 years..</param>
        /// <param name="portrait">Link to the portrait, depends on the selected storage type. [Learn more](https://docs.regulaforensics.com/develop/face-sdk/web-service/administration/storage/).</param>
        /// <param name="metadata">A free-form object containing person&#39;s extended attributes..</param>
        /// <param name="type">type.</param>
        public TransactionInfo(int code = default(int), int status = default(int), string tag = default(string), string transactionId = default(string), string video = default(string), List<Dictionary<string, Object>> age = default(List<Dictionary<string, Object>>), string portrait = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), LivenessType? type = default(LivenessType?))
        {
            this.Code = code;
            this.Status = status;
            this.Tag = tag;
            this.TransactionId = transactionId;
            this.Video = video;
            this.Age = age;
            this.Portrait = portrait;
            this.Metadata = metadata;
            this.Type = type;
        }

        /// <summary>
        /// Result code, see the [FaceSDKResultCode enum](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-sdk-result-code/).
        /// </summary>
        /// <value>Result code, see the [FaceSDKResultCode enum](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-sdk-result-code/).</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int Code { get; set; }

        /// <summary>
        /// Whether the liveness detection is confirmed &#x60;0&#x60; or not &#x60;1&#x60;.
        /// </summary>
        /// <value>Whether the liveness detection is confirmed &#x60;0&#x60; or not &#x60;1&#x60;.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int Status { get; set; }

        /// <summary>
        /// Session identificator, should be unique for each session.
        /// </summary>
        /// <value>Session identificator, should be unique for each session.</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Transaction ID, there can be several transactions within one session.
        /// </summary>
        /// <value>Transaction ID, there can be several transactions within one session.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Link to the session video, depends on the selected storage type. [Learn more](https://docs.regulaforensics.com/develop/face-sdk/web-service/administration/storage/)
        /// </summary>
        /// <value>Link to the session video, depends on the selected storage type. [Learn more](https://docs.regulaforensics.com/develop/face-sdk/web-service/administration/storage/)</value>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public string Video { get; set; }

        /// <summary>
        /// Approximate age with an accuracy of +/-3 years.
        /// </summary>
        /// <value>Approximate age with an accuracy of +/-3 years.</value>
        [DataMember(Name="age", EmitDefaultValue=false)]
        public List<Dictionary<string, Object>> Age { get; set; }

        /// <summary>
        /// Link to the portrait, depends on the selected storage type. [Learn more](https://docs.regulaforensics.com/develop/face-sdk/web-service/administration/storage/)
        /// </summary>
        /// <value>Link to the portrait, depends on the selected storage type. [Learn more](https://docs.regulaforensics.com/develop/face-sdk/web-service/administration/storage/)</value>
        [DataMember(Name="portrait", EmitDefaultValue=false)]
        public string Portrait { get; set; }

        /// <summary>
        /// A free-form object containing person&#39;s extended attributes.
        /// </summary>
        /// <value>A free-form object containing person&#39;s extended attributes.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, Object> Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionInfo {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  Portrait: ").Append(Portrait).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TransactionInfo);
        }

        /// <summary>
        /// Returns true if TransactionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInfo input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.Age == input.Age ||
                    this.Age != null &&
                    input.Age != null &&
                    this.Age.SequenceEqual(input.Age)
                ) && 
                (
                    this.Portrait == input.Portrait ||
                    (this.Portrait != null &&
                    this.Portrait.Equals(input.Portrait))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Age != null)
                    hashCode = hashCode * 59 + this.Age.GetHashCode();
                if (this.Portrait != null)
                    hashCode = hashCode * 59 + this.Portrait.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
