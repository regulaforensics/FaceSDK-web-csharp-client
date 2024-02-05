using System;
using System.Collections.Generic;
using Regula.FaceSDK.WebClient.Api;
using Regula.FaceSDK.WebClient.Model;

namespace Regula.FaceSDK.WebClient.Ext
{
	public class GroupApiGateway
    {
        private readonly GroupApi api;
        public GroupApiGateway(Regula.FaceSDK.WebClient.Client.Configuration configuration)
        {
            this.api = new GroupApi(configuration);
        }

        public Group CreateGroup(GroupToCreate groupToCreate, string? xRequestID = default(string?), int operationIndex = 0)
        {
            groupToCreate.Metadata ??= new Dictionary<string, object>();
            return this.api.CreateGroup(groupToCreate, xRequestID,operationIndex);
        }

        public void UpdatePersonsInGroup(Guid groupId, UpdateGroup updateGroup, string? xRequestID = default(string?), int operationIndex = 0)
        {
            this.api.UpdatePersonsInGroup(groupId, updateGroup, xRequestID, operationIndex);
        }
    }
}
