using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
   
    public class UserRole
    {
        
        public int RoleId { get; set; }
        public int UserId { get; set; }
    }
}
