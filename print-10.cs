using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class print_10
    {
        public print_10() { Printing(); }
        public static void Printing()
        {
            Console.WriteLine("enter a number");
            string s = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(s + " is string only");
            }

        }
    }
}