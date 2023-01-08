using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configurations
{
    public class OrderConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(q=>q.OrderId);
            builder.HasOne(q => q.User).WithMany(q => q.Orders).HasForeignKey(q => q.UserId);
            builder.HasOne(q => q.Hotel).WithMany(q => q.Orders).HasForeignKey(q => q.HotelId);
            builder.HasOne(q => q.Resort).WithMany(q => q.Orders).HasForeignKey(q => q.ResortId);
        }
    }
}
