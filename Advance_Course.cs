using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace test
{
    public class video
    {
        public string Title { get; set; }
    }
    public class VideoEncoder
    {
        public void Encode(video video)
        {
            Console.WriteLine("Encoding video");
            Thread.Sleep(1000);
        }
    }   
            
    class Program
    {
        static void Main(string[] args)
        {
            var video = new video() { Title = "video 1" };
            var videoEncoder = new VideoEncoder();
            videoEncoder.Encode(video);
            Console.ReadLine();
        }
        
       
    }


}
