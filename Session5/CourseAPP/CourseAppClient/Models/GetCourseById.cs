using CourseApp.Models.Student;

namespace CourseAppClient.Models
{
    public class GetCourseById
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }

        public List<GetStudentsDto> Students { get; set; }
    }
}
