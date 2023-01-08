using BusinessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IResortService
    {
        Task<List<ResortDto>> GetResorts();
        Task<ResortDto> GetResort(int id);
        Task AddResort(ResortDto resort);
        Task UpdateResort(int id, ResortDto resort);
        Task DeleteResort(int id);

    }
}
