using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
    
{public class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle()
        {
            Console.WriteLine("Vehicle is initialized.");   
        }
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Contrctor of base class with parameter");
        }
    }
    public class Car: Vehicle
    {
        

        public Car()
    
        {
            Console.WriteLine("Car is being initialzed.");

        }
        public Car(string regNumber)
            :base(regNumber)
        {
            Console.WriteLine("Contrctor of derived class with parameter");
        }
        
    }
        class Program
        {

            public static void Main()
            {
            var car = new Car();
            var car2 = new Car("lol");
                Console.ReadLine();
            }


        }
    
}
