using AutoMapper;
using BusinessLayer.Dtos;
using SunnyParadise.Models;

namespace SunnyParadise.MapProfiles
{
    public class ResortMapProfile : Profile
    {
        public ResortMapProfile()
        {
            CreateMap<ResortDto, ResortViewModel>();
            CreateMap<ResortViewModel, ResortDto>();
        }
    }
}
