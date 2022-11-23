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
    internal class HotelConfigurations : IEntityTypeConfiguration<Resort>
    {
        public void Configure(EntityTypeBuilder<Resort> builder)
        {
            builder.ToTable("Hotels");
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Name).HasMaxLength(40).IsRequired();
            builder.Property(q => q.City).HasMaxLength(40).IsRequired();
            builder.Property(q => q.Country).HasMaxLength(40).IsRequired();
            builder.HasIndex(q => new
            {
                q.Name,
                q.Country
            }).IsUnique();
        }
    }
}
