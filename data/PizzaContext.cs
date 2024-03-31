using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NET_EF_CORE.models;

namespace NET_EF_CORE.data
{
    public class PizzaContext :DbContext
    {
        public DbSet<Customer> Customers {get; set;} = null!;
        public DbSet<Order> Orders {get; set;} = null!;
        public DbSet<Product> Products {get; set;} = null!;
        public DbSet<OrderDetail> OderDetails {get; set;} = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=PizzaDemoDB;User Id=sa;Password=Dmt41971109;MultipleActiveResultSets=true;Encrypt=false");
        }
    }
}