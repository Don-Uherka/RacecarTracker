using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Racecar_Tracker_By_UherkaMotorsports.Models;

namespace Racecar_Tracker_By_UherkaMotorsports.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Racecar_Tracker_By_UherkaMotorsports.Models.Track> Track { get; set; }
        public DbSet<Racecar_Tracker_By_UherkaMotorsports.Models.Crew> Crew { get; set; }
    }
}
