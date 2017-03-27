using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharpOneTimeAndForever
{
    class MAxOfTwo
    {
        public static void maxoftow() {
            Console.WriteLine("Write a program which takes two numbers from the console and displays the maximum of the two.");
            Console.WriteLine("adad yek ra vared konid:");
           var input1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("adad dovom ra vared konid");
            var input2 = Convert.ToInt16(Console.ReadLine());
            if (input1 > input2)
            {
                Console.WriteLine(string.Format("maximum ==> {0}", input1));

            }
            else if (input1 < input2)
            {
                Console.WriteLine(string.Format("maximum ==> {0}", input2));
            }
            else {
                Console.WriteLine("hardo mosavi hastand!!!");
            }
            Console.ReadLine();

        }
    }
}
