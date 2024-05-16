using FirstProjectMapping.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectMapping.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.HasOne(E => E.Department)
                    .WithMany(D => D.Employees);
            builder.Property(E => E.Address)
                   .HasDefaultValue("Cairo");
            builder.Property(E => E.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .IsRequired();

                   
        }
    }
}
