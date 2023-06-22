using System.ComponentModel.DataAnnotations;

namespace Practical_19_API.Models
{

    public class CreateEditRoleDto
    {
        [Required]
        public string? RoleName { get; set; }
    }
}
