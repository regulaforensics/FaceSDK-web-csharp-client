using Regula.FaceSDK.WebClient.Client;
using Regula.FaceSDK.WebClient.Ext;
using RestSharp;

namespace Regula.FaceSDK.WebClient.Api
{
    public class FaceSdk
    {
        public ApiClient ApiClient { get; }

        public MatchingApi MatchingApi { get; }
        public GroupApiGateway GroupApi { get; }
        public PersonApiGateway PersonApi { get; }
        public SearchApi SearchApi { get; }

        public FaceSdk(string basePath) 
        {
            var config = new Configuration();
            basePath = string.IsNullOrEmpty(basePath) ? config.BasePath : basePath;
            config.BasePath = basePath;
            this.ApiClient = new ApiClient(config.BasePath);
            this.MatchingApi = new MatchingApi(config);
            this.GroupApi = new GroupApiGateway(config);
            this.PersonApi = new PersonApiGateway(config);
            this.SearchApi = new SearchApiGateway(config);
        }
    }
}