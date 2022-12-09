using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Configurations
{
    public class ResortConfigurations : IEntityTypeConfiguration<Resort>
    {
        public void Configure(EntityTypeBuilder<Resort> builder)
        {
            builder.ToTable("Resorts");
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Name).HasMaxLength(40).IsRequired();
            builder.Property(q => q.Country).HasMaxLength(40).IsRequired();
            builder.Property(q => q.City).HasMaxLength(40).IsRequired();
            builder.HasIndex(q => new
            {
                q.Name,
                q.Country,
                q.City
            }).IsUnique();
        }
    }
}
