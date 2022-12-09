using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace BusinessLayer.Dtos
{
    public class UserDto
    {
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Sex Sex { get; set; }
		public string Email { get; set; }
		public DateTime BirthDate { get; set; }
		public int Age { get; set; }
		public string Phone { get; set; }
	}
}
