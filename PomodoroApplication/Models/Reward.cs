using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PomodoroApplication.Models
{
    public class Reward
    {
        public int RewardId { get; set; }
        [DisplayName("Reward")]
        public string RewardName { get; set; }
        public string Description { get; set; }
        [DisplayName("Point Cost")]
        public int PointCost { get; set; }
    }

    public class RewardDbContext : DbContext
    {
        public DbSet<Reward> Rewards { get; set; }

        //public System.Data.Entity.DbSet<PomodoroApplication.Models.Achievement> Achievements { get; set; }
    }
}