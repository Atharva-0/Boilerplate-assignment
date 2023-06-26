using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models.Users
{
    public class ApiUserDto
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }   
        public string Password { get; set; }
    }
}
