using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace proj1.Models
{
    //to create and replace db and tables and data in controller
    public class InstituteIntializer:DropCreateDatabaseIfModelChanges<InstituteContext>
    {
        protected override void Seed(InstituteContext context)
        {
            Student Maged = new Student()
            {
                stID = 2,stFName = "Maged",stLName = "Muhammed"
            };

            Student Hiam = new Student()
            {
                stID = 3,stFName = "Hiam",stLName = "Maged"
            };

            context.StudentsTBL.Add(Maged);
            context.StudentsTBL.Add(Hiam);
            
            context.SaveChanges();
        }
    }
}