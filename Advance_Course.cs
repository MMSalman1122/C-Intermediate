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
        static void  Main(string[] args)
        {
            var streamReader = new StreamReader(@"c:\file.zip");

            try
            {
                var content = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Sorry, an unexpacted error occured");
            }
            finally
            {
                streamReader.Dispose();
            }
            Console.ReadLine();
        }
        
       
    }
    

}
