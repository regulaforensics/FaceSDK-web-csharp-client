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
    /// The result code, see enum: https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-sdk-result-code/
    /// </summary>
    /// <value>The result code, see enum: https://docs.regulaforensics.com/develop/face-sdk/web-service/development/enums/face-sdk-result-code/</value>
    public enum FaceSDKResultCode
    {
        /// <summary>
        /// Enum FACER_OK for value: 0
        /// </summary>
        FACER_OK = 0,

        /// <summary>
        /// Enum FR_IMAGE_EMPTY for value: 1
        /// </summary>
        FR_IMAGE_EMPTY = 1,

        /// <summary>
        /// Enum FR_FACE_NOT_DETECTED for value: 2
        /// </summary>
        FR_FACE_NOT_DETECTED = 2,

        /// <summary>
        /// Enum FR_LANDMARKS_NOT_DETECTED for value: 3
        /// </summary>
        FR_LANDMARKS_NOT_DETECTED = 3,

        /// <summary>
        /// Enum FR_FACE_ALIGHNER_FAILED for value: 4
        /// </summary>
        FR_FACE_ALIGHNER_FAILED = 4,

        /// <summary>
        /// Enum FR_DESCRIPTOR_EXTRACTOR_ERROR for value: 5
        /// </summary>
        FR_DESCRIPTOR_EXTRACTOR_ERROR = 5,

        /// <summary>
        /// Enum FR_IMAGE_DECODE_ERROR for value: 6
        /// </summary>
        FR_IMAGE_DECODE_ERROR = 6,

        /// <summary>
        /// Enum FR_INTERNAL_ERROR for value: 7
        /// </summary>
        FR_INTERNAL_ERROR = 7,

        /// <summary>
        /// Enum FACER_CONFIG_ERROR for value: 199
        /// </summary>
        FACER_CONFIG_ERROR = 199,

        /// <summary>
        /// Enum FACER_NO_LICENSE for value: 200
        /// </summary>
        FACER_NO_LICENSE = 200,

        /// <summary>
        /// Enum FACER_IS_NOT_INITIALIZED for value: 201
        /// </summary>
        FACER_IS_NOT_INITIALIZED = 201,

        /// <summary>
        /// Enum FACER_COMMAND_IS_NOT_SUPPORTED for value: 202
        /// </summary>
        FACER_COMMAND_IS_NOT_SUPPORTED = 202,

        /// <summary>
        /// Enum FACER_COMMAND_PARAMS_READ_ERROR for value: 203
        /// </summary>
        FACER_COMMAND_PARAMS_READ_ERROR = 203,

        /// <summary>
        /// Enum FACER_LESS_THAN_TWO_IMAGES_IN_REQUEST for value: 224
        /// </summary>
        FACER_LESS_THAN_TWO_IMAGES_IN_REQUEST = 224,

        /// <summary>
        /// Enum FACER_VIDEO_DECODE_ERROR for value: 227
        /// </summary>
        FACER_VIDEO_DECODE_ERROR = 227,

        /// <summary>
        /// Enum FACER_NOT_ENOUGH_FRAMES for value: 228
        /// </summary>
        FACER_NOT_ENOUGH_FRAMES = 228,

        /// <summary>
        /// Enum FACER_OUTPUT_IS_NOT_DEFINED for value: 229
        /// </summary>
        FACER_OUTPUT_IS_NOT_DEFINED = 229,

        /// <summary>
        /// Enum FACER_CLOSED_EYES_DETECTED for value: 230
        /// </summary>
        FACER_CLOSED_EYES_DETECTED = 230,

        /// <summary>
        /// Enum FACER_LOW_QUALITY for value: 231
        /// </summary>
        FACER_LOW_QUALITY = 231,

        /// <summary>
        /// Enum FACER_HIGH_ASYMMETRY for value: 232
        /// </summary>
        FACER_HIGH_ASYMMETRY = 232,

        /// <summary>
        /// Enum FACER_FACE_OVER_EMOTIONAL for value: 233
        /// </summary>
        FACER_FACE_OVER_EMOTIONAL = 233,

        /// <summary>
        /// Enum FACER_SUNGLASSES_DETECTED for value: 234
        /// </summary>
        FACER_SUNGLASSES_DETECTED = 234,

        /// <summary>
        /// Enum FACER_SMALL_AGE for value: 235
        /// </summary>
        FACER_SMALL_AGE = 235,

        /// <summary>
        /// Enum FACER_HEADDRESS_DETECTED for value: 236
        /// </summary>
        FACER_HEADDRESS_DETECTED = 236,

        /// <summary>
        /// Enum FACER_FACES_NOT_MATCHED for value: 237
        /// </summary>
        FACER_FACES_NOT_MATCHED = 237,

        /// <summary>
        /// Enum FACER_IMAGES_COUNT_LIMIT_EXCEEDED for value: 238
        /// </summary>
        FACER_IMAGES_COUNT_LIMIT_EXCEEDED = 238,

        /// <summary>
        /// Enum FACER_MEDICINE_MASK_DETECTED for value: 239
        /// </summary>
        FACER_MEDICINE_MASK_DETECTED = 239,

        /// <summary>
        /// Enum FACER_OCCLUSION_DETECTED for value: 240
        /// </summary>
        FACER_OCCLUSION_DETECTED = 240,

        /// <summary>
        /// Enum FACER_FOREHEAD_GLASSES_DETECTED for value: 242
        /// </summary>
        FACER_FOREHEAD_GLASSES_DETECTED = 242,

        /// <summary>
        /// Enum FACER_MOUTH_OPENED for value: 243
        /// </summary>
        FACER_MOUTH_OPENED = 243,

        /// <summary>
        /// Enum FACER_ART_MASK_DETECTED for value: 244
        /// </summary>
        FACER_ART_MASK_DETECTED = 244,

        /// <summary>
        /// Enum FACER_ELECTRONIC_DEVICE_DETECTED for value: 245
        /// </summary>
        FACER_ELECTRONIC_DEVICE_DETECTED = 245,

        /// <summary>
        /// Enum FACER_TRACK_BREAK for value: 246
        /// </summary>
        FACER_TRACK_BREAK = 246,

        /// <summary>
        /// Enum FACER_WRONG_GEO for value: 247
        /// </summary>
        FACER_WRONG_GEO = 247,

        /// <summary>
        /// Enum FACER_WRONG_OF for value: 248
        /// </summary>
        FACER_WRONG_OF = 248,

        /// <summary>
        /// Enum FACER_WRONG_VIEW for value: 249
        /// </summary>
        FACER_WRONG_VIEW = 249,

        /// <summary>
        /// Enum FACER_TIMEOUT_LIVENESS_TRANSACTION for value: 250
        /// </summary>
        FACER_TIMEOUT_LIVENESS_TRANSACTION = 250,

        /// <summary>
        /// Enum FACER_FAILED_LIVENESS_TRANSACTION for value: 251
        /// </summary>
        FACER_FAILED_LIVENESS_TRANSACTION = 251,

        /// <summary>
        /// Enum FACER_ABORTED_LIVENESS_TRANSACTION for value: 252
        /// </summary>
        FACER_ABORTED_LIVENESS_TRANSACTION = 252
    }

}
