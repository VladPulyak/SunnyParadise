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

namespace BusinessLayer.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public Task AddOrder(OrderDto order)
        {
            var mappingOrder = _mapper.Map<Order>(order);
            return _orderRepository.Add(mappingOrder);
        }

        public Task DeteleOrder(int id)
        {
            return _orderRepository.Delete(id);
        }

        public async Task<OrderDto> GetOrder(int id)
        {
            var order = await _orderRepository.GetById(id);
            return _mapper.Map<OrderDto>(order);
        }

        public async Task<List<OrderDto>> GetOrders()
        {
            return await _orderRepository.GetAll().ProjectTo<OrderDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public Task UpdateOrder(int id, OrderDto order)
        {
            var mappingOrder = _mapper.Map<Order>(order);
            return _orderRepository.Update(id, mappingOrder);
        }
    }
}
