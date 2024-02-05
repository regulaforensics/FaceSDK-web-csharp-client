using System;
using System.Collections.Generic;
using Regula.FaceSDK.WebClient.Api;
using Regula.FaceSDK.WebClient.Model;

namespace Regula.FaceSDK.WebClient.Ext
{
    public class PersonApiGateway
    {
        private readonly PersonApi api;
        public PersonApiGateway(Regula.FaceSDK.WebClient.Client.Configuration configuration)
        {
            this.api = new PersonApi(configuration);
        }

        public Person CreatePerson(PersonFields personFields, string? xRequestID = default(string?), int operationIndex = 0)
        {
            personFields.Metadata ??= new Dictionary<string, object>();
            return this.api.CreatePerson(personFields, xRequestID, operationIndex);
        }

        public Image AddImageToPerson(Guid personId, ImageFields imageFields, string? xRequestID = default(string?), int operationIndex = 0)
        {
            return this.api.AddImageToPerson(personId, imageFields, xRequestID, operationIndex);
        }

        public Person GetPerson(Guid personId, string? xRequestID = default(string?), int operationIndex = 0)
        {
            return this.api.GetPerson(personId, xRequestID, operationIndex);
        }
    }
}
