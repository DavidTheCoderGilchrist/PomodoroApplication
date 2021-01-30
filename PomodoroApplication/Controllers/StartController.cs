using PomodoroApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PomodoroApplication.Controllers
{
    public class StartController : Controller
    {
        private AssignmentDbContext _db = new AssignmentDbContext();
        // GET: Start
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Start(int? id)
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
    }
}

