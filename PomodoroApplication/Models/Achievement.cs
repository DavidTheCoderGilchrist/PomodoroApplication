using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PomodoroApplication.Models
{
    public class Achievement
    {
        public int AchievementId { get; set; }
        [DisplayName("Achievement")]
        public string AchievementName{ get; set; }
        public string Description { get; set; }
        [DisplayName("Total Completes")]
        public int TotalCompletes { get; set; }
        [DisplayName("Remaining Points")]
        public int PointsToUnlock { get; set; }
        public bool IsUnlocked { get; set; }
        public string Message { get; set; }
    }

    public class AchievementDbContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; }

        //public System.Data.Entity.DbSet<PomodoroApplication.Models.Assignment> Assignments { get; set; }
    }
}