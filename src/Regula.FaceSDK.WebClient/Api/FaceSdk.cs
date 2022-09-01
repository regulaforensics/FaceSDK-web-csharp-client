using Regula.FaceSDK.WebClient.Client;


namespace Regula.FaceSDK.WebClient.Api
{
    public class FaceSdk
    {
        public ApiClient ApiClient { get; }

        public MatchingApi MatchingApi { get; }
        public GroupApi GroupApi { get; }
        public PersonApi PersonApi { get; }
        public SearchApi SearchApi { get; }

        public FaceSdk(string basePath) 
        {
            basePath = string.IsNullOrEmpty(basePath) ? Configuration.Default.BasePath : basePath;
            Configuration config = new Configuration() {BasePath = basePath};
            this.ApiClient = new ApiClient(){Configuration = config};
            this.MatchingApi = new MatchingApi(config);
            this.GroupApi = new GroupApi(config);
            this.PersonApi = new PersonApi(config);
            this.SearchApi = new SearchApi(config);
        }

        public FaceSdk(ApiClient apiClient)
        {
            Configuration config = new Configuration() {BasePath = apiClient.Configuration.BasePath};
            
            this.ApiClient = apiClient;
            this.MatchingApi = new MatchingApi(config);
        }
    }
}