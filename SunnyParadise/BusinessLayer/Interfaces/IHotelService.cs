using BusinessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IHotelService
    {
        Task<List<HotelDto>> GetHotels();
        Task<HotelDto> GetHotel(int id);
        Task AddHotel(HotelDto hotel);
        Task UpdateHotel(int id, HotelDto hotel);
        Task DeleteHotel(int id);

    }
}
