using Regula.FaceSDK.WebClient.Client;


namespace Regula.FaceSDK.WebClient.Api
{
    public class FaceSdk
    {
        public ApiClient ApiClient { get; }

        public MatchingApi MatchingApi { get; }

        public FaceSdk(string basePath) 
        {
            basePath = string.IsNullOrEmpty(basePath) ? Configuration.Default.BasePath : basePath;
            Configuration config = new Configuration() {BasePath = basePath};
            this.ApiClient = new ApiClient(){Configuration = config};
            this.MatchingApi = new MatchingApi(config);
        }

        public FaceSdk(ApiClient apiClient)
        {
            Configuration config = new Configuration() {BasePath = apiClient.Configuration.BasePath};
            
            this.ApiClient = apiClient;
            this.MatchingApi = new MatchingApi(config);
        }
    }
}