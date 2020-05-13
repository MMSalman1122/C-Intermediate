using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace test
{
    //Extension methods
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("negative number of words");

            if (numberOfWords == 0)
                return "";
            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            string post = "THis is a long long  d s jkjdaljdk jsalkjdjklj string";
            var shortendPost = post.Shorten(5);

            Console.WriteLine(shortendPost);


            IEnumerable<int> numbers = new List<int>() {1,2,3,4,5,6 };
            var max= numbers.Max();
            Console.WriteLine(max);
            Console.ReadLine();
        }
        
       
    }
    

}
