using BusinessLayer.Dtos;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
	internal class UserService : IUserService
	{
		public Task<UserDto> AddUser(UserDto user)
		{
			throw new NotImplementedException();
		}

		public Task DeleteUser(int id)
		{
			throw new NotImplementedException();
		}

		public Task<UserDto> GetUserById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<UserDto>> GetUsers()
		{
			throw new NotImplementedException();
		}

		public Task<UserDto> UpdateUser(int id, UserDto user)
		{
			throw new NotImplementedException();
		}
	}
}
