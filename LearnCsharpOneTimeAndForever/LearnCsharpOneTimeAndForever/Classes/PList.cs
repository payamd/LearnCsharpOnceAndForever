using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharpOneTimeAndForever
{
    class PList
    {
        public static bool heyphen()
        {

            var string1 = Console.ReadLine();
            int value;
            var list  = string1.Split('-');
            foreach (var item in list)
            {
                if (int.TryParse(item, out value))
                     return true;
          
               else
                     return false;              
            }


            return false;
        }


        public static void dublicate()
        {

            var string1 = Console.ReadLine();
            var list = string1.Split('-');
            var temp = list;
            var i = 0;
            foreach (var item in list)
            {
                temp[i] = null;
                i++;
                foreach (var item2 in temp) {
                    if (item == item2)
                        Console.WriteLine("doubled");
                }


            }


            Console.WriteLine("ok!");
        }



        public static void classnamemaker() {


            Console.WriteLine("jomle mored nazar ra vared konid");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
                return;
            }
            var classnames = "";
            foreach (var item in input.Split(' '))
            {
                var newWord = char.ToUpper(item[0]) + item.Substring(1);
                classnames += newWord;
            }
            Console.WriteLine(classnames);






        }



        public static void vowel() {

            Console.WriteLine("jomleye khod ra vared konid :) ");
            var input = Console.ReadLine();
            var vocales = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var numeroVocales = new List<char>();
            if (string.IsNullOrWhiteSpace(input))
                return;
            for (var i = 0; i < input.Length; i++)
            {
                if (vocales.Contains(Convert.ToChar(char.ToLower(input[i]))))
                {
                    numeroVocales.Add(Convert.ToChar(input[i]));
                }
            }
            Console.WriteLine(numeroVocales.Count);

        }

    }
}
