using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
    
       
{
   
    public class StopWatch
    {
        public DateTime startTime;
        public DateTime endTime;
        public string hours;
        public string minutes;
        public string seconds;

        public StopWatch()
        {
            startTime = new DateTime(0);
            endTime = new DateTime(0);
            hours ="0";
            minutes = "0";
            seconds = "0";
        }

        public void Start()
        {
           startTime = DateTime.Now;
            ShowTime();
           
        }
        public void Stop()
        {
            endTime = DateTime.Now;
            DurationCal();
            ShowTime();
        }
        public void DurationCal()
        {
            seconds = Convert.ToString(endTime.Second - startTime.Second);
            minutes = Convert.ToString(endTime.Minute - startTime.Minute);
            hours = Convert.ToString(endTime.Hour - startTime.Hour);
        }
        public void ShowTime()
        {
            Console.WriteLine("Hours:{0},Minutes:{1}, Seconds:{2}", this.hours, this.minutes, this.seconds);
        }

    }
   
    class Program
    {
       
        public static void Main()
        {
            var stopWatch = new StopWatch();
            var check = 0;
            while(true)
            {
                Console.WriteLine("Enter 's' to start and 't' to stop");
                var choice = Char.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 's':
                        {
                            if(check==0)
                            {
                                stopWatch.Start();
                                check = check + 1;
                            }
                            else
                            {
                                Console.WriteLine("Cant start twice");
                            }
                            break;
                        }
                    case 't':
                        {
                            stopWatch.Stop();
                            check = 0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the right choice.");
                            return;
                        }

                }

                
            }


            
            Console.ReadLine();
        }
        
     
    }
}
