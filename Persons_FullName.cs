using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public  class Persons_FullName
    {
        public Persons_FullName() { Full_Name(); }
        public static void Full_Name()
        {
            Console.WriteLine("enter a fullname");
            string s = Console.ReadLine();
            string[] count = s.Split(" ");
            int c = 0;
            foreach (var name in count)
            {
                c += 1;
                Console.WriteLine(name);
            }
            Console.WriteLine(c + " parts of argument in name");

        }

    }
}
