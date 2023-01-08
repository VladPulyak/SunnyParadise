using AutoMapper;
using BusinessLayer.Dtos;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.ResortService
{
    internal class ResortMapProfile : Profile
    {
        public ResortMapProfile()
        {
            CreateMap<Resort, ResortDto>();
            CreateMap<ResortDto, Resort>();
        }
    }
}
