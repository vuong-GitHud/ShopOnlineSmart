using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlineSmart.Data.EF
{
    public class ShopOlineDbContextFactory : IDesignTimeDbContextFactory<ShopOnlineDbContext>
    {
        public ShopOnlineDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopOnlineDb");

            var optionsBuilder = new DbContextOptionsBuilder<ShopOnlineDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopOnlineDbContext(optionsBuilder.Options);
        }
    }
}
