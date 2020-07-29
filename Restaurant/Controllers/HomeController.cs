using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
  public class HomeController : Controllers
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
  } 
}

