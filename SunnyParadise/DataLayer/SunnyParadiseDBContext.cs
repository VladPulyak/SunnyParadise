using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Configurations;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class SunnyParadiseDBContext : DbContext
    {
        public SunnyParadiseDBContext()
        {

        }
        public SunnyParadiseDBContext(DbContextOptions<SunnyParadiseDBContext> options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new HotelConfigurations());
            modelBuilder.ApplyConfiguration(new OrderConfigurations());
            modelBuilder.ApplyConfiguration(new ResortConfigurations());
            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
