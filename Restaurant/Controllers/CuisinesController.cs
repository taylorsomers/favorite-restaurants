using Microsoft.AspNetCore.Mvc;
using FavoriteRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FavoriteRestaurant.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly FavoriteRestaurantContext _db; 

    public CuisinesController(FavoriteRestaurantContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.OrderBy(cuisine => cuisine.Type).ToList();
      return View(model);
    }

  }
}