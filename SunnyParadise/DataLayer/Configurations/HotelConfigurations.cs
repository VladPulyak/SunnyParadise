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
    public class HotelConfigurations : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotels");
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Name).HasMaxLength(40).IsRequired();
            builder.Property(q => q.City).HasMaxLength(40).IsRequired();
            builder.Property(q => q.Country).HasMaxLength(40).IsRequired();
            builder.HasIndex(q => new
            {
                q.Name,
                q.Country,
                q.City
            }).IsUnique();
        }
    }
}
