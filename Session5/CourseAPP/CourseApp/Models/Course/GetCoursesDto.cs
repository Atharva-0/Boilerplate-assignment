using CourseApp.Context;
using CourseApp.Models.Student;
using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models.Course
{
    public class GetCoursesDto
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }

        public List<GetStudentsDto>Students { get; set; }

       
    }
}
