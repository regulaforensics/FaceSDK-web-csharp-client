# Regula.FaceSDK.WebClient - the C# library for the Regula FaceSDK Web API 3.0+

[![NuGet version (Regula.FaceSDK.WebClient)](https://img.shields.io/nuget/v/Regula.FaceSDK.WebClient.svg?style=flat-square)](https://www.nuget.org/packages/Regula.FaceSDK.WebClient/)
[![OpenAPI](https://img.shields.io/badge/OpenAPI-defs-0a8c42?style=flat-square)](https://github.com/regulaforensics/FaceSDK-web-openapi)


Face recognition as easy as reading two bytes.

 - Face Matching - Compare the person holding the ID to the person pictured in the ID document (1:1)
 - Face Recognition - Find the person by his or her photo in databases / lists (1:N)
 - Liveness Detection - Perform liveness check using a selfie taken with the user’s smartphone.

If you have any problems with or questions about this client, please contact us
through a [GitHub issue](https://github.com/regulaforensics/FaceSDK-web-csharp-client/issues).
You are invited to contribute [new features, fixes, or updates](https://github.com/regulaforensics/FaceSDK-web-csharp-client/issues?q=is%3Aissue+is%3Aopen+label%3A%22help+wanted%22), large or small; We are always thrilled to receive pull requests, and do our best to process them as fast as we can. See [dev guide](./dev.md).


## Frameworks supported

- .NET Standard 2.0
- .NET Framework 4.6.1 or later
- .Net Core 2.0 or later

## Install package
`Regula.FaceSDK.WebClient` is on the NuGet Package Index:

```bash
PM> Install-Package Regula.FaceSDK.WebClient -Version 5.2.0
```

## Example of Face Matching

Performing request:

```csharp
var face1 = File.ReadAllBytes("face_1.jpg");
var face2 = File.ReadAllBytes("face_2.jpg");

var matchImage1 = new MatchImage(data: face1, type: ImageSource.LIVE);
var matchImage2 = new MatchImage(data: face1, type: ImageSource.DOCUMENT_RFID);
var matchImage3 = new MatchImage(data: face2, type: ImageSource.LIVE);

var matchingRequest = new MatchRequest(
      false, new List<MatchImage> {matchImage1, matchImage2, matchImage3}
);

var matchingResponse = sdk.MatchingApi.Match(matchingRequest);
```

Parsing results:
```csharp
foreach (var comparison in matchingResponse.Results)
   Console.WriteLine("pair({0}, {1}) similarity: {2}",
       comparison.FirstIndex, comparison.SecondIndex, comparison.Similarity);
```


You can find this sample in [the example](https://github.com/regulaforensics/FaceSDK-web-csharp-client/tree/master/src/Regula.FaceSDK.NetCoreExample).
