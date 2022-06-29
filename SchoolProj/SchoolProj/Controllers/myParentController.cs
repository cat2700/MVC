using SchoolProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProj.Controllers
{
    public class myParentController : Controller
    {
        private schooldbEntities db = new schooldbEntities();

        static List<myCourseStats> stats = null;
        
        static List<myStudentsStats> StuStats = null;

        public myParentController()
        {
            stats = new List<myCourseStats>();

            var coursesGroups = db.enrolltbls.GroupBy(g => g.coursetbl.title);
            foreach (var gp in coursesGroups)
            {
                stats.Add(
                    new myCourseStats { title=gp.Key ,enrollments=gp.Count()}
                    );
            }
            ViewBag.courseStats = stats;
        }


    }
}