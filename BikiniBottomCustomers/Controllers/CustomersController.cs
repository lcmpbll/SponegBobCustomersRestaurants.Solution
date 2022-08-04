using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using BikiniBottomCustomers.Models;
using System.Collections.Generic;
using System.Linq;

namespace BikiniBottomCustomers.Controllers
{
  public class CustomerController : Controller
  {
    private readonly BikiniBottomCustomersContext _db;

    public CustomerController(BikiniBottomCustomersContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      
      return View(_db.Customers.ToList());
    }
  }
}