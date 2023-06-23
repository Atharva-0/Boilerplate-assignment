using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Register
    {
        [Key]
        public int RegId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string City { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
