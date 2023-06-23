using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CourseId { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
