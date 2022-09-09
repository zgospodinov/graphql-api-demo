using System;
using System.Threading.Tasks;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace client
{
    public class GraphQLCourseClient
    {
        public static async Task GetCoursesHttpGet()
        {
            var graphQlClient = new GraphQLHttpClient(
                new Uri("https://localhost:5007/graphql/getcourses"),
                new NewtonsoftJsonSerializer()
            );

            // var qString = "{courses {instructor, title, duration, ratings{studentName, starValue, review}}}";
            var qString = "{course(id:1) {instructor, title, duration, ratings{studentName, starValue, review}}}";

            var response = await graphQlClient.HttpClient.GetAsync(@"https://localhost:5007/graphql/getcourses?query= " + qString);

            var resutl = response.Content.ReadAsStringAsync();
            Console.WriteLine(resutl.Result);
            Console.ReadKey();
        }
    }
}