using Regula.FaceSDK.WebClient.Api;
using Regula.FaceSDK.WebClient.Model;

namespace Regula.FaceSDK.IdentificationExample
{
    internal static class Program
    {
        private const string API_BASE_PATH = "API_BASE_PATH";
        
        public static void Main(string[] args)
        {
            var apiBasePath = Environment.GetEnvironmentVariable(API_BASE_PATH) ?? "http://127.0.0.0:41101";

            var face1 = File.ReadAllBytes("resources/face_1.jpg");
            var face2 = File.ReadAllBytes("resources/face_2.jpg");

            var sdk = new FaceSdk(apiBasePath);

            var person1Id = sdk.PersonApi.CreatePerson(
                new PersonFields(name:"person1", metadata:new Dictionary<string, object>())).Id;
            var person2Id = sdk.PersonApi.CreatePerson(
                new PersonFields(name:"person1", metadata:new Dictionary<string, object>())).Id;

            sdk.PersonApi.AddImageToPerson(person1Id, new ImageFields(image:new ImageFieldsImage(content: face1)));
            sdk.PersonApi.AddImageToPerson(person2Id, new ImageFields(image:new ImageFieldsImage(content: face2)));

            var person1 = sdk.PersonApi.GetPerson(person1Id);
            var person2 = sdk.PersonApi.GetPerson(person2Id);

            var group = sdk.GroupApi.CreateGroup(new GroupToCreate(name: "group1", metadata: new Dictionary<string, object>()));

            sdk.GroupApi.UpdatePersonsInGroup(
                group.Id,
                new UpdateGroup(addItems: new List<Guid>() {person1Id, person2Id})
            );
            var searchResult = sdk.SearchApi.Search(
                new SearchRequest(
                    groupIds: new List<int>() {},
                    image: new ImageFieldsImage(content: face1),
                    limit: 10,
                    threshold: 0.8f
                    )
            );
            
            Console.WriteLine($"Person #1 {person1.Id} {person1.Name}");
            Console.WriteLine($"Person #2 {person2.Id} {person2.Name}");
            Console.WriteLine($"Group {group.Id} {group.Name}");
            Console.WriteLine(searchResult.ToString());
        }
    }
}
