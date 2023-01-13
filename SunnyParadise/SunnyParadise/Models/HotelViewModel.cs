using System.ComponentModel.DataAnnotations;

namespace SunnyParadise.Models
{
    public class HotelViewModel
    {
        [Required(ErrorMessage = "Enter HotelName")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter CountOfRooms")]
        public int CountOfRooms { get; set; }

        [Required(ErrorMessage = "Enter StandartPrice")]
        public double StandartPrice { get; set; }

        [Required(ErrorMessage = "Enter LuxPrice")]
        public double LuxPrice { get; set; }
    }
}
