using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProj.Models
{
    public class myStudentsStats
    {
        public int studentID { get; set; }

        public string fullName { get; set; }
        public int numberOfCourses { get; set; }
        public decimal averGrade { get; set; }
    }
}