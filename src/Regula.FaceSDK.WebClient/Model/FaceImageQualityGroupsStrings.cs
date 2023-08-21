/*
 * Regula FaceSDK Web API
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
    /// Face image quality group types for face image quality assessment.
    /// </summary>
    /// <value>Face image quality group types for face image quality assessment.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FaceImageQualityGroupsStrings
    {
        /// <summary>
        /// Enum IMAGE_CHARACTERISTICS for value: ImageCharacteristics
        /// </summary>
        [EnumMember(Value = "ImageCharacteristics")]
        IMAGE_CHARACTERISTICS = 1,

        /// <summary>
        /// Enum HEAD_SIZE_AND_POSITIONS for value: HeadSizeAndPosition
        /// </summary>
        [EnumMember(Value = "HeadSizeAndPosition")]
        HEAD_SIZE_AND_POSITIONS = 2,

        /// <summary>
        /// Enum FACE_QUALITY for value: FaceQuality
        /// </summary>
        [EnumMember(Value = "FaceQuality")]
        FACE_QUALITY = 3,

        /// <summary>
        /// Enum EYES_CHARACTERISTICS for value: EyesCharacteristics
        /// </summary>
        [EnumMember(Value = "EyesCharacteristics")]
        EYES_CHARACTERISTICS = 4,

        /// <summary>
        /// Enum SHADOWS_AND_LIGHTNING for value: ShadowsAndLightning
        /// </summary>
        [EnumMember(Value = "ShadowsAndLightning")]
        SHADOWS_AND_LIGHTNING = 5,

        /// <summary>
        /// Enum POSE_AND_EXPRESSION for value: PoseAndExpression
        /// </summary>
        [EnumMember(Value = "PoseAndExpression")]
        POSE_AND_EXPRESSION = 6,

        /// <summary>
        /// Enum HEAD_OCCLUSION for value: HeadOcclusion
        /// </summary>
        [EnumMember(Value = "HeadOcclusion")]
        HEAD_OCCLUSION = 7,

        /// <summary>
        /// Enum BACKGROUND for value: Background
        /// </summary>
        [EnumMember(Value = "Background")]
        BACKGROUND = 8

    }

}
