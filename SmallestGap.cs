using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class SmallestGap
    {
        public SmallestGap() { Min(); }
        public static void Min()
        {
            int[] arr = { 200, 300, 250, 151, 162 };
            int min = 9999;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < i + 2; j++)
                {
                    int a = Math.Abs(arr[i] - arr[j]);
                    min = Math.Min(a, min);
                }
            }
            Console.WriteLine(min);
        }


    }
}
