using Microsoft.EntityFrameworkCore;

namespace FavoriteRestaurant.Models
{
  public class FavoriteRestaurantContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    public FavoriteRestaurantContext(DbContextOptions options) : base(options) { }
  }
}