using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(Point newLocation)
           
        {   if(newLocation==null)
            {
                throw new ArgumentNullException("newLocation");
            }
            Move(newLocation.x, newLocation.y);
        }
    }
    public class Calculator
    {
        public int add(params int[] numbers)
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
    class Program
    {
        public static void Main()
        {
            int number;
            var result=int.TryParse("abc",out number);
            if (result)
            { Console.WriteLine(); }
            else
            {
                Console.WriteLine("Conversion is not possible");
            }
            Console.ReadLine();
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.add(1, 2, 3, 4, 5));
            Console.WriteLine(calculator.add(new int[] { 1, 2, 3, 4, 5 }));
        }
        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0},{1})", point.x, point.y);
                point.Move(100, 200);
                Console.WriteLine("Point is at ({0},{1})", point.x, point.y);
            }
            catch (Exception)
            {

                Console.WriteLine("Error occure");
            }
        }

     
    }
}