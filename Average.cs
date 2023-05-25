using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Average
    {
        public Average() { Avg_numbers(); }
        public static void Avg_numbers()
        {
            Random rand = new Random();
            int Avg = 0;
            for (int i = 0; i < 5; i++)
            {
                int numbers = rand.Next(10, 51);
                Avg += numbers;
                Console.Write(numbers + " ");
            }
            Console.WriteLine("Average value is " + Avg);

        }
    }
}