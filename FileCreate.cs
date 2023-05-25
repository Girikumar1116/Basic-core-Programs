using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CFp_Assignment
{
    internal class FileCreate
    {
        public FileCreate() { Creating(); }
        public static void Creating()
        {
            string filePath = @"D:/csharp/ex/test.txt";
            bool pathExists = File.Exists(Path.GetDirectoryName(filePath));
            if (pathExists)
            {
                Console.WriteLine("Path Already Exists");
            }
            else
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                FileStream stream = File.Create(filePath);

                Console.WriteLine("Path Created " + Path.GetDirectoryName(filePath));
            }

        }
    }

}

