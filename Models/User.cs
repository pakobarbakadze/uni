using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace uni.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string PlaceName { get; set; } = string.Empty;
    }
}
