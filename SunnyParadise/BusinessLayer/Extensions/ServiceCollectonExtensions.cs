using BusinessLayer.Interfaces;
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
            services.AddAutoMapper(Assembly.GetCallingAssembly(),
                       Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
