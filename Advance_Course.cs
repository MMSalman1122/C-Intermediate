using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace test
{
    //Extension methods
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book>GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title= "Add.Net step by step", Price=5 },
                new Book(){Title= "ASP.Net mvc", Price=9.99f },
                new Book(){Title= "Add.Net WEb", Price=12 },
                new Book(){Title= "C# Advance", Price=7 },
                new Book(){Title= "step by step", Price=9 }
            };
                
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            //Linq Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            //Linq extension methods
            var cheapBooks = books
                                    .Where(b => b.Price < 10)
                                    .OrderBy(b=> b.Title)
                                    .Select(b => b.Title);


            foreach (var book in cheapBooks)
            {
                 Console.WriteLine(book);
            }

            //for single return
            var book1 = books.Single(b => b.Title == "step by step");
            Console.WriteLine(book1.Price);
            //for count
            var count = books.Count();
            Console.WriteLine(count);

            Console.ReadLine();
        }
        
       
    }
    

}
