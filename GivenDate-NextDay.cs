using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class GivenDate_NextDay
    {
        public GivenDate_NextDay() { NextDay(); }
        public static void NextDay()
        {
            CultureInfo ci = new CultureInfo("en-us");
            DateTime givenDate = new DateTime(2019, 02, 01);
            DateTime nextDate = givenDate.AddDays(1);
            Console.WriteLine("next day:{0} ({1})", nextDate.ToString("yyyy-MM-dd"), nextDate.ToString("dddd", ci));

        }
    }
}
