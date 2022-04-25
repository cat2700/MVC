using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proj1.Models
{
    public class InstituteContext:DbContext
    {
        public DbSet<Student> StudentsTBL { get; set; }
    }
}