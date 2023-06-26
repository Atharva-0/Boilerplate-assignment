using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Models.Student
{
    public class GetStudentsDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        [ForeignKey(nameof(CourseId))]
        public int CourseId { get; set; }
        
    }
}
