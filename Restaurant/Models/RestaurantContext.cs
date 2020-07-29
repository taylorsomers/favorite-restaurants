using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
  public class RestaurantContext : DbContext
  {
    public DbSet<Restaurant> Restaurant { get; set; }

    public RestaurantContext(DbContextOptions options) : base(options) { }
  }
}