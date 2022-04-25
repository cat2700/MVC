using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proj1.Models
{
    public class Enrollment
    {
        public Course courseDet { get; set; }
        public List<Student> studendDet { get; set; }
    }
}