using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Regula.FaceSDK.WebClient.Api;
using Regula.FaceSDK.WebClient.Model;

namespace Regula.FaceSDK.NetCoreExample
{
    internal class Program
    {
        private const string API_BASE_PATH = "API_BASE_PATH";

        private static void Main(string[] args)
        {
            var apiBasePath = Environment.GetEnvironmentVariable(API_BASE_PATH) ?? "https://faceapi.regulaforensics.com";

            var face1 = File.ReadAllBytes("resources/face_1.jpg");
            var face2 = File.ReadAllBytes("resources/face_2.jpg");

            var sdk = new FaceSdk(apiBasePath);

            var matchImage1 = new MatchImage(data: face1, type: ImageSource.LIVE);
            var matchImage2 = new MatchImage(data: face1, type: ImageSource.DOCUMENT_RFID);
            var matchImage3 = new MatchImage(data: face2, type: ImageSource.LIVE);

            var matchingRequest = new MatchRequest(tag: Guid.NewGuid().ToString(),
                thumbnails:false, images:new List<MatchImage> {matchImage1, matchImage2, matchImage3}
            );

            var matchingResponse = sdk.MatchingApi.Match(matchingRequest);

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("                         Matching Results                         ");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (var comparison in matchingResponse.Results)
                Console.WriteLine("pair({0}, {1}) similarity: {2}",
                    comparison.FirstIndex, comparison.SecondIndex, comparison.Similarity);

            var detectRequest = new DetectRequest(tag: Guid.NewGuid().ToString(), image:face2);
            var detectResponse = sdk.MatchingApi.Detect(detectRequest);
            var detectResults = detectResponse.Results;

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("                         Detect Results                          ");
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("detectorType: {0}", detectResults.DetectorType);
            Console.WriteLine("landmarkType: {0}", detectResults.LandmarksType);
            foreach (var detection in detectResults.Detections)
            {
                Console.WriteLine("landmarks: [{0}]",
                    string.Join(", ", detection.Landmarks.Select(landmark =>
                        $"[{string.Join(", ", landmark)}]").ToList()));

                Console.WriteLine("roi: [{0}]", string.Join(", ", detection.Roi.ToArray()));
                Console.WriteLine("attributes: {0}",
                    string.IsNullOrEmpty(detection.Attributes?.ToString()) ? "null" : detection.Attributes.ToString());
            }
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("                       Face Image Quality Results                ");
            Console.WriteLine("-----------------------------------------------------------------");
            var detectImageQualityRequest = new DetectRequest(
                processParam: new ProcessParam(
                    scenario: FaceQualityScenarios.QUALITY_ICAO, 
                    onlyCentralFace: true
                ), 
                image: face1
            );
            var detectImageQualityResponse = sdk.MatchingApi.Detect(detectImageQualityRequest);
            var detectImageQualityResults = detectImageQualityResponse.Results;
            Console.WriteLine("Code: {0}", detectImageQualityResponse.Code);
            Console.WriteLine("Scenario: {0}", detectImageQualityResults.Scenario);
            foreach (var detection in detectImageQualityResults.Detections){
                Console.WriteLine("Landmarks: [{0}]",
                    string.Join(", ", detection.Landmarks.Select(landmark =>
                        $"[{string.Join(", ", landmark)}]").ToList()));
                Console.WriteLine("Quality: [{0}], count: {1}", string.Join(", ", detection.Quality.Details.ToString()), detection.Quality.Details.ToArray().Length);
                Console.WriteLine("Attributes: {0}",
                    string.IsNullOrEmpty(detection.Attributes.Details?.ToString()) ? "null" : detection.Attributes.Details.ToString());
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}