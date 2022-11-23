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
    internal class ResortRepository : IResortRepository
    {
        private readonly SunnyParadiseDBContext _context;
        public ResortRepository(SunnyParadiseDBContext context)
        {
            _context = context;
        }
        public Task Add(Resort entity)
        {
            return _context.Resorts.AddAsync(entity).AsTask();
        }

        public async Task Delete(int id)
        {
            var resort = await GetById(id);
            if(resort == null)
            {
                throw new NullReferenceException("Resort not found");
            }
            _context.Resorts.Remove(resort);
        }

        public IQueryable<Resort> GetAll()
        {
            return _context.Resorts.AsQueryable();
        }

        public Task<Resort> GetById(int id)
        {
            return _context.Resorts.SingleAsync(q => q.Id == id);
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }

        public async void Update(int id, Resort entity)
        {
            var resort = await GetById(id);
            resort.Id = entity.Id;
            resort.Name= entity.Name;
            resort.Price= entity.Price;
            resort.Country= entity.Country;
            resort.City= entity.City;
        }
    }
}
