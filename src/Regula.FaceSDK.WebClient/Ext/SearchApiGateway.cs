using System;
using Regula.FaceSDK.WebClient.Api;
using Regula.FaceSDK.WebClient.Model;

namespace Regula.FaceSDK.WebClient.Ext
{
	public class SearchApiGateway : SearchApi
    {
        public SearchApiGateway() : base() { }
        public SearchApiGateway(String basePath) : base(basePath) { }
        public SearchApiGateway(Regula.FaceSDK.WebClient.Client.Configuration configuration = null) : base(configuration) { }
    }
}

