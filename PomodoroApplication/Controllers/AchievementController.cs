using PomodoroApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PomodoroApplication.Controllers
{
    public class AchievementController : Controller
    {
        private AchievementDbContext _db = new AchievementDbContext();
        // GET: Achievement/Index
        public ActionResult Index()
        {
            return View(_db.Achievements.ToList());
        }

        //GET: Achievement/Create

        public ActionResult Create()
        {
            return View();
        }

        //Post: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Achievement achievement)
        {
            if (ModelState.IsValid)
            {
                _db.Achievements.Add(achievement);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(achievement);
        }

        //Get: Restaurant/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Achievement achievement = _db.Achievements.Find(id);

            if (achievement == null)
            {
                return HttpNotFound();
            }
            return View(achievement);
        }

        //Post: Restaurant/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Achievement restaurant = _db.Achievements.Find(id);
            _db.Achievements.Remove(restaurant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Get: Restuarant/Edit/{id}
        // Get an id from the user
        // Handle if the id is null
        // Find a Restaurant by that id
        // If the restaurant doesn't exist
        // Return the restaurant and the view
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Achievement achievement = _db.Achievements.Find(id);

            if (achievement == null)
            {
                return HttpNotFound();
            }
            return View(achievement);
        }

        //POST: Restaurant/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Achievement achievement)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(achievement).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(achievement);
        }

        //Get Restaurant/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Achievement achievement = _db.Achievements.Find(id);

            if (achievement == null)
            {
                return HttpNotFound();
            }
            return View(achievement);
        }
    }
}