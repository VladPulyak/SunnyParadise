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

namespace BusinessLayer.Services.ResortService
{
    public class ResortService : IResortService
    {
        private readonly IMapper _mapper;
        private readonly IResortRepository _resortRepository;
        public ResortService(IResortRepository resortRepository, IMapper mapper)
        {
            _resortRepository = resortRepository;
            _mapper = mapper;
        }

        public Task AddResort(ResortDto resort)
        {
            var mappingResort = _mapper.Map<Resort>(resort);
            return _resortRepository.Add(mappingResort);
        }

        public Task DeleteResort(int id)
        {
            return _resortRepository.Delete(id);
        }

        public async Task<ResortDto> GetResort(int id)
        {
            var resort = await _resortRepository.GetById(id);
            return _mapper.Map<ResortDto>(resort);
        }

        public async Task<List<ResortDto>> GetResorts()
        {
            return await _resortRepository.GetAll().ProjectTo<ResortDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public Task UpdateResort(int id, ResortDto resort)
        {
            var mappingResort = _mapper.Map<Resort>(resort);
            return _resortRepository.Update(id, mappingResort);
        }
    }
}
