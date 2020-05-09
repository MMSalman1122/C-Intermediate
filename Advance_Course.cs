using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();

        }
        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    public class list
    {
        public void add(int number)
        {
            throw new NotImplementedException();
        }
        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    public class GenericList<T> //templete or type
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    public class Book
    {
        
        public Book()
        {
                
        }
    }
    public class GenericDictionary<TKey,TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
    // for constraints
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b )
        {
            return a > b ? a : b;
        }
        public T Max<T> (T a, T b) 
        {
            
            return a.CompareTo(b)> 0 ? a : b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = new GenericList<int>();
            number.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234",new Book());
        }
    }

}
