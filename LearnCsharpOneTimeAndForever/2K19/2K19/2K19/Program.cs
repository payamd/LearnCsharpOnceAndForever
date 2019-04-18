using System;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace _2K19
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new WorkflowEngine();

            x.Addtolist(new Callwebservice());
            x.Addtolist(new UploadVideo());
            x.Addtolist(new Sendemail());
            x.Addtolist(new Changestatus());
            x.Run();

        }
    }

}





//var stack = new Stack();
//stack.Age = 12;
//stack.Name = "Payam";
//Console.WriteLine(stack.Age);
//Console.WriteLine(stack.Name);
//while (true)
//{
//Console.WriteLine("enter your command please:");
//var read = Console.ReadLine();
//    if (read == "exit")
//break;
//else if (read == "push")
//    stack.Push(Console.ReadLine());
//    else if (read == "pop")
//    stack.Pop();
//    else if (read == "clear")
//    stack.Clear();
//}







//var connection = new DbCommands(new OracleConnection("tospace"));
//var connection2 = new DbCommands(new SqlConnection("to zamin"));
//connection.Execute();
//connection2.Execute();