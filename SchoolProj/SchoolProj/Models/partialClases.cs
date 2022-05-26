using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SchoolProj.Models
{
    [MetadataType(typeof(StudentMetaData))] // To add Validation in metaDaa Class
    public partial class studenttbl
    {
        public string FullName {
            get
            {
                return fname + " " + lname;
            }
           
        }
    }
    [MetadataType(typeof(CourceMetaData))] // To add Validation in metaDaa Class
    public partial class coursetbl
    {

    }
    public partial class enrolltbl
    {
        // code here
    }
}