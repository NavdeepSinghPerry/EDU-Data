using DemoSubham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class MyController : Controller
    {
        MyFirstDbEntities context = new MyFirstDbEntities();

        // GET: My
        public ActionResult Index()
        {
            var products = context.Products.Select(p => p);
            return View(products);
        }
    }
}