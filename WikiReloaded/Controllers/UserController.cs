using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiReloaded.Models;
using System.Diagnostics;

namespace WikiReloaded.Controllers
{
    public class UserController : Controller
    {

        private UserDBContext db = new UserDBContext();
        private int userCount = 0;

        // GET: User
        public ActionResult Index()
        {
            var users = from user in db.Users
                           orderby user.name
                           select user;
            ViewBag.Users = users;
            return View();
        }
        public ActionResult Show(int id)
        {
            User user = db.Users.Find(id);
            ViewBag.Users = user;
            return View();
        }


        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(User user)
        {
            try
            {
                user.role = "User";
                user.Id = userCount++;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Debug.WriteLine(user.name);
                Debug.WriteLine(user.password);
                Debug.WriteLine(user.Id);
                Debug.WriteLine(e);
                return View();
            }

        }
    }
}