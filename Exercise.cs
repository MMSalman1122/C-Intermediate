using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    class Program
    {
        public class Stack
        {

            private List<object> stack = new List<object>();
            public void Push(object obj)
            {
                var Check = obj;
                if(Check!=null)
                {
                    stack.Add(obj);
                }
                else
                {
                    throw new InvalidOperationException("Invalid operation.");
                }

            }
            public object Pop()
            {
                var LastElement = stack.Count-1;
                if (LastElement >= 0)
                {
                    var OutGoing = stack[LastElement];
                    stack.RemoveAt(LastElement);
                    return OutGoing;
                }
                else
                {
                    throw new InvalidOperationException("Stack is already empty.");
                }

            }
            public void Clear()
            {

                stack.Clear();
                
            }
            public void Display()
            {
                foreach(var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        

        }
     

        public static void Main()
        
        {
            var stack = new Stack();
            while(true)
            {
                Console.WriteLine("Enter the choice , a: push, p :pop, d: display, c:clear");
                var choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case 'a':
                        {
                            Console.WriteLine("Enter the object you want to push");
                            var element = Console.ReadLine();
                            stack.Push(element);

                            break;
                        }
                    case 'p':
                        {
                            Console.WriteLine(stack.Pop());
                            break;
                        }
                    case 'c':
                        {
                            stack.Clear();
                            break;
                        }
                    case 'd':
                        {
                            stack.Display();
                            break;
                        }
                    default:
                        {
                            return;
                        }

                }

            }
            
        }


    }

}
