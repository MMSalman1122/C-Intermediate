using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Person
    {
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate { get;private set; }
        public int Age
        {
            get
            {
                var timeSpan=DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
    
    class Program
    {
        public static void Main()
        {
            var person = new Person(new DateTime(1997, 12, 1));
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }
     
    }
}
