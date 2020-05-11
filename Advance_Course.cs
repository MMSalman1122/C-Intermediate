using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title="Title 1",Price=5 },
                new Book() {Title="Title 2",Price=7 },
                new Book() {Title="Title 3",Price=17 },
            };
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    
        
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
           var cheapBooks= books.FindAll(IsCheaper);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            Console.ReadLine();
        }
        static bool IsCheaper(Book book)
        {
            return book.Price < 10;
        }
       
    }


}
