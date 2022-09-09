using System.Collections.Generic;
using System.Linq;
using api.Data;
using GraphQL;

namespace api.Queries
{
    public class Query
    {
        [GraphQLMetadata("courses")]
        public List<Course> GetCourse()
        {
            return CourseData();
        }

        [GraphQLMetadata("course")]
        public Course GetSingleCourse(int id)
        {
            var courses = GetCourse();
            return courses.Where(c => c.Id == id).FirstOrDefault();
        }



        private List<Course> CourseData()
        {
            var courses = new List<Course>
            {
                new Course{Id = 1, Title = " Fastest Microservices", Duration = 540, Level = "All", Instructor = "SeedACloud", PaymentType = PaymentType.PAID, Ratings = GetRating(1)},
                new Course{Id = 2, Title = " Software Architecture", Duration = 540, Level = "Beginner", Instructor = "Scree", PaymentType = PaymentType.FREE, Ratings = GetRating(2)}
            };

            return courses;
        }

        private List<Rating> GetRating(int courseId)
        {
            var ratings = new List<Rating> {
                new Rating{StudentName = "Mark", StarValue = 5, Review = "Very useful", CourseId = 1},
                new Rating{StudentName = "Cesar", StarValue = 2, Review = "Not good", CourseId = 1},
                new Rating{StudentName = "Boo", StarValue = 4, Review = "Very useful", CourseId = 3},
            };
            return ratings.Where(r => r.Id == courseId).ToList();
        }
    }
}