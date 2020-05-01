using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
    
       
{
   public class Post
    {
        private string _title;
        private string _descripstion;
        private DateTime _dateCreated ;
        private int _vote;
        public Post(string title, string description)
        {
            this._title = title;
            this._descripstion= description;
            _vote = 0;
            _dateCreated = DateTime.Now;
        }
        public void UpVote()
        {
            _vote++;
        }
        public void DownVote()
        {
            if(_vote>0)
            {
                _vote--;
            }
        }
        public int GetVote()
        {
            return _vote;
        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetDescription()
        {
            return _descripstion;
        }
        public DateTime GetDateCreated()
        {
            return _dateCreated;
        }


    }
    
    class Program
    {
       
        public static void Main()
        {
            Post post = new Post("First Post","This is my first post's desscription.");
            while (true)
            {
                Console.WriteLine("Enter 'u' for up vottnig, 'd' for down-voting and 's' to show");
                var choice = Char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 'u':
                        {
                            post.UpVote();
                            break;
                        }
                    case 'd':
                        {
                            post.DownVote();
                            break;
                        }
                    case 's':
                        {
                            Console.WriteLine("Title:{0},Created on:{1}, Votes:{2}", post.GetTitle(),post.GetDateCreated(),post.GetVote());
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }
            }
            
            Console.ReadLine();
        }
        
     
    }
}
