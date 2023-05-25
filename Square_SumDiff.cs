using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public  class Square_SumDiff
    {
        public Square_SumDiff() { Sum_Diff(); }
        public static void Sum_Diff()
        {
            Console.WriteLine("enter a value");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter b value");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sum is:" + (Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine("Difference is:" + Math.Abs(Math.Pow(a, 2) - Math.Pow(b, 2)));
        }

    }
}
