using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class DivisibleBy_7_Not_5
    {
        public DivisibleBy_7_Not_5() { Divisibility(); }
        public static void Divisibility()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 2000; i <= 3200; i++)
            {
                if (i % 7 == 0 && i % 5 != 0)
                    Console.Write(i + ",");
            }
            watch.Stop();

        }

    }
}
