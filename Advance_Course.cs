using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    
        
    class Program
    {
        static void Main(string[] args)
        {

            //number => number * number
            //()=>...
            //x=>...
            //(x,y,z)=>...

            Func<int, int> squre =number=>number*number;

            Console.WriteLine(squre(2));


            const int factor = 5;



            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(2));

            Console.ReadLine();
        }
       
    }


}
