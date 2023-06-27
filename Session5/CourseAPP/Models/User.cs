using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string ConfirmPassword { get; set; }

        // Navigation property
        public ICollection<Booking> Bookings { get; set; }
    }

}
