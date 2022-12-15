using DataLayer.Repositories;
using DataLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSunnyParadiseDBContext(this IServiceCollection service, string connectionString)
        {
            service.AddDbContext<SunnyParadiseDBContext>(options =>
            {
                options.UseSqlServer(connectionString, options => options.MigrationsAssembly("DataLayer"));
            });
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IHotelRepository, HotelRepository>();
            service.AddScoped<IResortRepository, ResortRepository>();
            service.AddScoped<IOrderRepository, OrderRepository>();
            return service;
        }
    }
}
