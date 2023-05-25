using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Execution_Time
    {
        public Execution_Time() { Time(); }
        public static void Time()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("hello world");
            watch.Stop();
            Console.WriteLine($"Execution time:{watch.ElapsedMilliseconds} ms");
        }

    }
}
