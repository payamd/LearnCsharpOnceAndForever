using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LearnCsharpOneTimeAndForever.Classes;

namespace LearnCsharpOneTimeAndForever
{
    class Program
    {
        static void Main(string[] args)
        {
            //valid_invalid.isvalid();
            //MAxOfTwo.maxoftow();
            //orientation.orient();
            //max_of_serries.getmax();
            //Console.WriteLine(Text.SummerizeText("salam payam joon khubi pesar che khabara ? ajab barname haye jalebi !!!!",37));
            //Console.WriteLine(   PList.heyphen());
            //PList.dublicate();
            //PList.classnamemaker();
            //PList.vowel();
            //Console.ReadLine();
            //max_of_serries m = new max_of_serries();
            //m.getmax();

            //var sw = new Stopwatch();
            //while (true) {
            //    var input = Console.ReadLine();
            //    if (input == "end")
            //    {
            //        break;
            //    }
            //    else if (input == "start") {
            //        sw.start();
            //    }
            //    else if (input == "stop")
            //    {
            //        sw.stop();
            //    }
            //}

            //var pm = new Postmsg("firstmesg","salam chetori pesar?");
            //while (true)
            //{
            //    var input = Console.ReadLine();
            //    if (input == "end")
            //    {
            //        break;
            //    }
            //    else if (input == "up")
            //    {
            //        pm.up_vote();
            //    }
            //    else if (input == "down")
            //    {
            //        pm.updown_vote();
            //    }
            //    else if (input == "vote")
            //    {
            //       Console.WriteLine("votes  " + pm.vote());
            //    }
            //}

            //var stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //Console.ReadLine();

            //var dbO = new OracleDbConnection();
            //var dbS = new OracleDbConnection();
            //dbO.ConnectionString_open();
            //dbO.ConnectionString_close();
            //dbS.ConnectionString_open();
            //dbS.ConnectionString_close();


            var workflow = new WorkFlow();
            workflow.Add(new Videouploader());
            workflow.Add(new Sendemail());
            workflow.Add(new Callwebservice());

            var engine = new WorkFlowEngine();
            engine.Run(workflow);

            Console.ReadLine();


        }
    }
}
