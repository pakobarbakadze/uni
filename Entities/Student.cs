namespace uni.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; } = string.Empty;
        public required string PlaceName { get; set; } = string.Empty;

    }
}