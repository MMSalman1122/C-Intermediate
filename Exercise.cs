using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
    
{
    public class Customer
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);

            if(rating==0)
            {
                Console.WriteLine("Promoted to lvl 1");
            }
            else
            {
                Console.WriteLine("Promoted to lvl 2");
            }
        }
        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
        protected int CalculateRating2(bool excludeOrders)
        {
            return 0;
        }
    }
    public class GoldCustomer: Customer
    {
        public void OfferVoucher()
        {
            this.CalculateRating2(excludeOrders: false);
        }
    }
   
        class Program
        {

            public static void Main()
            {
                var customer = new Customer();
                

                Console.ReadLine();
            }


        }
    
}
