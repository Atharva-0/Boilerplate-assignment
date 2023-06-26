using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace CourseApp.Context
{
    public class CourseDbContext :IdentityDbContext<AppUser>
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> Context) :base(Context)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "Dotnet",
                    Price = 200,
                    Description ="This is one course"
                },
                new Course
                {
                    Id = 2,
                    Name = "Java",
                    Price = 600,
                    Description = "This is one course"
                });


            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    StudentName = "Himanshu",
                    CourseId = 1,
                    
                },
                new Student
                {
                    StudentId = 2,
                    StudentName = "Juber",
                    CourseId = 2,
                });


        }

    }
}
