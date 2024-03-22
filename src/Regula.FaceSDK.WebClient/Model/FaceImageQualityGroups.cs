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
    /// Face image quality group types for face image quality assessment.
    /// </summary>
    /// <value>Face image quality group types for face image quality assessment.</value>
    
    public enum FaceImageQualityGroups
    {
        /// <summary>
        /// Enum IMAGE_CHARACTERISTICS for value: 1
        /// </summary>
        IMAGE_CHARACTERISTICS = 1,

        /// <summary>
        /// Enum HEAD_SIZE_AND_POSITIONS for value: 2
        /// </summary>
        HEAD_SIZE_AND_POSITIONS = 2,

        /// <summary>
        /// Enum FACE_QUALITY for value: 3
        /// </summary>
        FACE_QUALITY = 3,

        /// <summary>
        /// Enum EYES_CHARACTERISTICS for value: 4
        /// </summary>
        EYES_CHARACTERISTICS = 4,

        /// <summary>
        /// Enum SHADOWS_AND_LIGHTNING for value: 5
        /// </summary>
        SHADOWS_AND_LIGHTNING = 5,

        /// <summary>
        /// Enum POSE_AND_EXPRESSION for value: 6
        /// </summary>
        POSE_AND_EXPRESSION = 6,

        /// <summary>
        /// Enum HEAD_OCCLUSION for value: 7
        /// </summary>
        HEAD_OCCLUSION = 7,

        /// <summary>
        /// Enum BACKGROUND for value: 8
        /// </summary>
        BACKGROUND = 8

    }

}
