using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace test
{
    
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            Console.WriteLine("GetValue"+date.GetValueOrDefault());
            Console.WriteLine("HasValue" + date.HasValue);
            //Console.WriteLine("Value" + date.Value);


            DateTime? date2= new DateTime(2014, 1, 1);
            DateTime date3 = date2.GetValueOrDefault();

            Console.WriteLine(date3);

            Console.ReadLine();
        }
        
       
    }
    

}
