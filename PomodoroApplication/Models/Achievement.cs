using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PomodoroApplication.Models
{
    public class Achievement
    {
        public int AchievementId { get; set; }
        public string AchievementName{ get; set; }
        public string Description { get; set; }
        public int TotalCompletes { get; set; }
        public int PointsToUnlock { get; set; }
        public bool IsUnlocked { get; set; }
        public string Message { get; set; }
    }

    public class AchievementDbContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; }
    }
}