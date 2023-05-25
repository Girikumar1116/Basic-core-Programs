using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Degree_kelvin_Fahrenheit
    {
        public Degree_kelvin_Fahrenheit() { Conversion(); }
        public static void Conversion()
        {
            Console.WriteLine("enter a celsius degree");
            int celsius = Int32.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Celsius degree to kelvin: " + (celsius + 273));
            Console.WriteLine("celsius degree to fahrenheit: " + fahrenheit);
        }

    }
}
