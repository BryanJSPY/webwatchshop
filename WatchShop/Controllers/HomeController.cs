using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchShop.Models;

namespace WatchShop.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public ActionResult Index(string search = "")
        {
            List<Item> listItem = dbContext.Items.Where(temp => temp.name.Contains(search)).ToList();//database
            ViewBag.search = search;
            return View(listItem);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}