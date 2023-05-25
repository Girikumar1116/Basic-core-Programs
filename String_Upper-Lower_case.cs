using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public  class String_Upper_Lower_case
    {
        public String_Upper_Lower_case() { Upper_Lower(); }
        public static void Upper_Lower()
        {
            Console.WriteLine("enter a place name");
            string s = Console.ReadLine();
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
        }

    }
}
