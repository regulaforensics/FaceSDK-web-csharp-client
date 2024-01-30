using System;
using System.Collections.Generic;
using Regula.FaceSDK.WebClient.Api;
using Regula.FaceSDK.WebClient.Model;

namespace Regula.FaceSDK.WebClient.Ext
{
    public class PersonApiGateway: PersonApi
    {
        public PersonApiGateway() : base() { }
        public PersonApiGateway(String basePath) : base(basePath) { }
        public PersonApiGateway(Regula.FaceSDK.WebClient.Client.Configuration configuration = null) : base(configuration) { }
        
        public override Person CreatePerson(PersonFields personFields, string xRequestID = null)
        {
            personFields.Metadata ??= new Dictionary<string, object>();
            return base.CreatePerson(personFields, xRequestID);
        }
    }
}
