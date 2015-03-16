using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mvc4App1.Models
{
    public class Student
    {

        public Student()
        {
            StudentId = 1;
            StudentName = "Unknown";
        }

        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}