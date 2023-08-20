using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
  public class ParksLookupApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    public DbSet<User> Users { get; set; }

    public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Custer State Park", State = "South Dakota", Designation = "State Park", YearOfEstablishment = 1919 },
          new Park { ParkId = 2, Name = "Acadia National Park", State = "Maine", Designation = "National Park", YearOfEstablishment = 1919 },
          new Park { ParkId = 3, Name = "Canyonlands National Park", State = "Utah", Designation = "National Park", YearOfEstablishment = 1964 },
          new Park { ParkId = 4, Name = "Valley Forge National Historical Park", State = "Pennsylvania", Designation = "National Historical Park", YearOfEstablishment = 1976 },
          new Park { ParkId = 5, Name = "Cape Hatteras National Seashore", State = "North Carolina", Designation = "National Seashore", YearOfEstablishment = 1937 }
        );
    }
  }
}