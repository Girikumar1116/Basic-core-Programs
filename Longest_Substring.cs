using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFp_Assignment
{
    internal class Longest_Substring
    {
        public Longest_Substring() { Substring(); }
        public static void Substring()
        {
            List<char> list = new List<char>();
            Console.WriteLine("enter a string");
            string s = Console.ReadLine(); //ABDEFGABEF
            int max = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                list.Add(s[i]);
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (!list.Contains(s[j]))
                    {
                        list.Add(s[j]);
                    }
                    else
                    {
                        max = Math.Max(max, list.Count);
                        list.Clear();
                        break;
                    }
                }
            }
            Console.WriteLine(max);
        }

    }
}
