using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Mvc4App1.Models
{
    public class SchoolInitializer:DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{StudentId=1,StudentName="Zia",PhoneNumber="8147761545"},
                 new Student{StudentId=2,StudentName="Anjum", PhoneNumber="908837732"}
            };
          
            foreach (var student in students)
            {
                context.Students.Add(student);
            }
            var courses = new List<Course>
            {
                new Course{ CourseId=001, CourseName="MCA"},
                new Course{ CourseId=002, CourseName="BCA"},
            };
            foreach (var course in courses)
            {
                context.Courses.Add(course);
            }
            context.SaveChanges();

         
            //base.Seed(context);
        }
    }
}