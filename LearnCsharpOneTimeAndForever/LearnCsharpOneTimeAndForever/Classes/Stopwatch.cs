using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharpOneTimeAndForever.Classes
{
    class Stopwatch
    {
        public List<TimeSpan> Recoreds = new List<TimeSpan>();
        public bool flag = true;
        public DateTime starttime;
        public TimeSpan Duration;


        public void start() {
            if (flag)
            {
               starttime = DateTime.Now;
                flag = false;
            }

    }



        public void stop()
        {

            if (!flag) {
              Duration = DateTime.Now - starttime;
                flag = true;
                Recoreds.Add(Duration);
            }


            foreach (var record in Recoreds) {
                Console.WriteLine("all time :" + record);

            }

        }
    }
}

