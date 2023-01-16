using System.ComponentModel.DataAnnotations;

namespace SunnyParadise.Models
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        public string? UserEmail { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string HotelName { get; set; }

        [Required(ErrorMessage = "Enter CountOfDays")]
        public int CountOfDays { get; set; }

        public DateTime? DateOfCreating { get; set; }

        [Required(ErrorMessage = "Enter DateOfTrip")]
        public DateTime? DateOfTrip { get; set; }
    }
}