using Microsoft.EntityFrameworkCore;
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
                options.UseSqlServer(connectionString);
            });
            return service;
        }
    }
}
