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

namespace BusinessLayer.Services.HotelService
{
    internal class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;
        public HotelService(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }
        public async Task AddHotel(HotelDto hotel)
        {
            var mappingHotel = _mapper.Map<Hotel>(hotel);
            await _hotelRepository.Add(mappingHotel);
            await _hotelRepository.Save();
        }

        public async Task DeleteHotel(int id)
        {
            await _hotelRepository.Delete(id);
            await _hotelRepository.Save();
        }

        public async Task<HotelDto> GetHotel(int id)
        {
            var hotel = await _hotelRepository.GetById(id);
            return _mapper.Map<HotelDto>(hotel);
        }

        public async Task<List<HotelDto>> GetHotels()
        {
            return await _hotelRepository.GetAll().ProjectTo<HotelDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task UpdateHotel(int id, HotelDto hotel)
        {
            var mappingHotel = _mapper.Map<Hotel>(hotel);
            await _hotelRepository.Update(id, mappingHotel);
            await _hotelRepository.Save();
        }
    }
}
