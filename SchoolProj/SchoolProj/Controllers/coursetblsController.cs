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
    public class coursetblsController : Controller
    {
        private schooldbEntities db = new schooldbEntities();

        // GET: coursetbls
        public ActionResult Index(string searchInCourses)
        {
            if (string.IsNullOrEmpty(searchInCourses))
            {
                return View(db.coursetbls.ToList());
            }
            else
            {
                var cc = from d in db.coursetbls
                         where d.title.Contains(searchInCourses) 
                         select d;
                
                return View(cc.ToList());
            }
        }

        // GET: coursetbls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            coursetbl coursetbl = db.coursetbls.Find(id);
            if (coursetbl == null)
            {
                return HttpNotFound();
            }
            return View(coursetbl);
        }

        // GET: coursetbls/Create
        public ActionResult Create()
        {
            ViewBag.level2bag = new SelectList(db.couselevels,"id","level");
            return View();
        }

        // POST: coursetbls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,credit,description,rating,isactive,level2bag")] coursetbl coursetbl)
        {
            if (ModelState.IsValid)
            {
                db.coursetbls.Add(coursetbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.level2bag = new SelectList(db.couselevels, "id", "level");
            return View(coursetbl);
        }

        // GET: coursetbls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            coursetbl coursetbl = db.coursetbls.Find(id);
            if (coursetbl == null)
            {
                return HttpNotFound();
            }
            return View(coursetbl);
        }

        // POST: coursetbls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,credit")] coursetbl coursetbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coursetbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coursetbl);
        }

        // GET: coursetbls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            coursetbl coursetbl = db.coursetbls.Find(id);
            if (coursetbl == null)
            {
                return HttpNotFound();
            }
            return View(coursetbl);
        }

        // POST: coursetbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            coursetbl coursetbl = db.coursetbls.Find(id);
            db.coursetbls.Remove(coursetbl);
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
