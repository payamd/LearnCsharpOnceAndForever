using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                var input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "start":
                    {
                        stopwatch.Swstart(DateTime.Now);
                        break;
                    }
                    case "stop":
                    {
                        stopwatch.SwStop();
                            break;
                    }
                    case "show":
                    {
                        stopwatch.SwShow();
                            break;
                    }
                    default:
                    {
                        Console.WriteLine("wrong statement");
                        break;
                    }
                }


            }
           
            Console.ReadLine();


        }
    }
}
