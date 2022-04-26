using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_con
{
    public class FileManager
    {
        private StringBuilder path = new StringBuilder();//path for directory 
        public FileManager()//constructor
        {

        }
        public void directory()//directory creator method
        {
            Console.Write("Please, indicate path: ");
            path.Append(Console.ReadLine());
            Console.WriteLine($"Creating folder. . .{path}");
            DirectoryInfo DI = Directory.CreateDirectory(path.ToString());
        }
        public void writeTo()//Writing to file method
        {
            if (!File.Exists(path.ToString()))
            {
                using (StreamWriter sw = new StreamWriter(path.ToString()))
                {
                    sw.WriteLine("TEST");
                }
            }
        }//
        public void readFrom()//reading from file method
        {
            using (StreamReader sr = new StreamReader(path.ToString()))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
