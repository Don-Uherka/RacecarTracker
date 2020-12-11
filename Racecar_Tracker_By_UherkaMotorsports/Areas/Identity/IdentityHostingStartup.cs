using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Racecar_Tracker_By_UherkaMotorsports.Data;

[assembly: HostingStartup(typeof(Racecar_Tracker_By_UherkaMotorsports.Areas.Identity.IdentityHostingStartup))]
namespace Racecar_Tracker_By_UherkaMotorsports.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}