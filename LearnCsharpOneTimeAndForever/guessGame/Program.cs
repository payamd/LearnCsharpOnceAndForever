

using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;

namespace guessGame
{
    class Program
    {
        public int Randomgenerator()
        {
            Random randomNumber = new Random();
            return randomNumber.Next(1, 10);
        }

        static void Main()
        {
            var randomNumber = new guessGame.Program().Randomgenerator();
            var life = 3;
           
            Console.WriteLine("select a number between 1 to 10 :D can you guess the random generated number? you have 3 tries !");
            while (life>0)
            {
                var guessnumber =  int.Parse(Console.ReadLine());
              if (guessnumber == randomNumber)
                   Console.WriteLine("bullseye, gjj");
              else
              {
                  life--;
                    Console.WriteLine(string.Format("your life is {0}! try again.",life));
               
                }       

            }

            Console.WriteLine(string.Format("the number was {0}!", randomNumber));
            Console.ReadLine();

        }
    }
}
