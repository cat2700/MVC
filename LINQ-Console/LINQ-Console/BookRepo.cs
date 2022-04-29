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
                new Book{title="ASP.NET MVC",price=30},
                new Book{title="ASP.NET WEP API",price=17},
                new Book{title="ASP.NET step by step",price=4},
                new Book{title="C# Advanced Topics",price=9},
                new Book{title="C# Advanced Topics",price=22},
                new Book{title="Python OOP",price=4.5f},
                new Book{title="Python Intro",price=2},

            };
        }
    }
}
