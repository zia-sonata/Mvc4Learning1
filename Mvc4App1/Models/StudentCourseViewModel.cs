using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc4App1.Models
{
    public class StudentCourseViewModel
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public int Fees{get;set;}
       
    }
}