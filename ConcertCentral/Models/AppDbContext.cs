using Microsoft.EntityFrameworkCore;
using ConcertCentral.Models;

namespace ConcertCentral.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }

        public DbSet<Concert> Concert { get; set; }
        public DbSet<Band> Band { get; set; }
        public DbSet<EventPlanner> EventPlanner { get; set; }
        public DbSet<ContactUsForm> ContactUsForm {get;set;}

    }
}