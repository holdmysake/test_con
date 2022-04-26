using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_con
{
    class Lista
    {
        private List<string> List = new List<string>();
        public Lista()
        {

        }
        public string Add(string value)
        {
            if(value is string)
            {
                Console.WriteLine($"Added string: {value}");
                List.Add(value);
            }
            else
            {
                Console.WriteLine($"Not a string: {value}");
            }
            return value;
        }
        public void DisplayAll()
        {
            int Index = 0;
            foreach(var element in List)
            {
                Console.WriteLine($"Index {Index}: {element} ");
                Index++;
            }
        }
    }
}
