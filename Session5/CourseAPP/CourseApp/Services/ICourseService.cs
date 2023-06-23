using CourseApp.Models;

namespace CourseApp.Services
{
    public interface ICourseService
    {
        void AddCourse(Course course);
        void DelCourse(int ID);

        List<Course> GetAllCourse();
        Course GetCourseByID(int Id);
        void Update(Course course);

    }

}
