using CourseApp.Context;
using CourseApp.Models.Course;

namespace CourseApp.Repository
{
    public interface ICourseRepository
    {

        Task<List<Course>> GetCourses();
        void  AddCourse(Course course);
        Task <Course> GetCourseById(int id);

        Task UpdateCourse(Course course);

        Task DeleteCourse(int id);

    }
}
