/*
 * Regula Face SDK Web API
 *
 * <a href=\"https://regulaforensics.com/products/face-recognition-sdk/  \" target=\"_blank\">Regula Face SDK</a> is a cross-platform biometric verification solution for a digital identity verification process and image quality assurance. The SDK enables convenient and reliable face capture on the client side (mobile, web, and desktop) and further processing on the client or server side.   The Face SDK includes the following features:  * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#face-detection\" target=\"_blank\">Face detection and image quality assessment</a> * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#face-comparison-11\" target=\"_blank\">Face match (1:1)</a> * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#face-identification-1n\" target=\"_blank\">Face search (1:N)</a> * <a href=\"https://docs.regulaforensics.com/develop/face-sdk/overview/introduction/#liveness-assessment\" target=\"_blank\">Liveness detection</a>  Here is the <a href=\"https://github.com/regulaforensics/FaceSDK-web-openapi  \" target=\"_blank\">OpenAPI specification on GitHub</a>.   ### Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 6.2.0
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
    /// Face detection scenario. If applied and the scenario is found, the parameters are set automatically and any other parameters mentioned in the request are ignored.  If not set, left empty, or the name is not found, the processing is performed according to the set parameters.  You can find detailed descriptions of available scenarios on the [Scenarios page](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/usage/face-detection/scenarios/).
    /// </summary>
    /// <value>Face detection scenario. If applied and the scenario is found, the parameters are set automatically and any other parameters mentioned in the request are ignored.  If not set, left empty, or the name is not found, the processing is performed according to the set parameters.  You can find detailed descriptions of available scenarios on the [Scenarios page](https://docs.regulaforensics.com/develop/face-sdk/web-service/development/usage/face-detection/scenarios/).</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FaceQualityScenarios
    {
        /// <summary>
        /// Enum OLD_MODE for value: OldMode
        /// </summary>
        [EnumMember(Value = "OldMode")]
        OLD_MODE = 1,

        /// <summary>
        /// Enum QUALITY_FULL for value: QualityFull
        /// </summary>
        [EnumMember(Value = "QualityFull")]
        QUALITY_FULL = 2,

        /// <summary>
        /// Enum QUALITY_ICAO for value: QualityICAO
        /// </summary>
        [EnumMember(Value = "QualityICAO")]
        QUALITY_ICAO = 3,

        /// <summary>
        /// Enum QUALITY_VISA_SCHENGEN for value: QualityVisaSchengen
        /// </summary>
        [EnumMember(Value = "QualityVisaSchengen")]
        QUALITY_VISA_SCHENGEN = 4,

        /// <summary>
        /// Enum QUALITY_VISA_USA for value: QualityVisaUSA
        /// </summary>
        [EnumMember(Value = "QualityVisaUSA")]
        QUALITY_VISA_USA = 5,

        /// <summary>
        /// Enum CROP_CENTRAL_FACE for value: CropCentralFace
        /// </summary>
        [EnumMember(Value = "CropCentralFace")]
        CROP_CENTRAL_FACE = 6,

        /// <summary>
        /// Enum CROP_ALL_FACES for value: CropAllFaces
        /// </summary>
        [EnumMember(Value = "CropAllFaces")]
        CROP_ALL_FACES = 7,

        /// <summary>
        /// Enum THUMBNAIL for value: Thumbnail
        /// </summary>
        [EnumMember(Value = "Thumbnail")]
        THUMBNAIL = 8,

        /// <summary>
        /// Enum EMPTY for value: 
        /// </summary>
        [EnumMember(Value = "")]
        EMPTY = 9

    }

}
