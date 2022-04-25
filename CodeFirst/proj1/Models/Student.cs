using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proj1.Models
{
    [Table("studentdetails")]
    public class Student
    {
        [Key]
        public int stID { get; set; }

        public string stFName { get; set; }

        public string stLName { get; set; }
    }
}