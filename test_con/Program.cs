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
            Lista obj = new Lista();
            obj.Add("Staura");
            obj.Add("Max");
            obj.Add("Maxxxx");
            obj.Add("Staura");
            obj.Add("XD");
            obj.Add("Staura");
            obj.DisplayAll();

            /*
            string userIn = " ";
            userIn = Console.ReadLine();  
            Challenge1 chall = new Challenge1(userIn);
            
            FileManager obj1 = new FileManager();
            Something som1 = new Something();
            som1.useall();//obj1.directory();
            */
        }
    }
}