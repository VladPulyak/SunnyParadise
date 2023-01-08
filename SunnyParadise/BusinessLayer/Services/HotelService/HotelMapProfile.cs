using AutoMapper;
using BusinessLayer.Dtos;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.HotelService
{
    internal class HotelMapProfile : Profile
    {
        public HotelMapProfile()
        {
            CreateMap<HotelDto, Hotel>();
            CreateMap<Hotel, HotelDto>();
        }
    }
}
