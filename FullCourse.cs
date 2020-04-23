using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Order
    {

    }
    public class Customer
    {
        public int Id;
        public string Name;
        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
       
    }
    class Program
    {
        public static void Main()
        {
            var custumor = new Customer(1,"salman");
            Console.WriteLine(custumor.Id);
            Console.WriteLine(custumor.Name);
            Console.ReadLine();
        }
     
    }
}
