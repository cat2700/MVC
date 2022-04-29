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

            LINQ_Query_Operator();

            Console.ReadKey();
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
