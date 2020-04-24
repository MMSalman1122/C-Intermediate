using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Oreder> Orders= new List<Oreder>();// initialize empty list once only

        
        public Customer(int id)
        {
            this.Id = Id;
        }
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
    }
    public class Oreder
    {

    }
    class Program
    {
        public static void Main()
        {
            
            Console.ReadLine();
        }
     
    }
}
