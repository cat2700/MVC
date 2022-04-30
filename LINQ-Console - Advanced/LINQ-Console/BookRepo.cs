using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Console
{
    class BookRepo
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{title="ASP.NET MVC",price=30 ,category="Data Access",
                    recommendations= new string[]{"DR, Haitham","DR. Mazen"}},
                new Book{title="ASP.NET WEP API",price=17,category="Web Programing",
                    recommendations= new string[]{"DR, maged","DR. Mazen"}},
                new Book{title="ASP.NET step by step",price=4,category="Web Programing",
                    recommendations= new string[]{"DR, Mohammed","DR. Ebrahim"}},
                new Book{title="C# Advanced Topics",price=9,category="Programing",
                    recommendations= new string[]{"DR, Mohammed","DR. Ebrahim"}},
                new Book{title="Java Advanced Topics",price=22,category="Programing",
                    recommendations= new string[]{"DR. Ebrahim"}},
                new Book{title="Python OOP",price=4.5f,category="Programing",
                    recommendations= new string[]{"DR, khadija","DR. Ebrahim"}},
                new Book{title="Python Intro",price=2,category="Programing",
                    recommendations= new string[]{}},

            };
        }


        public List<Book> GetBooks2()
        {
            return new List<Book>
            {
                new Book{title="Entity Framework MVC Core",price=19 ,category="Data Access",
                    recommendations= new string[]{"DR, ahmed"}},
                new Book{title="Entity Framework WEP API",price=7,category="Web Programing",
                    recommendations= new string[]{"DR, hamed","DR. Mazen"}},
                new Book{title="ASP.NET step by step",price=4,category="Web Programing",
                    recommendations= new string[]{"DR, Mohammed","DR. Ebrahim"}},
                new Book{title="C# Advanced Topics",price=9,category="Programing",
                    recommendations= new string[]{"DR, Mohammed","DR. Ebrahim"}},
                new Book{title="Java Advanced Topics",price=22,category="Programing",
                    recommendations= new string[]{"DR. Ebrahim"}},
                new Book{title="Python OOP",price=4.5f,category="Programing",
                    recommendations= new string[]{"DR, khadija","DR. Ebrahim"}},
                new Book{title="Python Intro",price=2,category="Programing",
                    recommendations= new string[]{}},

            };
        }
    }
}
