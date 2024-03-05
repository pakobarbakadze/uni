using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace uni.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        public required string FirstName { get; set; }
        public required string LastName { get; set; } = string.Empty;
        public required string PlaceName { get; set; } = string.Empty;

    }
}