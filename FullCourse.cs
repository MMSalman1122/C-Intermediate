using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    
    class Program
    {
        public static void Main()
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1982,1,1));
            Console.WriteLine(person.GetBirthdate());
            Console.ReadLine();
        }
     
    }
}
