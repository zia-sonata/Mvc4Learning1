using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Mvc4App1.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Emails> Emails { get; set; }
        public DbSet<PhoneCalls> PhoneCalls { get; set; }
       
    }
}