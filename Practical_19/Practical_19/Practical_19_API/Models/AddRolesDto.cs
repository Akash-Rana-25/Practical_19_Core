using System.ComponentModel.DataAnnotations;

namespace Practical_19_API.Models
{
public class AddRolesDto
    {
        [Required]
        public IEnumerable<string>? Roles { get; set; }
    }

}
