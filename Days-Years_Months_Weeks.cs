using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Days_Years_Months_Weeks
    {
        public Days_Years_Months_Weeks() { Years_Months_Weeks(); }
        public static void Years_Months_Weeks()
        {
            Console.WriteLine("enter a days");
            int days = Int32.Parse(Console.ReadLine());
            int years = days / 365;
            int Months = 12 * years;
            int weeks = Months * 4;
            Console.WriteLine("No. of years " + years);
            Console.WriteLine("Months are " + Months);
            Console.WriteLine("Weeks are: " + weeks);
        }

    }
}
