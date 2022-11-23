using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    internal class ResortDto
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public float Price { get; set; }
    }
}
