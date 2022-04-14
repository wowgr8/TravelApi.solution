namespace TravelApi.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
        // [Required]
        // [Range(0, 10, ErrorMessage = "Age must be between 0 and 10.")]
        public int Rating { get; set; }
    }
}

