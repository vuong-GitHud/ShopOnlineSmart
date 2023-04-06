using Microsoft.EntityFrameworkCore;
using ShopOnlineSmart.Data.Configuration;
using ShopOnlineSmart.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineSmart.Data.EF
{
    public class ShopOnlineDbContext : DbContext
    {
        public ShopOnlineDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());

        }
    }
}
