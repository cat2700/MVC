using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolProj.Models
{
    public class CourceMetaData
    {
        [Required (ErrorMessage ="Please Enter The Title !")]
        public string title { get; set; }
        [Required(ErrorMessage ="Please Enter Cource Credits !")]
        [Range(2,6,ErrorMessage ="Please Enter Number Between 2 and 6")]
        public string credit { get; set; }
        [Display(Name ="The Description")]
        public string description { get; set; }
        //[Required(ErrorMessage = "Please Select The Level !")]
        //[EnumDataType (typeof(CourseLevels))]
        //public Nullable<CourseLevels> level { get; set; }
        
        [Required(ErrorMessage = "Please Select The Level !")]
        public couselevel level2 { get; set; }


    }
    public class StudentMetaData
    {
        [Display(Name = "The First Name")]
        public string fname { get; set; }
        [Display(Name = "The Last Name")]
        public string lname { get; set; }
        
        [ValidRecentEnrollment]
        public Nullable<System.DateTime> enrolldate { get; set; }

    }
}