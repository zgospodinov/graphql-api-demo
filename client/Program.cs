using System;
using System.Threading.Tasks;

namespace client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello GraphQL!");

            await GraphQLCourseClient.GetCoursesHttpGet();
        }
    }
}
