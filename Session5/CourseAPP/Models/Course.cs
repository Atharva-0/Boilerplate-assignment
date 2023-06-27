using CourseApp.Constants;
using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public double CoursePrice { get; set; }

        public CourseCategory CourseCategory { get; set; }

        public string ImageURL { get; set; }
        //Relationships
        public List<Cart> UserCourse { get; set; }

    }

}
