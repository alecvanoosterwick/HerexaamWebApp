using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebShop.Areas.Identity.Data;
using WebShop.Data;

[assembly: HostingStartup(typeof(WebShop.Areas.Identity.IdentityHostingStartup))]
namespace WebShop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DatabaseConnection")));

                services.AddDefaultIdentity<WebShopUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                })
                    .AddEntityFrameworkStores<AuthDbContext>();
            });
        }
    }
}