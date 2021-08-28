using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicDays.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MusicDays.Models
{
    public class MusicDaysContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public MusicDaysContext (DbContextOptions<MusicDaysContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<MusicDays.Models.AuditRecord> AuditRecords { get; set; }
        public DbSet<MusicDays.Models.Customer> Customers { get; set; }

    }
}
