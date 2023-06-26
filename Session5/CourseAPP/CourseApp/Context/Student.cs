using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Context
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        [ForeignKey(nameof(CourseId))]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
