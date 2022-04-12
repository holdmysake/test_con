using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_con
{
    public class main
    {
        static public void Main()
        {

            string userIn = " ";
            userIn = Console.ReadLine();  
            Challenge1 chall = new Challenge1(userIn);
            /*
            FileManager obj1 = new FileManager();
            Something som1 = new Something();
            som1.useall();//obj1.directory();
            */
        }
    }
}