namespace uni.Dtos
{
    public class AddStudentDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; } = string.Empty;
        public required string PlaceName { get; set; } = string.Empty;
    }
}