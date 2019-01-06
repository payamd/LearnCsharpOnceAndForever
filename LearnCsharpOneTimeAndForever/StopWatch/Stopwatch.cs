using System;
using System.Collections.Generic;

namespace StopWatch
{
    public class Stopwatch
    {
        private bool _flag;
        private DateTime _startTime;
        private readonly List<TimeSpan> _records = new List<TimeSpan>();

        public void Swstart(DateTime start)
        {
            if (_flag) return;
            _startTime = start;
            _flag = true;
        }

        public void SwStop()
        {
            if (!_flag) return;
            _records.Add((DateTime.Now - _startTime));
            _flag = false;
        }

        public void SwShow()
        {
            foreach (var record in _records)
            {
                Console.WriteLine(record);
            }
        }

    }
}