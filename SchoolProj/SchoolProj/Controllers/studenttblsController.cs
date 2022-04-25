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
    public class studenttblsController : Controller
    {
        private schooldbEntities db = new schooldbEntities();
        // GET: studenttbls
        public ActionResult Index()
        {
            return View(db.studenttbls.ToList());
        }

        // GET: studenttbls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            studenttbl studenttbl = db.studenttbls.Find(id);
            if (studenttbl == null)
            {
                return HttpNotFound();
            }
            return View(studenttbl);
        }

        // GET: studenttbls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: studenttbls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fname,lname,enrolldate,imgPath")] studenttbl studenttbl ,HttpPostedFileBase imgfile)
        {
            if (ModelState.IsValid)
            {
                if (imgfile != null)
                {
                    imgfile.SaveAs(HttpContext.Server.MapPath("~/Content/Images/Students/" + imgfile.FileName));
                    studenttbl.imgPath = imgfile.FileName;
                }
                db.studenttbls.Add(studenttbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studenttbl);
        }

        // GET: studenttbls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            studenttbl studenttbl = db.studenttbls.Find(id);
            if (studenttbl == null)
            {
                return HttpNotFound();
            }
            return View(studenttbl);
        }

        // POST: studenttbls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,fname,lname,enrolldate,imgPath")] studenttbl studenttbl, HttpPostedFileBase imgfile)
        {
            if (ModelState.IsValid)
            {
                if (imgfile != null)
                {
                    ViewBag.msg = "is not null";
                    imgfile.SaveAs(HttpContext.Server.MapPath("~/Content/Images/Students/" + imgfile.FileName));
                    studenttbl.imgPath = imgfile.FileName;
                }
                else{ViewBag.msg = "is null";}

                db.Entry(studenttbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studenttbl);
        }

        // GET: studenttbls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            studenttbl studenttbl = db.studenttbls.Find(id);
            if (studenttbl == null)
            {
                return HttpNotFound();
            }
            return View(studenttbl);
        }

        // POST: studenttbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            studenttbl studenttbl = db.studenttbls.Find(id);
            db.studenttbls.Remove(studenttbl);
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
