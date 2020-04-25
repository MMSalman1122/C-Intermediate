using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
   public class PresentationObject
    {
        public int width { get; set; }
        public int height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object is copied to clipbord");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
    public class Text: PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to "+ url);
        }
    }
  
    class Program
    {
        public static void Main()
        {
            var text = new Text();
            text.width = 100;
            text.Copy();
          
            Console.ReadLine();
        }
     
    }
}
