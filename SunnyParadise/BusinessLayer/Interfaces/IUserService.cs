using BusinessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
	internal interface IUserService
	{
		Task<List<UserDto>> GetUsers();
		Task<UserDto> GetUserById(int id);
		Task<UserDto> AddUser(UserDto user);
		Task<UserDto> UpdateUser(int id, UserDto user);
		Task DeleteUser(int id);
	}
}
