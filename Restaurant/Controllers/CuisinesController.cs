using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly RestaurantContext _db; 

    public CuisinesController(RestaurantContext db)
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