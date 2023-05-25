using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Numbers_factors
    {
        public Numbers_factors() { Factors_onNumbers(); }
        public static void Factors_onNumbers()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>() { { 3, "Pling" }, { 5, "Plang" }, { 7, "plong" } };
            Console.WriteLine("enter a number");
            int num = Int32.Parse(Console.ReadLine());
            bool t = false, s = false;

            while (t == false)
            {
                foreach (KeyValuePair<int, string> ele in dic)
                {
                    if (num % ele.Key == 0)
                    {
                        s = true;
                        Console.Write(ele.Value);
                    }
                }
                if (s == false)
                    Console.WriteLine(num);
                t = true;
            }
        }

    }
}
