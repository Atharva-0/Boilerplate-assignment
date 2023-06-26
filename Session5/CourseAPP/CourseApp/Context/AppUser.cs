using Microsoft.AspNetCore.Identity;

namespace CourseApp.Context
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }   
    }
}
