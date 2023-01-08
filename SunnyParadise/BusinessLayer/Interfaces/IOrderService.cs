using BusinessLayer.Dtos;
using DataLayer.Entities;
using DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetOrders();
        Task<OrderDto> GetOrder(int id);
        Task AddOrder(OrderDto order);
        Task UpdateOrder(int id, OrderDto order);
        Task DeteleOrder(int id);
    }
}
