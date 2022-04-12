using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public TravelApiContext(DbContextOptions<TravelApiContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Destination>()
                .HasData(
                    new Destination { DestinationId = 1, Country = "Italy", City = "Florence", Rating = 3 },
                    new Destination { DestinationId = 2, Country = "France", City = "Paris", Rating = 4 },
                    new Destination { DestinationId = 3, Country = "USA", City = "Washington DC", Rating = 1 }
                );
        }

        public DbSet<Destination> Destinations { get; set; }
    }
}