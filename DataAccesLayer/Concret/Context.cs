using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using EntityLayer.Concrete;
using DataAccesLayer.Concret;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccesLayer.Concrete
{
    public  class Context : IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=UMUTARDAVURAL\\SQLEXPRESS;database=DbOopCore;integrated security=true;TrustServerCertificate=True");



        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }  

        public DbSet<Catagory>  Catagories { get; set; }

        public DbSet<Job> Jobs { get; set; }

    }
}
