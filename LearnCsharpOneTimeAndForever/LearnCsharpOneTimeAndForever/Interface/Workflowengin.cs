using System;
using System.ComponentModel;

namespace LearnCsharpOneTimeAndForever
{
    public class Videouploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("video uploader run");
        }
    }

    public class Sendemail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("mail sender run");
        }
    }

    public class Callwebservice : ITask
    {
        public void Execute()
        {
            Console.WriteLine("web service run");
        }
    }
}