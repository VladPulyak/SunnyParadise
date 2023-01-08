using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
	public class HotelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int CountOfRooms { get; set; }
        public double StandartPrice { get; set; }
        public double LuxPrice { get; set; }
    }
}
