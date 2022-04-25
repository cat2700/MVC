using proj1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proj1.Controllers
{
    public class XYZController : Controller
    {

        private InstituteContext db = new InstituteContext();

        // GET: XYZ
        public ActionResult Index()
        {

            var st = db.StudentsTBL.ToList(); // LINQ

            return View(st);
        }
    }
}