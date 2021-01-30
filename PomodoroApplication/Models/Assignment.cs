using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PomodoroApplication.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }

        [DisplayName("Task")]
        public string AssignmentName { get; set; }

        public string Description { get; set; }

        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        [DisplayName("Points Worth")]
        public int PointsWorth { get; set; }
    }

    public class AssignmentDbContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }
    }
}