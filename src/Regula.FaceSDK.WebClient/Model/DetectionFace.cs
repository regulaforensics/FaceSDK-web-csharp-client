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
    /// DetectionFace
    /// </summary>
    [DataContract(Name = "DetectionFace")]
    public partial class DetectionFace : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectionFace" /> class.
        /// </summary>
        /// <param name="faceIndex">The detected face index number..</param>
        /// <param name="landmarks">Absolute coordinates (x,y) of five points of each detected face: left eye, right eye, nose, left point of lips, right point of lips..</param>
        /// <param name="rotationAngle">Angle of rotation of the face from the vertical axis, degrees..</param>
        /// <param name="roi">The rectangular area of a detected face that is represented by a set of four elements: the X and Y coordinates of the top-left point, and the width and height dimensions of the rectangle..</param>
        /// <param name="thumbnail">Base64 of the cropped portrait..</param>
        /// <param name="crop">Base64 of the cropped portrait..</param>
        public DetectionFace(decimal faceIndex = default(decimal), List<List<decimal>> landmarks = default(List<List<decimal>>), decimal rotationAngle = default(decimal), List<decimal> roi = default(List<decimal>), byte[] thumbnail = default(byte[]), byte[] crop = default(byte[]))
        {
            this.FaceIndex = faceIndex;
            this.Landmarks = landmarks;
            this.RotationAngle = rotationAngle;
            this.Roi = roi;
            this.Thumbnail = thumbnail;
            this.Crop = crop;
        }

        /// <summary>
        /// The detected face index number.
        /// </summary>
        /// <value>The detected face index number.</value>
        [DataMember(Name = "faceIndex", EmitDefaultValue = false)]
        public decimal FaceIndex { get; set; }

        /// <summary>
        /// Absolute coordinates (x,y) of five points of each detected face: left eye, right eye, nose, left point of lips, right point of lips.
        /// </summary>
        /// <value>Absolute coordinates (x,y) of five points of each detected face: left eye, right eye, nose, left point of lips, right point of lips.</value>
        /// <example>[[&quot;x&quot;,&quot;y&quot;]]</example>
        [DataMember(Name = "landmarks", EmitDefaultValue = false)]
        public List<List<decimal>> Landmarks { get; set; }

        /// <summary>
        /// Angle of rotation of the face from the vertical axis, degrees.
        /// </summary>
        /// <value>Angle of rotation of the face from the vertical axis, degrees.</value>
        [DataMember(Name = "rotationAngle", EmitDefaultValue = false)]
        public decimal RotationAngle { get; set; }

        /// <summary>
        /// The rectangular area of a detected face that is represented by a set of four elements: the X and Y coordinates of the top-left point, and the width and height dimensions of the rectangle.
        /// </summary>
        /// <value>The rectangular area of a detected face that is represented by a set of four elements: the X and Y coordinates of the top-left point, and the width and height dimensions of the rectangle.</value>
        /// <example>[&quot;x&quot;,&quot;y&quot;,&quot;width&quot;,&quot;height&quot;]</example>
        [DataMember(Name = "roi", EmitDefaultValue = false)]
        public List<decimal> Roi { get; set; }

        /// <summary>
        /// Base64 of the cropped portrait.
        /// </summary>
        /// <value>Base64 of the cropped portrait.</value>
        [DataMember(Name = "thumbnail", EmitDefaultValue = false)]
        public byte[] Thumbnail { get; set; }

        /// <summary>
        /// Base64 of the cropped portrait.
        /// </summary>
        /// <value>Base64 of the cropped portrait.</value>
        [DataMember(Name = "crop", EmitDefaultValue = false)]
        public byte[] Crop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DetectionFace {\n");
            sb.Append("  FaceIndex: ").Append(FaceIndex).Append("\n");
            sb.Append("  Landmarks: ").Append(Landmarks).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
            sb.Append("  Roi: ").Append(Roi).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
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
