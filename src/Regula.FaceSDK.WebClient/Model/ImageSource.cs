/*
 * Regula FaceSDK Web API
 *
 * Regula FaceSDK Web API # Clients * [JavaScript](https://github.com/regulaforensics/FaceSDK-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/FaceSDK-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/FaceSDK-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/FaceSDK-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 4.1.0
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
    /// Face photo image source.
    /// </summary>
    /// <value>Face photo image source.</value>
    
    public enum ImageSource
    {
        /// <summary>
        /// Enum DOCUMENT_PRINTED for value: 1
        /// </summary>
        DOCUMENT_PRINTED = 1,

        /// <summary>
        /// Enum DOCUMENT_RFID for value: 2
        /// </summary>
        DOCUMENT_RFID = 2,

        /// <summary>
        /// Enum LIVE for value: 3
        /// </summary>
        LIVE = 3,

        /// <summary>
        /// Enum DOCUMENT_WITH_LIVE for value: 4
        /// </summary>
        DOCUMENT_WITH_LIVE = 4,

        /// <summary>
        /// Enum EXTERNAL for value: 5
        /// </summary>
        EXTERNAL = 5

    }

}
