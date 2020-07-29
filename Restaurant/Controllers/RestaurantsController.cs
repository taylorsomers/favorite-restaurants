using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FavoriteRestaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace FavoriteRestaurant.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly FavoriteRestaurantContext _db;

    public RestaurantsController(FavoriteRestaurantContext db)
    {
      _db = db;
    }

    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Type");
      return View();
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.Include(restaurants => restaurants.Cuisine).ToList();
      model.OrderBy(restaurants => restaurants.Name);
      return View(model);
    }
  }
}