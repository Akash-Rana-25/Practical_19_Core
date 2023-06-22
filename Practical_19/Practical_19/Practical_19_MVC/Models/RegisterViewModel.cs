using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Practical_19_MVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string? Firstname { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email address is invalid")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }
    }
}

