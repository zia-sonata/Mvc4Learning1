using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4App1.Models;
using Student.Interface;
namespace Mvc4App1.Controllers
{
    public class StudentController : Controller
    {
        SchoolContext db = new SchoolContext();

        IFeesCalculator _feesCalculator;

        public StudentController(IFeesCalculator feesCalculator)
        {
            _feesCalculator = feesCalculator;
        }

        //
        // GET: /Student/

        public ActionResult Index()
        {
            int fees = _feesCalculator.CalculateFees(1);
           
            StudentCourseViewModel viewModel=new StudentCourseViewModel();
            viewModel.Students  = db.Students.ToList();
            viewModel.Courses = db.Courses.ToList();
            viewModel.Fees = fees;
            return View(viewModel);
        }
        public ActionResult Delete()
        {
            var students = db.Students.ToList();

            db.Students.RemoveRange(students);

            db.SaveChanges();

            return RedirectToAction("Index");
        }
       
        public JsonResult Save(StudentCourseViewModel model)
        {
            var students = model.Students;
            foreach (var student in students)
            {
                var record = db.Students.SingleOrDefault(b => b.StudentId == student.StudentId);
                if (record != null)
                {
                    if (record.StudentName != student.StudentName)
                    {
                        record.StudentName = student.StudentName;
                        db.SaveChanges();
                    }
                }
            }
            return Json(new { Status = "Success" }, JsonRequestBehavior.AllowGet);
        }
    }
}
