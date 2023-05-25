using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class PresentOrNone
    {
        public PresentOrNone() { Checking(); }
        public static void Checking()
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            char[] a = { 'a', 'e', 'p' };
            int count = 0;
            foreach (char c in a)
            {
                if (s.Contains(c))
                {
                    count += 1;
                }
            }
            if (count == a.Length)
                Console.WriteLine("All r presents");
            else if (count > 0)
                Console.WriteLine("One or more-present");
            else
                Console.WriteLine("None present");
        }

    }
}
