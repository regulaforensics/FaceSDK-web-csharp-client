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
    /// All image characteristics that can be assessed during face image quality assessment.
    /// </summary>
    /// <value>All image characteristics that can be assessed during face image quality assessment.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FaceQualityConfigName
    {
        /// <summary>
        /// Enum IMAGE_WIDTH for value: ImageWidth
        /// </summary>
        [EnumMember(Value = "ImageWidth")]
        IMAGE_WIDTH = 1,

        /// <summary>
        /// Enum IMAGE_HEIGHT for value: ImageHeight
        /// </summary>
        [EnumMember(Value = "ImageHeight")]
        IMAGE_HEIGHT = 2,

        /// <summary>
        /// Enum IMAGE_WIDTH_TO_HEIGHT for value: ImageWidthToHeight
        /// </summary>
        [EnumMember(Value = "ImageWidthToHeight")]
        IMAGE_WIDTH_TO_HEIGHT = 3,

        /// <summary>
        /// Enum IMAGE_CHANNELS_NUMBER for value: ImageChannelsNumber
        /// </summary>
        [EnumMember(Value = "ImageChannelsNumber")]
        IMAGE_CHANNELS_NUMBER = 4,

        /// <summary>
        /// Enum PADDING_RATIO for value: PaddingRatio
        /// </summary>
        [EnumMember(Value = "PaddingRatio")]
        PADDING_RATIO = 5,

        /// <summary>
        /// Enum FACE_MID_POINT_HORIZONTAL_POSITION for value: FaceMidPointHorizontalPosition
        /// </summary>
        [EnumMember(Value = "FaceMidPointHorizontalPosition")]
        FACE_MID_POINT_HORIZONTAL_POSITION = 6,

        /// <summary>
        /// Enum FACE_MID_POINT_VERTICAL_POSITION for value: FaceMidPointVerticalPosition
        /// </summary>
        [EnumMember(Value = "FaceMidPointVerticalPosition")]
        FACE_MID_POINT_VERTICAL_POSITION = 7,

        /// <summary>
        /// Enum HEAD_WIDTH_RATIO for value: HeadWidthRatio
        /// </summary>
        [EnumMember(Value = "HeadWidthRatio")]
        HEAD_WIDTH_RATIO = 8,

        /// <summary>
        /// Enum HEAD_HEIGHT_RATIO for value: HeadHeightRatio
        /// </summary>
        [EnumMember(Value = "HeadHeightRatio")]
        HEAD_HEIGHT_RATIO = 9,

        /// <summary>
        /// Enum EYES_DISTANCE for value: EyesDistance
        /// </summary>
        [EnumMember(Value = "EyesDistance")]
        EYES_DISTANCE = 10,

        /// <summary>
        /// Enum YAW for value: Yaw
        /// </summary>
        [EnumMember(Value = "Yaw")]
        YAW = 11,

        /// <summary>
        /// Enum PITCH for value: Pitch
        /// </summary>
        [EnumMember(Value = "Pitch")]
        PITCH = 12,

        /// <summary>
        /// Enum ROLL for value: Roll
        /// </summary>
        [EnumMember(Value = "Roll")]
        ROLL = 13,

        /// <summary>
        /// Enum BLUR_LEVEL for value: BlurLevel
        /// </summary>
        [EnumMember(Value = "BlurLevel")]
        BLUR_LEVEL = 14,

        /// <summary>
        /// Enum NOISE_LEVEL for value: NoiseLevel
        /// </summary>
        [EnumMember(Value = "NoiseLevel")]
        NOISE_LEVEL = 15,

        /// <summary>
        /// Enum EYE_RIGHT_CLOSED for value: EyeRightClosed
        /// </summary>
        [EnumMember(Value = "EyeRightClosed")]
        EYE_RIGHT_CLOSED = 16,

        /// <summary>
        /// Enum EYE_LEFT_CLOSED for value: EyeLeftClosed
        /// </summary>
        [EnumMember(Value = "EyeLeftClosed")]
        EYE_LEFT_CLOSED = 17,

        /// <summary>
        /// Enum EYE_RIGHT_OCCLUDED for value: EyeRightOccluded
        /// </summary>
        [EnumMember(Value = "EyeRightOccluded")]
        EYE_RIGHT_OCCLUDED = 18,

        /// <summary>
        /// Enum EYE_LEFT_OCCLUDED for value: EyeLeftOccluded
        /// </summary>
        [EnumMember(Value = "EyeLeftOccluded")]
        EYE_LEFT_OCCLUDED = 19,

        /// <summary>
        /// Enum EYES_RED for value: EyesRed
        /// </summary>
        [EnumMember(Value = "EyesRed")]
        EYES_RED = 20,

        /// <summary>
        /// Enum EYE_RIGHT_COVERED_WITH_HAIR for value: EyeRightCoveredWithHair
        /// </summary>
        [EnumMember(Value = "EyeRightCoveredWithHair")]
        EYE_RIGHT_COVERED_WITH_HAIR = 21,

        /// <summary>
        /// Enum EYE_LEFT_COVERED_WITH_HAIR for value: EyeLeftCoveredWithHair
        /// </summary>
        [EnumMember(Value = "EyeLeftCoveredWithHair")]
        EYE_LEFT_COVERED_WITH_HAIR = 22,

        /// <summary>
        /// Enum OFF_GAZE for value: OffGaze
        /// </summary>
        [EnumMember(Value = "OffGaze")]
        OFF_GAZE = 23,

        /// <summary>
        /// Enum FACE_DYNAMIC_RANGE for value: FaceDynamicRange
        /// </summary>
        [EnumMember(Value = "FaceDynamicRange")]
        FACE_DYNAMIC_RANGE = 24,

        /// <summary>
        /// Enum UNNATURAL_SKIN_TONE for value: UnnaturalSkinTone
        /// </summary>
        [EnumMember(Value = "UnnaturalSkinTone")]
        UNNATURAL_SKIN_TONE = 25,

        /// <summary>
        /// Enum TOO_DARK for value: TooDark
        /// </summary>
        [EnumMember(Value = "TooDark")]
        TOO_DARK = 26,

        /// <summary>
        /// Enum TOO_LIGHT for value: TooLight
        /// </summary>
        [EnumMember(Value = "TooLight")]
        TOO_LIGHT = 27,

        /// <summary>
        /// Enum FACE_GLARE for value: FaceGlare
        /// </summary>
        [EnumMember(Value = "FaceGlare")]
        FACE_GLARE = 28,

        /// <summary>
        /// Enum SHADOWS_ON_FACE for value: ShadowsOnFace
        /// </summary>
        [EnumMember(Value = "ShadowsOnFace")]
        SHADOWS_ON_FACE = 29,

        /// <summary>
        /// Enum DARK_GLASSES for value: DarkGlasses
        /// </summary>
        [EnumMember(Value = "DarkGlasses")]
        DARK_GLASSES = 30,

        /// <summary>
        /// Enum REFLECTION_ON_GLASSES for value: ReflectionOnGlasses
        /// </summary>
        [EnumMember(Value = "ReflectionOnGlasses")]
        REFLECTION_ON_GLASSES = 31,

        /// <summary>
        /// Enum FRAMES_TOO_HEAVY for value: FramesTooHeavy
        /// </summary>
        [EnumMember(Value = "FramesTooHeavy")]
        FRAMES_TOO_HEAVY = 32,

        /// <summary>
        /// Enum FACE_OCCLUDED for value: FaceOccluded
        /// </summary>
        [EnumMember(Value = "FaceOccluded")]
        FACE_OCCLUDED = 33,

        /// <summary>
        /// Enum HEAD_COVERING for value: HeadCovering
        /// </summary>
        [EnumMember(Value = "HeadCovering")]
        HEAD_COVERING = 34,

        /// <summary>
        /// Enum BACKGROUND_UNIFORMITY for value: BackgroundUniformity
        /// </summary>
        [EnumMember(Value = "BackgroundUniformity")]
        BACKGROUND_UNIFORMITY = 35,

        /// <summary>
        /// Enum SHADOWS_ON_BACKGROUND for value: ShadowsOnBackground
        /// </summary>
        [EnumMember(Value = "ShadowsOnBackground")]
        SHADOWS_ON_BACKGROUND = 36,

        /// <summary>
        /// Enum OTHER_FACES for value: OtherFaces
        /// </summary>
        [EnumMember(Value = "OtherFaces")]
        OTHER_FACES = 37,

        /// <summary>
        /// Enum SHOULDERS_POSE for value: ShouldersPose
        /// </summary>
        [EnumMember(Value = "ShouldersPose")]
        SHOULDERS_POSE = 38,

        /// <summary>
        /// Enum EXPRESSION_LEVEL for value: ExpressionLevel
        /// </summary>
        [EnumMember(Value = "ExpressionLevel")]
        EXPRESSION_LEVEL = 39,

        /// <summary>
        /// Enum MOUTH_OPEN for value: MouthOpen
        /// </summary>
        [EnumMember(Value = "MouthOpen")]
        MOUTH_OPEN = 40,

        /// <summary>
        /// Enum FOREHEAD_COVERING for value: ForeheadCovering
        /// </summary>
        [EnumMember(Value = "ForeheadCovering")]
        FOREHEAD_COVERING = 41,

        /// <summary>
        /// Enum SMILE for value: Smile
        /// </summary>
        [EnumMember(Value = "Smile")]
        SMILE = 42,

        /// <summary>
        /// Enum STRONG_MAKEUP for value: StrongMakeup
        /// </summary>
        [EnumMember(Value = "StrongMakeup")]
        STRONG_MAKEUP = 43,

        /// <summary>
        /// Enum HEADPHONES for value: Headphones
        /// </summary>
        [EnumMember(Value = "Headphones")]
        HEADPHONES = 44,

        /// <summary>
        /// Enum MEDICAL_MASK for value: MedicalMask
        /// </summary>
        [EnumMember(Value = "MedicalMask")]
        MEDICAL_MASK = 45,

        /// <summary>
        /// Enum BACKGROUND_COLOR_MATCH for value: BackgroundColorMatch
        /// </summary>
        [EnumMember(Value = "BackgroundColorMatch")]
        BACKGROUND_COLOR_MATCH = 46,

        /// <summary>
        /// Enum ART_FACE for value: ArtFace
        /// </summary>
        [EnumMember(Value = "ArtFace")]
        ART_FACE = 47,

        /// <summary>
        /// Enum CONTACT_LENSES for value: ContactLenses
        /// </summary>
        [EnumMember(Value = "ContactLenses")]
        CONTACT_LENSES = 48
    }

}
