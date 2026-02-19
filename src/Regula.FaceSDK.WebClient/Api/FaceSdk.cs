namespace Regula.FaceSDK.WebClient.Api
{
    public class FaceSdk
    {
        public MatchApi MatchingApi { get; }
        public GroupApi GroupApi { get; }
        public PersonApi PersonApi { get; }
        public SearchApi SearchApi { get; }
        public HealthcheckApi HealthcheckApi { get; }
        public Liveness20Api LivenessApi { get; }

        public FaceSdk(string basePath) 
        {
            this.MatchingApi = new MatchApi(basePath);
            this.GroupApi = new GroupApi(basePath);
            this.PersonApi = new PersonApi(basePath);
            this.SearchApi = new SearchApi(basePath);
            this.HealthcheckApi = new HealthcheckApi(basePath);
            this.LivenessApi = new Liveness20Api(basePath);
        }
    }
}