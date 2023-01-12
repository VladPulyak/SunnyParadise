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

        public async Task AddResort(ResortDto resort)
        {
            var mappingResort = _mapper.Map<Resort>(resort);
            await _resortRepository.Add(mappingResort);
            await _resortRepository.Save();
        }

        public async Task DeleteResort(int id)
        {
            await _resortRepository.Delete(id);
            await _resortRepository.Save();
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

        public async Task UpdateResort(int id, ResortDto resort)
        {
            var mappingResort = _mapper.Map<Resort>(resort);
            await _resortRepository.Update(id, mappingResort);
            await _resortRepository.Save();
        }
    }
}
