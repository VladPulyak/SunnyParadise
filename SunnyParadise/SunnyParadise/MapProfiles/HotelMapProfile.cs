using AutoMapper;
using BusinessLayer.Dtos;
using SunnyParadise.Models;

namespace SunnyParadise.MapProfiles
{
    public class HotelMapProfile : Profile
    {
        public HotelMapProfile()
        {
            CreateMap<HotelDto, HotelViewModel>();
            CreateMap<HotelViewModel, HotelDto>();
        }
    }
}
