using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
   public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary= new Dictionary<string, string>();
     
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
    
    class Program
    {
        public static void Main()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "salman";
            Console.WriteLine(cookie["name"]);
          
            Console.ReadLine();
        }
     
    }
}
