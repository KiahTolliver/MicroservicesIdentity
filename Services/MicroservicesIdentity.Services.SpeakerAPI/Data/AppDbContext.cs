using System;
using MicroservicesIdentity.Services.SpeakerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesIdentity.Services.SpeakerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Speaker>().HasData(new Speaker
            {
                Id = 1,
                Name = "Jane Doe",
                EmailAddress = "abc123@gmail.com",
                Company = "ABC Corp",
                Bio = "This speaker is dope"
            });

            modelBuilder.Entity<Speaker>().HasData(new Speaker
            {
                Id = 2,
                Name = "John Doe",
                EmailAddress = "abc456@gmail.com",
                Company = "XYZ Corp",
                Bio = "This speaker is super dope"
            });
        }
    }
}

