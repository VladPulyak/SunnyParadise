using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Resort
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public float Price { get; set; }
        public int CountOfDays { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
