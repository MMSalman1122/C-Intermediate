using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}" , to , Name);
        }
    }
    class Program
    {
        public static void Main()
        {
            var person = new Person();
            person.Name = "Salman";
            person.Introduce("Mimi");
            Console.ReadLine();
        }
     
    }
}
