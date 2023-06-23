using CourseApp.Models;
using CourseApp.Repository;

namespace CourseApp.Services
{
    public class CourseService : ICourseService
    {
        readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public void AddCourse(Course course)
        {
            var productExists = _courseRepository.GetCourseByID(course.CourseID);
            if (productExists == null)
            {
                _courseRepository.AddCourse(course);
            }
        }

        public void DelCourse(int ID)
        {
            _courseRepository.DelCourse(ID)

;
        }

        public List<Course> GetAllCourse()
        {
            return _courseRepository.GetAllCourse();
        }

        public List<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public Course GetCourseByID(int id)
        {
            var product = _courseRepository.GetCourseByID(id)

;
            return product;
        }

        public void Update(Course course)
        {
            _courseRepository.Update(course);

        }

       
    }

}
