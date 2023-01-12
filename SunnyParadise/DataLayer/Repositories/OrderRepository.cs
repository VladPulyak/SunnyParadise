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
    internal class OrderRepository : IOrderRepository
    {
        private readonly SunnyParadiseDBContext _context;
        public OrderRepository(SunnyParadiseDBContext context)
        {
            _context = context;
        }
        public Task Add(Order entity)
        {
            return _context.Orders.AddAsync(entity).AsTask();
        }

        public async Task Delete(int id)
        {
            var order = await GetById(id);
            if (order == null)
            {
                throw new NullReferenceException("Oder not found");
            }
            _context.Orders.Remove(order);
        }

        public IQueryable<Order> GetAll()
        {
            return _context.Orders.AsQueryable();
        }

        public async Task<Order> GetById(int id)
        {
            return await _context.Orders.SingleAsync(q => q.OrderId == id);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, Order entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
