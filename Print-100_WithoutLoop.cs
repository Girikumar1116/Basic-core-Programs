using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public  class Print_100_WithoutLoop
    {
        public Print_100_WithoutLoop() { Without_Loop(100); }
        public static int Without_Loop(int n)
        {
            if (n == 0)
                return 0;
            else
            {
                Console.WriteLine(n);
                return Without_Loop(n - 1);
            }
        }
    


    }
}
