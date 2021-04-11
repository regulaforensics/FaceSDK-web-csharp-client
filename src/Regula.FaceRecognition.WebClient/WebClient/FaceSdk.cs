using Regula.FaceRecognition.WebClient.Client;
using Regula.FaceRecognition.WebClient.Api;


namespace Regula.FaceRecognition.WebClient.WebClient
{
    public class FaceSdk
    {
        public ApiClient apiClient { get; }

        public readonly MatchingApi MatchingApi;

        public FaceSdk(string basePath = "", bool debugging = false, bool verifyingSsl = false) : this(new ApiClient())
        {
        }

        public FaceSdk(ApiClient apiClient)
        {
            Configuration config = new Configuration(apiClient);   
            this.apiClient = apiClient;
            this.MatchingApi = new MatchingApi(this.apiClient);
        }
    }
}