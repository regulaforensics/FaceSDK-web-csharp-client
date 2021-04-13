using System;
using Regula.FaceRecognition.WebClient.Client;
using Regula.FaceRecognition.WebClient.Api;


namespace Regula.FaceRecognition.WebClient.WebClient
{
    public class FaceSdk
    {
        public ApiClient ApiClient { get; }

        public MatchingApi MatchingApi { get; }

        public FaceSdk(string basePath) 
            : this(Configuration.Default.ApiClient)
        {
            basePath = string.IsNullOrEmpty(basePath) ? Configuration.Default.BasePath : basePath;

            Configuration config = new Configuration() {BasePath = basePath};
            ApiClient = new ApiClient(){Configuration = config};
        }

        public FaceSdk(ApiClient apiClient)
        {
            Configuration config = new Configuration() {BasePath = apiClient.Configuration.BasePath};
            
            this.ApiClient = apiClient;
            this.MatchingApi = new MatchingApi(config);
        }
    }
}