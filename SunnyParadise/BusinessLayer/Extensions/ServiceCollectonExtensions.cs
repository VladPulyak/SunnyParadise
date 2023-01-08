using BusinessLayer.Interfaces;
using BusinessLayer.Services.HotelService;
using BusinessLayer.Services.OrderService;
using BusinessLayer.Services.ResortService;
using BusinessLayer.Services.UserService;
using DataLayer.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
    public static class ServiceCollectonExtensions 
    {
        public static IServiceCollection AddServices(this IServiceCollection services, string connectionString)
        {
            services.AddSunnyParadiseDBContext(connectionString);
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<IResortService, ResortService>();
            services.AddAutoMapper(Assembly.GetCallingAssembly(),
                       Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
