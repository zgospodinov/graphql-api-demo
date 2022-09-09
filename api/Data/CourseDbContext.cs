using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Lecture> Lecture { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecture>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<Subject>("Subject")
                .HasValue<Assignment>("Assignment");
        }
    }
}