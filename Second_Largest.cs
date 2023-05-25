using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Second_Largest
    {
        public Second_Largest() { Largest(); }
        public static void Largest()
        {
            int[] arr = { 2, 9, 1, 4, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            Console.WriteLine(arr[arr.Length - 2]);
        }
    }
}
