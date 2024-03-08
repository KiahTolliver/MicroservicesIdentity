using System;
using MicroservicesIdentity.Services.SessionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesIdentity.Services.SessionAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Session>().HasData(new Session
            {
                Id = 1,
                Name = "The Best Talk Ever",
                Abstract = "This talk is about X",
                SpeakerName = "Jane Doe",
                Date = DateTime.Today,
                StartTime = DateTime.Now,
                Location = "Test Room 1",
            });

            modelBuilder.Entity<Session>().HasData(new Session
            {
                Id = 2,
                Name = "The Second Best Talk Ever",
                Abstract = "This talk is about Y",
                SpeakerName = "Jane Doe",
                Date = DateTime.Today,
                StartTime = DateTime.Now,
                Location = "Test Room 2",
            });
        }
    }
}

