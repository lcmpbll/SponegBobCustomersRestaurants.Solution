using Microsoft.AspNetCore.Mvc;

namespace BikiniBottomCustomers.controller
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}