using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PomodoroApplication.Models
{
    public class Point
    {
        public int Points { get; set; }
        public int PointTotal { get; set; }
    }

    public class PointDbContext : DbContext
    {
        public DbSet<Point> Points { get; set; }
    }
}