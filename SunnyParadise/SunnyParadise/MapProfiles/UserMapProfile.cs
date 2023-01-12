using AutoMapper;
using BusinessLayer.Dtos;
using SunnyParadise.Models;

namespace SunnyParadise.MapProfiles
{
    public class UserMapProfile : Profile
    {
        public UserMapProfile()
        {
            CreateMap<UserDto, UserViewModel>();
            CreateMap<UserViewModel, UserDto>();
        }
    }
}
