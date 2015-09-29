using EFOptimization.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFOptimization.Controllers
{
  public class QueryController : Controller
  {
    // GET: Query
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Test1()
    {
      var awContext = new AdventureWorks();

      var customers = awContext.Customers.ToList();

      var customer = customers.Where(x => x.CustomerID == 10).Select(x => x);

      return View("Index");
    }

    public ActionResult Test2()
    {
      var awContext = new AdventureWorks();

      var customer = awContext.Customers.Where(x => x.CustomerID == 10).Single();

      return View("Index");
    }

    public ActionResult Test3()
    {
      var awContext = new AdventureWorks();

      var customer = awContext.Customers.Where(x => x.CustomerID == 29825).First();
      var orders = customer.SalesOrderHeaders.ToList();

      var total = orders.Sum(x => x.SubTotal);


      return View("Index");
    }
  }
}