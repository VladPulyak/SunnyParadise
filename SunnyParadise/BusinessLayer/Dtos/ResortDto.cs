using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    public class ResortDto
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
