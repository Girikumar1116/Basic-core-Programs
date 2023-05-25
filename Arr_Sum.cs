using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Arr_Sum
    {
        public Arr_Sum() { Sum(); }
        public static void Sum()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            Console.WriteLine(arr.Sum());
        }

    }
}
