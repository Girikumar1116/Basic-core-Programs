using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    internal class Without_Math
    {
        public Without_Math() { Without_Sqrt(); }
        public static void Without_Sqrt()
        {
            Console.WriteLine("enter a number for square root");
            int x = Int32.Parse(Console.ReadLine());
            double squareRoot = Math.Ceiling(Math.Pow(x, (double)1 / 2));

            /*if (x < 2)
                 Console.WriteLine(x);
             double y = x;
             double z = (y + (x / y)) / 2;
             while (Math.Abs(y - z) >= 0.00001)
             {
                 y = z;
                 z = (y + (x / y)) / 2;
             }
            Console.WriteLine(z);*/
            Console.WriteLine("root is" + squareRoot);
        }

    }
}
