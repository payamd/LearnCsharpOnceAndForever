using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2K19
{
    class Validate
    {

        public static void AddToList()
        {
            var input = Console.ReadLine();
            var split = input.Split(",");
            var myList = new List<string>();
            if (myList.Count <= 5)
            {
                foreach (var x in split)
                {
                    myList.Add(x);
                }


            }
            else
            {
                Console.WriteLine("list if full");
            }

            foreach (var name in myList)
            {
                Console.WriteLine(name);
            }

        }
        public static void Validator()
        {
            var number = Int32.Parse(Console.ReadLine());
            if (1 < number && number < 10)
                Console.WriteLine("valid");
            else
                Console.WriteLine("Invalid");
        }
    }

    class stringhelper
    {
        public static void wordcounter()
        {
            var readed = File.ReadAllText(@"D:\Payamtest.txt");
            var testarray = readed.Split(" ");
            var i = 0;
            var j = 0;
            var max1 = "";
            var nm1 = 0;
            var max2 = "";
            var nm2 = 0;
            var max3 = "";
            var nm3 = 0;
            foreach (var word1 in testarray)
            {

                foreach (var word2 in testarray)
                {
                    if (word1 == word2)
                    {
                        j++;
                    }
                }

                //Console.WriteLine(word1 + ": " + j);
                if (j > nm1)
                {
                    nm1 = j;
                    max1 = word1;
                }
                else if (nm2 < j && j < nm1)
                {
                    nm2 = j;
                    max2 = word1;
                }
                else if (nm3 < j && j < nm2 && j < nm1)
                {
                    nm3 = j;
                    max3 = word1;
                }


                j = 0;
                i++;

            }
            Console.WriteLine("max is: " + max1 + " with numbers of:" + nm1);
            Console.WriteLine("max is: " + max2 + " with numbers of:" + nm2);
            Console.WriteLine("max is: " + max3 + " with numbers of:" + nm3);

            Console.WriteLine("total world count: " + i);
        }
        public static void ReverseInput()
        {
            //Validate.Validator();
            var input = Console.ReadLine();
            if (input != null) input.Trim();
            var Rarray = new string[10];
            for (int i = 0; i < input.Length; i++)
            {
                Rarray[i] = Convert.ToString(input[i]);

            }

            Array.Reverse(Rarray);
            foreach (var s in Rarray)
            {
                Console.Write(s);
            }
        }

    }
}
