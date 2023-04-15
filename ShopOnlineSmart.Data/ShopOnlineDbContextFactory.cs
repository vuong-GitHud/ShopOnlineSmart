using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopOnlineSmart.Data.EF
{
    public class ShopOnlineDbContextFactory : IDesignTimeDbContextFactory<ShopOnlineDbContext>
    {
        public ShopOnlineDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopOnlineSmartDb");

            var optionsBuilder = new DbContextOptionsBuilder<ShopOnlineDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopOnlineDbContext(optionsBuilder.Options);
        }
    }
}
