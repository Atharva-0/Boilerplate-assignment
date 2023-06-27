using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Login
    {
        [Key]
        public int LogId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me Next Time")]
        public bool RememberMe { get; set; }
    }
}
