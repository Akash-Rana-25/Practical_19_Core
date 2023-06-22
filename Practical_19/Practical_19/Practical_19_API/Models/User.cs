using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practical_19_API.Models
{

    public class User : IdentityUser
    {
        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string? FirstName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string? LastName { get; set; }
    }
}
