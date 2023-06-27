using CourseApp.Context;
using CourseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Repository
{
    public class CourseRepository : ICourseRepository
    {
        ApplicationDbContext _courseappDbContext;

        //Constructor

        public CourseRepository(ApplicationDbContext courseappdbContext)
        {
            _courseappDbContext = courseappdbContext;
        }

        public void AddCourse(Course course)
        {
            _courseappDbContext.Course.Add(course);
            _courseappDbContext.SaveChanges();
        }

        public void DelCourse(int courseId)
        {
            var course = _courseappDbContext.Course.Find(courseId);
            _courseappDbContext.Course.Remove(course);
            _courseappDbContext.SaveChanges();
        }


        public void Update(Course course)
        {
            _courseappDbContext.Entry(course).State = EntityState.Modified;
            _courseappDbContext.SaveChanges();
        }

        public List<Course> GetAllCourse()
        {
            return _courseappDbContext.Course.ToList();
        }
        public Course GetCourseByID(int id)
        {
            var course = _courseappDbContext.Course.Find(id)

;
            return course;
        }

        
    }
}