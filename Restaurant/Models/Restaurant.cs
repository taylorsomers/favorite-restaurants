using System.ComponentModel;

namespace FavoriteRestaurant.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }
    [DisplayName("Restaurant Name:")]
    public string Name { get; set; }
    [DisplayName("Price Range:")]
    public string PriceRange { get; set; }
    [DisplayName("Do they deliver?:")]
    public string Delivery { get; set; }
    [DisplayName("Do they do takeout?:")]
    public string Takeout { get; set; }
    [DisplayName("Can I dine in?")]
    public string DineIn { get; set; }
    [DisplayName("Restaurant Address:")]
    public string Address { get; set; }
    [DisplayName("Restaurant Phone Number:")]
    public string PhoneNumber { get; set; }
    [DisplayName("Did they pass their most recent health inspection?:")]
    
    public Health PassedHealthInspection { get; set; }
    [DisplayName("What kind of cuisine does this restaurant serve?:")]
    public virtual Cuisine Cuisine { get; set; }
  }

  public enum Health
  {
    yes,
    no
  }
}