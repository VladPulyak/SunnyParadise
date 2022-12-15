using BusinessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
	public interface IUserService
	{
		Task<List<UserDto>> GetUsers();
		Task<UserDto> GetUser(int id);
		Task<UserDto> AddUser(UserDto user);
		Task UpdateUser(int id, UserDto user);
		Task DeleteUser(int id);
	}
}
