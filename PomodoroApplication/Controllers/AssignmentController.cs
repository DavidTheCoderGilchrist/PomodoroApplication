using PomodoroApplication.Models;
using PomodoroApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PomodoroApplication.Controllers
{
    public class AssignmentController : Controller
    {
        private AssignmentDbContext _db = new AssignmentDbContext();

        //private AllViewModelDbContext _db = new AllViewModelDbContext()

        // GET: Assignment/Index
        public ActionResult Index()
        {
            return View(_db.Assignments.ToList());
        }

        //GET: Assignment/Create

        public ActionResult Create()
        {
            return View();
        }

        //Post: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                _db.Assignments.Add(assignment);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assignment);
        }

        //Get: Restaurant/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Assignment assignment = _db.Assignments.Find(id);

            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        //Post: Restaurant/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Assignment assignment = _db.Assignments.Find(id);
            _db.Assignments.Remove(assignment);
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

            Assignment assignment = _db.Assignments.Find(id);

            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        //POST: Restaurant/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(assignment).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assignment);
        }

        //Get Restaurant/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Assignment assignment = _db.Assignments.Find(id);

            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        public ActionResult Start(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Assignment start = _db.Assignments.Find(id);

            if (start == null)
            {
                return HttpNotFound();
            }
            return View(start);
        }

        public ActionResult Complete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Assignment assignment = _db.Assignments.Find(id);

            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        //POST: Restaurant/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Complete(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(assignment).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assignment);
        }


    }
}