using PomodoroApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PomodoroApplication.ViewModels
{
    public class AllViewModel
    {
        public Assignment Assignment { get; set; }
        public Reward Reward { get; set; }
     }


    public class AllViewModelDbContext : DbContext
    {
        public DbSet<AllViewModel> AllViewModels { get; set; }
    }
}