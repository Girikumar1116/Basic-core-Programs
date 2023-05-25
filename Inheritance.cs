using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    class parent
    {
        public int a = 10;
        public int b = 20;
    }
    class child : parent
    {
        public int Sum()
        {
            return a + b;
        }
    }
    public class Inheritance
    {

        public  Inheritance()
        {
            child c = new child();
            Console.WriteLine(c.Sum());
        }


    }
}