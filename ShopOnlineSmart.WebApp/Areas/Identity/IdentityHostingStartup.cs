using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopOnlineSmart.WebApp.Areas.Identity.Data;

[assembly: HostingStartup(typeof(ShopOnlineSmart.WebApp.Areas.Identity.IdentityHostingStartup))]
namespace ShopOnlineSmart.WebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ShopOnlineSmartContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ShopOnlineSmartContextConnection")));

                services.AddDefaultIdentity<ShopOnlineSmartUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ShopOnlineSmartContext>();
            });
        }
    }
}