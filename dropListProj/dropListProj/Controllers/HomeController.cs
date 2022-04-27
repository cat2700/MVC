using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dropListProj.Models;

namespace dropListProj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NewCascadingDropDownListsDBEntities db = new NewCascadingDropDownListsDBEntities();

            ViewBag.CoutriesBag = new SelectList(db.countries, "CountryId", "CountryName");

            var NoCities = (from c in db.citiys
                            where c.CityId == -1
                            select c).ToList();

            return View(NoCities);
        }
        [HttpPost]
       public ActionResult Index(int? countryIDReturn, int? stateIDReturn , int? cityIDReturn)
        {
            NewCascadingDropDownListsDBEntities db = new NewCascadingDropDownListsDBEntities();

            ViewBag.CoutriesBag = new SelectList(db.countries, "CountryId", "CountryName");

            if (countryIDReturn.HasValue)
            {
                var selectedStat = (from s in db.states
                                    where s.CountryId==countryIDReturn.Value
                                    select s).ToList();
                ViewBag.StatesBag = new SelectList(selectedStat, "StateId", "StateName");
            }




            var NoCities = (from c in db.citiys
                            where c.CityId == -1
                            select c);

            return View(NoCities);
        }
    }
}