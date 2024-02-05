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
    /// Person Request body: name and metadata.
    /// </summary>
    [DataContract(Name = "PersonFields")]
    public partial class PersonFields : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonFields" /> class.
        /// </summary>
        /// <param name="name">Person name..</param>
        /// <param name="metadata">A free-form object containing person&#39;s extended attributes..</param>
        /// <param name="groups">Groups a person should be placed to. If no group is specified in request, a Default group is created and the person is placed to it..</param>
        public PersonFields(string name = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), List<Guid> groups = default(List<Guid>))
        {
            this.Name = name;
            this.Metadata = metadata;
            this.Groups = groups;
        }

        /// <summary>
        /// Person name.
        /// </summary>
        /// <value>Person name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A free-form object containing person&#39;s extended attributes.
        /// </summary>
        /// <value>A free-form object containing person&#39;s extended attributes.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Groups a person should be placed to. If no group is specified in request, a Default group is created and the person is placed to it.
        /// </summary>
        /// <value>Groups a person should be placed to. If no group is specified in request, a Default group is created and the person is placed to it.</value>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<Guid> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonFields {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
