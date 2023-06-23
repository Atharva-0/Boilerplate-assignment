using CourseApp.Configuration;
using CourseApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Xml;

namespace CourseApp.Context
{
    public class ApplicationDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {
        }
         protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder
    .Entity<UserRole>(builder =>
    {
        builder.HasNoKey();
        //builder.ToTable("MY_ENTITY");
    });
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }
        public DbSet<Booking> Booking { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<Emailtbl> Emails { get; set; }

    }
}
