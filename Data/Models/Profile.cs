namespace Data.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }
    }
}
