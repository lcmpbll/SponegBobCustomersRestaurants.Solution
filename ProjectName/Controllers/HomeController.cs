using Microsoft.AspNetCore.Mvc;

namespace ProjectName.controller
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