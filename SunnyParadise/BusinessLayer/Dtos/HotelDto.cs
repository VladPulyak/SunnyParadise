using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    internal class HotelDto
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int CountOfRooms { get; set; }
    }
}
