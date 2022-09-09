using System.Collections.Generic;

namespace api.Data
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Level { get; set; }
        public PaymentType PaymentType { get; set; }
        public string Instructor { get; set; }

        // public List<Section> Sections { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}