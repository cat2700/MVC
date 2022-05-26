using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolProj.Models;

namespace SchoolProj.Controllers
{
    public class enrolltblsController : Controller
    {
        private schooldbEntities db = new schooldbEntities();

        // GET: enrolltbls
        public ActionResult Index()
        {
            var enrolltbls = db.enrolltbls.Include(e => e.coursetbl).Include(e => e.studenttbl);
            return View(enrolltbls.ToList());
        }

        // GET: enrolltbls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            enrolltbl enrolltbl = db.enrolltbls.Find(id);
            if (enrolltbl == null)
            {
                return HttpNotFound();
            }
            return View(enrolltbl);
        }

        // GET: enrolltbls/Create
        public ActionResult Create()
        {
            ViewBag.courseid = new SelectList(db.coursetbls, "id", "title");
            ViewBag.studentid = new SelectList(db.studenttbls, "id", "fname");
            return View();
        }

        // POST: enrolltbls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,courseid,studentid,grade")] enrolltbl enrolltbl)
        {
            if (ModelState.IsValid)
            {
                db.enrolltbls.Add(enrolltbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.courseid = new SelectList(db.coursetbls, "id", "title", enrolltbl.courseid);
            ViewBag.studentid = new SelectList(db.studenttbls, "id", "fname", enrolltbl.studentid);
            return View(enrolltbl);
        }

        // GET: enrolltbls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            enrolltbl enrolltbl = db.enrolltbls.Find(id);
            if (enrolltbl == null)
            {
                return HttpNotFound();
            }
            ViewBag.courseid = new SelectList(db.coursetbls, "id", "title", enrolltbl.courseid);
            ViewBag.studentid = new SelectList(db.studenttbls, "id", "fname", enrolltbl.studentid);
            return View(enrolltbl);
        }

        // POST: enrolltbls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,courseid,studentid,grade")] enrolltbl enrolltbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrolltbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.courseid = new SelectList(db.coursetbls, "id", "title", enrolltbl.courseid);
            ViewBag.studentid = new SelectList(db.studenttbls, "id", "fname", enrolltbl.studentid);
            return View(enrolltbl);
        }

        // GET: enrolltbls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            enrolltbl enrolltbl = db.enrolltbls.Find(id);
            if (enrolltbl == null)
            {
                return HttpNotFound();
            }
            return View(enrolltbl);
        }

        // POST: enrolltbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            enrolltbl enrolltbl = db.enrolltbls.Find(id);
            db.enrolltbls.Remove(enrolltbl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
