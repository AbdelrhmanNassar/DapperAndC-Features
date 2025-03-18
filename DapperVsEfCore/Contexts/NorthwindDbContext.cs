using DapperVsEfCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperVsEfCore.Contexts
{
    internal class NorthwindDbContext : DbContext
    {


//        public DbSet<Product> products;

        public DbSet<Product> products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                //Connect on sql server 
                //exaplin process from creating object from dbcontext until configuring then 
                optionsBuilder.UseSqlServer("Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;");
           
        }
    }
}
