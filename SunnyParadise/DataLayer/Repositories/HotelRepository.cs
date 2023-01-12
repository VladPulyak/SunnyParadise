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
    internal class HotelRepository : IHotelRepository
    {
        private readonly SunnyParadiseDBContext _context;
        public HotelRepository(SunnyParadiseDBContext context)
        {
            _context = context;
        }
        public Task Add(Hotel entity)
        {
            return _context.Hotels.AddAsync(entity).AsTask();
        }

        public async Task Delete(int id)
        {
            var hotel = await GetById(id);
            if (hotel is null)
            {
                throw new NullReferenceException("Hotel not found");
            }
            _context.Hotels.Remove(hotel);
        }

        public IQueryable<Hotel> GetAll()
        {
            return _context.Hotels.AsQueryable();
        }

        public async Task<Hotel> GetById(int id)
        {
            return await _context.Hotels.SingleAsync(q => q.Id == id);
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }

        public async Task Update(int id, Hotel entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
