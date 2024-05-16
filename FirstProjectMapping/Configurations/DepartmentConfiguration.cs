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
    internal class DepartmentConfiguration:IEntityTypeConfiguration <Department>
    {


        public void Configure(EntityTypeBuilder<Department> builder)
        {

            builder.HasKey(D => D.DeptId);
            builder.Property(D => D.DeptId)
                   .UseIdentityColumn(10, 10);
            builder.Property(D => D.Name)
                   .IsRequired(true)
                   .HasColumnType("varchar")
                   .HasColumnName("DepartmentName")
                   .HasMaxLength(50)
                   .HasDefaultValue("Asp.net");
            builder.Property(D => D.DateOfCreation)
                   .HasComputedColumnSql("GETDATE()");
        }
    }
}
