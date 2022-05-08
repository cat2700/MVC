using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProj.Models
{
    public partial class studenttbl
    {
        public string FullName {
            get
            {
                return fname + " " + lname;
            }
           
        }
    }
}