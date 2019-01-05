using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiReloaded.Models;

namespace WikiReloaded.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult User()
        {
            ViewBag.Message = "Your user page.";

            return View("User/Index");
        }

        public ActionResult Publish()
        {
            ViewBag.Message = "Here you can publish your article.";

            return View();
        }


    }
}