using DataLayer.Entities;
using DataLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly SunnyParadiseDBContext _context;
        public UserRepository(SunnyParadiseDBContext context)
        {
            _context = context;
        }
        public Task Add(User entity)
        {
            return _context.Users.AddAsync(entity).AsTask();
        }

        public async Task Delete(int id)
        {
            var user = await GetById(id);
            if(user == null)
            {
                throw new NullReferenceException("User not found");
            }
            _context.Users.Remove(user);
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users.AsQueryable();
        }

        public async Task<User> GetById(int id)
        {
            return await _context.Users.SingleAsync(q => q.Id == id);
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }

        public async Task Update(int id, User entity)
        {
            var user = await GetById(id);
            user.FirstName = entity.FirstName;
            user.LastName = entity.LastName;
            user.Email = entity.Email;
            user.Age = entity.Age;
            user.BirthDate = entity.BirthDate;
            user.Sex = entity.Sex;
            user.Phone = entity.Phone;
            await Save();
        }
    }
}
