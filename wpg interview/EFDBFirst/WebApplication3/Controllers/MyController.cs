
using Demo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class MyController : Controller
    {
        MyFirstDbEntities context = new MyFirstDbEntities();
        // GET: My
        public ActionResult Index()
        {
            List<Product> products = context.Products.Select(p => p).ToList();

            return View(products);
        }
    }
}