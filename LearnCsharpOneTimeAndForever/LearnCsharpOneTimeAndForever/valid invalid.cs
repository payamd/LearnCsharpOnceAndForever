using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharpOneTimeAndForever
{
    class valid_invalid
    {
        public static void isvalid () {


            Console.WriteLine("1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display \"Valid\" on the console. Otherwise, display \"Invalid\". (This logic is used a lot in applications where values entered into input boxes need to be validated.)");

            Console.WriteLine("Please neter your number? :");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input > 0 && input <= 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }


            Console.ReadLine();


        } 

  

    }
}
