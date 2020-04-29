using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
        
{
   
    class Program
    {
        public static void Task2()
        {
            Console.WriteLine("Enter the number separated by'-'");
            var input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input");
                return;
            }
            

            var uniques = new List<Int32>();
            bool IsDuplicate = false;
            foreach( var number in input.Split('-'))
            {
                if (!uniques.Contains(Convert.ToInt32(number)))
                {
                    uniques.Add(Convert.ToInt32(number));
                }
                else
                {
                    IsDuplicate = true;
                }
            }
            if(IsDuplicate)
            {
                Console.WriteLine("DUplicates");
            }
            else
            {
                Console.WriteLine("Uniques");
            }

        }
        public static void Task3()
        {
            Console.WriteLine("Enter the time");
            var input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            var time = input.Split(':');
            if(time.Length != 2)
            {
                Console.WriteLine("Invalid");
                return;
            }
            try
            {
                var hours = Convert.ToInt32(time[0]);
                var minutes = Convert.ToInt32(time[1]);
                if(hours <=23 && hours>=0 && minutes >= 0 && minutes <= 59)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid");
            }

        }
        public static void Task4()
        {
            Console.WriteLine("Enter words separated by space");
            var input = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
                return;
            }
            var variable = "";
            foreach(var words in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(words[0]) + words.ToLower().Substring(1);
                variable += wordWithPascalCase;
            }
            Console.WriteLine(variable);
        }
        public static void Task5()
        {
            Console.WriteLine("Enter the word");
            var word = Console.ReadLine().ToLower();
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var count = 0;
            foreach(var letter in word)
            {
                if(vowels.Contains(letter))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void Main()
        {   
            //Task 1

            Console.WriteLine("Enter the Number separated by -");
            var input = Console.ReadLine();
            var numbers = new List<int>();
            bool isConsective=true;
            foreach(var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
                
            }
            numbers.Sort();
            for(int i= 0; i<numbers.Count-1; i++)
            {
                if (numbers[i]+1 != numbers[i+1])
                {
                    isConsective = false;
                    break;
                }
            }
            var message = isConsective ? "consective" : "not consective";
            Console.WriteLine(message);

            // Task2
            Task2();
            Task3();
            Task4();
            Task5();
           
            Console.ReadLine();
        }
        
     
    }
}
