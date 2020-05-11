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
        //Publish that an event is occuring
        //1 define deligat
        //2. define event
        //3.Rais the event

        public delegate void VideoEncoderEventHandler(object source, EventArgs args);
        public event VideoEncoderEventHandler VideoEncoded;


        public void Encode(video video)
        {
            Console.WriteLine("Encoding video");
            Thread.Sleep(1000);

            OnVideoEncoded();
        }
        public virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    } 
    public class MailService
    {
        public void OnvideoEncoded(Object source,EventArgs e)
        {
            Console.WriteLine("sending email");
        }
    }
            
    class Program
    {
        static void Main(string[] args)
        {
            var video = new video() { Title = "video 1" };
            var videoEncoder = new VideoEncoder();//publisher
            var mailservice = new MailService();//subscriber

            videoEncoder.VideoEncoded += mailservice.OnvideoEncoded;



            videoEncoder.Encode(video);
            Console.ReadLine();
        }
        
       
    }


}
