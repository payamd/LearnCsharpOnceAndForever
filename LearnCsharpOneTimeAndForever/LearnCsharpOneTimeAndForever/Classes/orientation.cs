using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharpOneTimeAndForever
{
    class orientation
    {


        public static void orient()
        {
            Console.WriteLine("Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.");
            Console.WriteLine("tool ra vared konid:");
            var input1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("arz ra vared konid");
            var input2 = Convert.ToInt16(Console.ReadLine());
            if (input1 > input2)
            {
                Console.WriteLine(string.Format("portrait"));

            }
            else if (input1 < input2)
            {
                Console.WriteLine(string.Format("landscape"));
            }
            else
            {
                Console.WriteLine("square!!!");
            }
            Console.ReadLine();

        }


    }
}
