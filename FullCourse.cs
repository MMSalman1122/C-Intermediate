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
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();// to avoid exceptio initialize empty list
        }
        public Customer(int id)
            : this() // it means when this function is called the Customer() is called first
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            :this(id) // it means when this function is called the Customer(int id) is called first
        {
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

            var Order = new Order();
            custumor.Orders.Add(Order);// null reference exceptio
            Console.ReadLine();
        }
     
    }
}
