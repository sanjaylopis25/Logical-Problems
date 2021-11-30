using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace Logical_Problems
{
    class Watch
    {
        public static void IterateOverLoop()
        {
            for (int i =0; i<=10; i++)
            {
                Console.Write(i);
            }
        }
        public static void ElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            IterateOverLoop();
            stopwatch.Stop();
            Console.WriteLine("Taken time to execute IterateOverLoop in milisecond is: "+stopwatch.ElapsedMilliseconds);
        }
    }
}
