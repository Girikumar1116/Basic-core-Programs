using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    public class Circles_Perimeter_Area
    {
        public Circles_Perimeter_Area() { Area_Perimeter(); }
        public static void Area_Perimeter()
        {
            Console.WriteLine("enter radius of a circle");
            int radius = Int32.Parse(Console.ReadLine());
            double s = Math.PI;
            double area = s * radius;
            Console.WriteLine($"Area of a circle {area}");
            Console.WriteLine("Perimeter of a circle is: " + (2 * area));
        }

    }
}
