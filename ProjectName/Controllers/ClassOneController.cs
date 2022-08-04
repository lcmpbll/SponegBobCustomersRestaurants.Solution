using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Controllers
{
  public class ClassOneController : Controller
  {
    private readonly ProjectNameContext _db;

    public ClassOneController(ProjectNameContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<ClassOne> model = _db.ClassOnes.Include(classOne => classOne.ClassTwo).ToList();
      return View(model);
    }
  }
}