using System;
using System.Collections.Generic;
using Regula.FaceSDK.WebClient.Api;
using Regula.FaceSDK.WebClient.Model;

namespace Regula.FaceSDK.WebClient.Ext
{
	public class GroupApiGateway: GroupApi
    {
        public GroupApiGateway() : base() { }
        public GroupApiGateway(String basePath) : base(basePath) { }
        public GroupApiGateway(Regula.FaceSDK.WebClient.Client.Configuration configuration = null) : base(configuration) { }

        public override Group CreateGroup(GroupToCreate groupToCreate, string xRequestID = null)
        {
            groupToCreate.Metadata ??= new Dictionary<string, object>();
            return base.CreateGroup(groupToCreate, xRequestID);
        }
    }
}
