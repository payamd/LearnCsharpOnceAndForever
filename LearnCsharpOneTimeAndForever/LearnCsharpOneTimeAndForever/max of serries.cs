using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharpOneTimeAndForever
{
    class max_of_serries
    {
        private List<Int32> a = new List<Int32>();
        public void getmax()
        {

            Console.WriteLine("Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4\", the program should display 8");
            
            string str = adad();
            //var array2 = Array.ConvertAll<string, int>(array, int.Parse);
            string[] words = str.Split(',');
            
          
            foreach (var number in words)
            {
                a.Add(Convert.ToInt32(number));
            }
            a.Sort();
            foreach (var number in a)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();



        }


        private static string adad()
        {
            Console.WriteLine("adad ra vared konid:");
            string serries =Console.ReadLine();
            return serries;
        }
    }
    }

  
