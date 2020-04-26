using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Task1
    {
        public int count;
        public Task1()
        {
            count = 0;

        }

        public void show()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }

    }
    public class Task2
    {
        public double sum;
        public Task2()
        {
            sum = 0;
        }

        public void Addr(int newNumber)
        {
            sum += newNumber;
            Console.WriteLine(sum);
        }

    }
    public class Task3
    {
        public double num;
        public double factorial;

        public Task3(double num)
        {
            this.num = num;
            this.factorial = 1;

        }
        public void factorialCal()
        {
            for (var i = num; i > 0; i--)
            {
                factorial *= i;

            }
            Console.WriteLine("{0} != {1}", num, factorial);
        }
    }
    public class Task5
    {
        public string input;
        public Task5(string input)
        {
            this.input = input;
        }
        public void findMax()
        {
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max is " + max);

        }
    }
    class Program
    {
        public static void Main()
        {
            var task1 = new Task1();
            task1.show();


            var task2 = new Task2();
            while(true)
            {
                Console.WriteLine("Enter  Number or 'OK' to quit");
                var input = Console.ReadLine();
                
                if(input.ToLower()=="ok")
                {
                    Console.WriteLine("Exit");
                    break;
                }
                else
                {
                    task2.Addr(Convert.ToInt32(input));
                }
            }


            Console.WriteLine("Enter the number to find its factorial");
            var task3 = new Task3(Convert.ToInt64(Console.ReadLine()));
            task3.factorialCal();


            Console.WriteLine("Enter the numbers separated by ,");
            var task5 = new Task5(Console.ReadLine());
            task5.findMax();
            Console.ReadLine();
        }
     
    }
}
