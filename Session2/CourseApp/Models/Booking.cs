using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int UserCourseID { get; set; }
        [ForeignKey("UserCourseID")]

        public Cart UserCourse { get; set; }

    }

}
