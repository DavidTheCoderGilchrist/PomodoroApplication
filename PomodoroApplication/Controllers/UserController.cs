using PomodoroApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PomodoroApplication.Controllers
{
    public class UserController : Controller
    {
        private UserDbContext _db = new UserDbContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        //GET: Assignment/Create

        public ActionResult Create()
        {
            return View();
        }

        //Post: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }
    }
}