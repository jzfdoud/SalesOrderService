using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesOrderService.Models;

namespace SalesOrderService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }


        protected override void OnModelCreating(ModelBuilder builder) { }

        public DbSet<SalesOrderService.Models.Item> Item { get; set; }

        public DbSet<SalesOrderService.Models.OrderItem> OrderItem { get; set; }
    }
}
