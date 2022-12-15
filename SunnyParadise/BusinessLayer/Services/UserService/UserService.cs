using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLayer.Dtos;
using BusinessLayer.Interfaces;
using DataLayer.Entities;
using DataLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public Task<UserDto> AddUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> GetUser(int id)
        {
            var user = await _userRepository.GetById(id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<List<UserDto>> GetUsers()
        {
            return await _userRepository.GetAll().ProjectTo<UserDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task UpdateUser(int id, UserDto user)
        {
            var mappingUser = _mapper.Map<User>(user);
            await _userRepository.Update(id, mappingUser);
        }
    }
}
