using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
   public class Factorial
    {
        public Factorial() { Factorials(); }
        public static void Factorials()
        {
            Stopwatch watch = new Stopwatch();
            Console.WriteLine("enter a number for factorial");
            int number = Int32.Parse(Console.ReadLine());
            int result = 1;
            watch.Start();
            for (int i = 1; i <= number; i++)
            {
                result = (result * i);
                Console.WriteLine(result);
            }
            watch.Stop();
            Console.WriteLine(result);

        }

    }
}
