namespace FavoriteRestaurant.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }
    public string Name { get; set; }
    public string PriceRange { get; set; }
    public string Delivery { get; set; }
    public string Takeout { get; set; }
    public string DineIn { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string PassedHealthInspection { get; set; }
  }
}