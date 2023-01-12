using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
	public class OrderDto
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ResortId { get; set; }
        public int HotelId { get; set; }
        public DateTime? DateOfCreating { get; set; }
        public DateTime? DateOfTrip { get; set; }
        public int CountOfDays { get; set; }

    }
}
