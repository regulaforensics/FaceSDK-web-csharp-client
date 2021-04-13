using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Regula.FaceRecognition.WebClient;
using Regula.FaceRecognition.WebClient.Model;
using Regula.FaceRecognition.WebClient.WebClient;

namespace Regula.FaceRecognition.NetCoreExample
{
    class Program
    {
        static readonly string API_BASE_PATH = "API_BASE_PATH";
        
        static void Main(string[] args)
        {
            var apiBasePath = Environment.GetEnvironmentVariable(API_BASE_PATH);

            if (apiBasePath == null)
            {
                apiBasePath = "http://localhost:41101";
            }

            byte[] face1 = File.ReadAllBytes("face_1.jpg");
            byte[] face2 = File.ReadAllBytes("face_2.jpg");
            
            var sdk = new FaceSdk(apiBasePath);

            var compareImage1 = new CompareImage(index: 0, data: face1, type: ImageSource.LIVE);
            var compareImage2 = new CompareImage(index: 1, data: face1, type: ImageSource.DOCUMENT_RFID);
            var compareImage3 = new CompareImage(index: 3, data: face2, type: ImageSource.LIVE);

            var compareRequest = new CompareRequest
                (thumbnails:false, images: new List<CompareImage> {compareImage1, compareImage2, compareImage3});
            
            var compareResponse = sdk.MatchingApi.Compare(compareRequest);
            
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("                         Compare Results                         ");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach (var comparison in compareResponse.Results)
            {
                Console.WriteLine("pair({0}, {1}) similarity: {2}",
                    comparison.FirstIndex, comparison.SecondIndex, comparison.Similarity);
            }
            
            var detectRequest = new DetectRequest(image: face2);
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
        }
    }
}