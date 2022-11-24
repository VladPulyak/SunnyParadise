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
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(q => q.Id);
            builder.Property(q=>q.FirstName).IsRequired().HasMaxLength(40);
            builder.Property(q=>q.LastName).IsRequired().HasMaxLength(40);
            builder.Property(q => q.Email).IsRequired().HasMaxLength(40);
            builder.Property(q=>q.BirthDate).IsRequired();
            builder.HasIndex(q => new
            {
                q.Email
            }).IsUnique();
        }
    }
}
