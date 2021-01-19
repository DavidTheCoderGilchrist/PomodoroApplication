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
    public class RewardController : Controller
    {
        private RewardDbContext _db = new RewardDbContext();
        // GET: Reward/Index
        public ActionResult Index()
        {
            return View(_db.Rewards.ToList());
        }

        //GET: Reward/Create

        public ActionResult Create()
        {
            return View();
        }

        //Post: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reward reward)
        {
            if (ModelState.IsValid)
            {
                _db.Rewards.Add(reward);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reward);
        }

        //Get: Restaurant/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Reward reward = _db.Rewards.Find(id);

            if (reward == null)
            {
                return HttpNotFound();
            }
            return View(reward);
        }

        //Post: Restaurant/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Reward restaurant = _db.Rewards.Find(id);
            _db.Rewards.Remove(restaurant);
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

            Reward reward = _db.Rewards.Find(id);

            if (reward == null)
            {
                return HttpNotFound();
            }
            return View(reward);
        }

        //POST: Restaurant/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Reward reward)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(reward).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reward);
        }

        //Get Restaurant/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Reward reward = _db.Rewards.Find(id);

            if (reward == null)
            {
                return HttpNotFound();
            }
            return View(reward);
        }
    }
}