using System;

namespace hello_world
{
    class Program
    {
        public enum Orders
        {
            mail = 1,
            post =2,
            car = 3
        }

        static void Main()
        {
            var methodName = "car";
            var order = Orders.mail; 

            Console.WriteLine("hello world! as always ;) \n {0} , {1} ", order, (int) order);
            Console.WriteLine((Orders) 2);
            Console.WriteLine((int)(Orders) Enum.Parse(typeof(Orders),methodName));
            Console.ReadLine();
        }
    }
}
