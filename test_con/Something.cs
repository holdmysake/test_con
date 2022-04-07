using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_con
{
    public class Something
    {
        private int age = 0;
        private string name = null;
        private DateTime datenow = DateTime.Now;
        ArrayList ALuse = new ArrayList();
        public void useall()
        {
            setName();
            setAge();
            add();
            display();
        }
        public void setName()
        {
            Console.WriteLine("Please, type your name: ");
            name = Console.ReadLine();
        }
        public void setAge()
        {
            Console.WriteLine("Now, enter your name: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void add()
        {
            ALuse.Add(name);
            ALuse.Add(age);
            ALuse.Add(datenow);
        }
        public void display()
        {
            foreach (var item in ALuse)
            {
                Console.WriteLine(item);
            }
        }
    }
}
