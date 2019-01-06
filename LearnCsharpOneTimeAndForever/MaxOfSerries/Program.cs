using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfSerries
{
    class Program
    {
        static void Main(string[] args)
        {
            var serries = Console.ReadLine();
            var length = serries.Length;
            var trimed = serries.Split(',');
            var max =0;
            foreach (var character in trimed)
            {
                if (Convert.ToInt32(character)  > max)
                    max = Convert.ToInt32(character);

                Console.WriteLine(character);
            }


            Console.WriteLine($"max number is {max}");
            Console.ReadLine();
        }
    }
}
