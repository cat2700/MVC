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
        // GET: XYZ
        public ActionResult Index()
        {
            Student omar =new Student( );
            omar.stID = 1;
            omar.stFName = "Omar";
            omar.stLName = "Ibrahim";

            Student Khaled = new Student()
            {
                stID=2,
                stFName="Khaled",
                stLName="Muhammed"
            };

            Student Mazen = new Student()
            {
                stID = 3,
                stFName = "Mazen",
                stLName ="Maged"
            };

            List<Student> stList = new List<Student>();

            stList.Add(omar);
            stList.Add(Khaled);
            stList.Add(Mazen);

            Course html = new Course()
            {
                courseID=1000,courseName="HTML5",coursePrice=2300
            };

            Enrollment enrollA = new Enrollment()
            { 
                courseDet=html,studendDet=stList
            };

            ViewBag.xxxx = "view bag testing";
            return View(enrollA);
        }
    }
}