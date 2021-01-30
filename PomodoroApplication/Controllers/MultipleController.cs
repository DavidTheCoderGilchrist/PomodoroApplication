using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Dynamic;
using PomodoroApplication.Models;

namespace PomodoroApplication.Controllers
{
    public class MultipleController : Controller
    {
        // GET: Multiple
        public ActionResult Index()
        {
            dynamic dy = new ExpandoObject();
            dy.assignmentlist = GetAssignments();
            dy.rewardlist = GetRewards();
            dy.achievementlist = GetAchievements();
            return View(dy);
        }

        public List<Assignment> GetAssignments()
        {
            AssignmentDbContext _db = new AssignmentDbContext();
            List<Assignment> assignment = _db.Assignments.ToList();
            return assignment;
        }

        public List<Reward> GetRewards()
        {
            RewardDbContext _db = new RewardDbContext();
            List<Reward> rewards = _db.Rewards.ToList();
            return rewards;
        }

        public List<Achievement> GetAchievements()
        {
            AchievementDbContext _db = new AchievementDbContext();
            List<Achievement> achievements = _db.Achievements.ToList();
            return achievements;
        }
    }
}