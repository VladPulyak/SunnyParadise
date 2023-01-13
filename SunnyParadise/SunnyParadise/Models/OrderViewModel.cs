namespace SunnyParadise.Models
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public string UserEmail { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string HotelName { get; set; }
        public int CountOfDays { get; set; }
        public DateTime? DateOfCreating { get; set; }
        public DateTime? DateOfTrip { get; set; }
    }
}