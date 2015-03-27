using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4App1.Models;

namespace Mvc4App1.Controllers
{
    public class InterviewController : Controller
    {
        private SchoolContext db = new SchoolContext();

        //
        // GET: /Interview/

        public ActionResult Index()
        {
            return View(db.Interviews.ToList());
        }

        //
        // GET: /Interview/Details/5

        public ActionResult Details(int id = 0)
        {
            Interview interview = db.Interviews.Find(id);
            if (interview == null)
            {
                return HttpNotFound();
            }
            return View(interview);
        }

        //
        // GET: /Interview/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Interview/Create

        [HttpPost]
        public ActionResult Create(Interview interview)
        {
            if (ModelState.IsValid)
            {
                db.Interviews.Add(interview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(interview);
        }

        //
        // GET: /Interview/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Interview interview = db.Interviews.Find(id);
            if (interview == null)
            {
                return HttpNotFound();
            }
            return View(interview);
        }

        //
        // POST: /Interview/Edit/5

        [HttpPost]
        public ActionResult Edit(Interview interview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(interview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interview);
        }

        //
        // GET: /Interview/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Interview interview = db.Interviews.Find(id);
            if (interview == null)
            {
                return HttpNotFound();
            }
            return View(interview);
        }

        //
        // POST: /Interview/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Interview interview = db.Interviews.Find(id);
            db.Interviews.Remove(interview);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}