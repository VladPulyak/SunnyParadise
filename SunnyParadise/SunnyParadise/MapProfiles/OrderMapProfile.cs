using AutoMapper;
using BusinessLayer.Dtos;
using SunnyParadise.Models;

namespace SunnyParadise.MapProfiles
{
    public class OrderMapProfile : Profile
    {
        public OrderMapProfile()
        {
            CreateMap<OrderDto, OrderViewModel>();
            CreateMap<OrderViewModel, OrderDto>();
        }
    }
}
