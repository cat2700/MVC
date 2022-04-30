using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //oldprocess();

            //LINQ_Extention_Methos_Examples();

            //LINQ_Query_Operator();

            //LINQ_ReturnOneRow();

            //LINQ_Pagination();

            LINQ_Aggregates();


            Console.ReadKey();
        }

        private static void LINQ_Aggregates()
        {
            // >> count , max , min , sum

            // >> Get Data:
            var books = new BookRepo().GetBooks();

            var count = books.Count();
            var max = books.Max(v => v.price);
            var min = books.Min(v => v.price);
            var aver = books.Average(v => v.price);
            var sum = books.Sum(v => v.price);

            // >> Display:   
            Console.WriteLine(count);
            
        }

        private static void LINQ_Pagination()
        {
            // مهم جدا في عمل جريد به صفحات لعرض الحقول الكثيرة على اكثر من صفحة

            // >> Get Data:
            var books = new BookRepo().GetBooks();

            var selectedBooks = books.Skip(2).Take(2);

            // >> Display:
            foreach (var c in selectedBooks)
            {
                Console.WriteLine(c.title + " >> " + c.price);
            }

        }

        private static void LINQ_ReturnOneRow()
        {
            // >> Get Data:
            var books = new BookRepo().GetBooks();

            // >> LINQ return one row:
            //var oneRow = books.Single(x => x.title == "Python OOP "); // will exception if return null or more one row
            //var oneRow = books.SingleOrDefault(x => x.price > 4); //// will exception if return more one row
            //var oneRow = books.FirstOrDefault(x => x.price > 4);
            var oneRow = books.LastOrDefault(x => x.price > 4);

            // >> Display:
            if (oneRow != null)
            {
                Console.WriteLine(oneRow.title + " " + oneRow.price);
            }
        }

        private static void LINQ_Query_Operator()
        {
            // >> Get Data:
            var books = new BookRepo().GetBooks();

            // >> LINQ Query Operator:
            var cheapBooks = from xx in books
                             where xx.price < 10
                             orderby xx.price descending
                             select xx.title; // >> projection
            // >> Display:
            foreach (var c in cheapBooks)
            {
                Console.WriteLine(c);
            }



        }

        private static void LINQ_Extention_Methos_Examples()
        {
            // >> Get Data:
            var books = new BookRepo().GetBooks();

            var cheapbooks = books.Where(bk => bk.price < 10).OrderByDescending(x => x.price);

            // >> Display:
            foreach (var c in cheapbooks)
            {
                Console.WriteLine(c.title + " >> " + c.price);
            }

            Console.ReadKey();


            //use LINQ to select one column as :
            var cheapbooksTitle = books.Where(bk => bk.price < 10).OrderByDescending(x => x.price).Select(bk => bk.title);

            // >> Display as string:
            foreach (var t in cheapbooksTitle)
            {
                Console.WriteLine(t);
            }

        }

        private static void oldprocess()
        {
            var books = new BookRepo().GetBooks();

            // >> General Process:
            var cheapbooks = new List<Book>();

            foreach (var book in books)
            {
                if (book.price < 12)
                {
                    cheapbooks.Add(book);
                }
            }

        }


    }
}
