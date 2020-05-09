using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Photo
    {
        public static Photo Load(String path)
        {
            return new Photo();
        }
        public void Save()
        {

        }
    }
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply Brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            
            photo.Save();
            
            
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filter = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;

            filterHandler += filter.ApplyContrast;
            //add to deligate
            filterHandler += RemoveRedEyerFilter;

            processor.Process("dhajhdjska", filterHandler);
            
           

            Console.ReadLine();
        }
        // create own filter
        static void RemoveRedEyerFilter(Photo photo)
        {
            Console.WriteLine("Red eye ");
        }
    }


}
