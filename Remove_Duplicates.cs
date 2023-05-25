using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Remove_Duplicates
    {
        public Remove_Duplicates() { Unique(); }
        public static void Unique()
        {
            string[] arr = { "25", "Anna", "False", "25", "4/15/2021 12:10:51 PM", "112.22", "Anna", "False" };
            string[] unique = arr.Distinct().ToArray();
            Array.ForEach(unique, i => Console.WriteLine(i));

        }

    }
}
