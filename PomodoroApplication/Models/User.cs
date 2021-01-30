using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PomodoroApplication.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int TotalUserPoints { get; set; }
    }

    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}