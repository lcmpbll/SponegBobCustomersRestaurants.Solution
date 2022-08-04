using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Controllers
{
  public class ClassTwoController : Controller
  {
    private readonly ProjectNameContext _db;

    public CuisineController(ProjectNameContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<ClassTwo> model = _db.ClassTwo.ToList();
      return View(model);
    }
  }
}