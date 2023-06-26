using CourseApp.Models.Student;

namespace CourseApp.Models.Course
{
    public class GetCourseByIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }

       public List<GetStudentsDto> Students { get; set; }

    }
}
