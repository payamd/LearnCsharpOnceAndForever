using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharpOneTimeAndForever
{
    class max_of_serries
    {
        public static void getmax()
        {

            Console.WriteLine("Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4\", the program should display 8");
            var array = adad();
            //var array2 = Array.ConvertAll<string, int>(array, int.Parse);

            foreach (var number in array)
            {
              
            }

            


            Console.ReadLine();



        }


        private static string[] adad()
        {
            Console.WriteLine("adad ra vared konid:");
            string serries =(Console.ReadLine());
            return new  [] { serries };
        }
    }
    }

  
