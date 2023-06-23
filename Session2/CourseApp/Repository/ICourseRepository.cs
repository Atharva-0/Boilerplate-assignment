using CourseApp.Models;

namespace CourseApp.Repository
{
    public interface ICourseRepository
    {
        void AddCourse(Course course);


        void DelCourse(int courseId);

        List<Course> GetAllCourse();
        Course GetCourseByID(int id);
        void Update(Course course);
    }

}
