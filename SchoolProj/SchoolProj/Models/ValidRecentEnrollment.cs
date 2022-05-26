using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SchoolProj.Models
{
    public class ValidRecentEnrollment:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var std = (studenttbl) validationContext.ObjectInstance;
            if (std.enrolldate==null)
            {
                return new ValidationResult("Please Enter Enrollment Date!");
            }
            var Y = DateTime.Today.Year - std.enrolldate.Value.Year;
            if (Y > 3)
            {
                return new ValidationResult("Enrollment Date Should not be More than 3 Years!");
            }
            return ValidationResult.Success;
        }
    }
}