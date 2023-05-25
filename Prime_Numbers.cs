using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Prime_Numbers
    {
        public Prime_Numbers() { prime(); }
        public static void prime()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool t = false;
                for (int j = 2; j <= i - 1; j++)  // for(int j=2;j<=50;j++)
                {
                    if (i % j == 0)                // if(i!=j && i%j==0)
                    {
                        t = true;
                        break;
                    }
                }
                if (t == false)
                    Console.Write(i + " ");
            }
        }

    }
}
