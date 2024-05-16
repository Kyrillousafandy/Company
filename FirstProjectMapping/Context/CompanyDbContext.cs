using FirstProjectMapping.Configurations;
using FirstProjectMapping.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectMapping.Context
{
    internal class CompanyDbContext:DbContext
    {

        #region OnConfiguring and connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseSqlServer("Server = .; Database = EmployeeCompanyFirstMapping; Trusted_Connection = True;TrustServerCertificate=True");
        #endregion


        #region OnModelCreating /Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());


            base.OnModelCreating(modelBuilder);
        }
        #endregion
       
        #region Dbsets
        public DbSet<Employee> Employees { get; set; }
        public DbSet <Department> Departments { get; set; }
        #endregion

    }
}
