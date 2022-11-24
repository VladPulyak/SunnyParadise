using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public int? ResortId { get; set; }
        public int? HotelId { get; set; }
        public DateTime? DateOfCreating { get; set; }
        public DateTime? DateOfTrip { get; set; }
        public Hotel Hotel { get; set; }
        public Resort Resort { get; set; }
        public User User { get; set; }
    }
}
