using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Delete_pos_Array
    {
        public Delete_pos_Array() { Delete(); }
        public static void Delete()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("enter position of array");
            int pos = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < pos - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int i = pos; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
