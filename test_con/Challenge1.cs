using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_con
{
    public class Challenge1
    {

        string str;
        public Challenge1(string str)
        {
            this.str = str;
            Console.WriteLine($"Your string: {this.str}");
            Console.WriteLine(firstUniqueChar(this.str));
        }
        public char firstUniqueChar(string str)
        {
            char res = ' ';
            const int inc = 1;
            
            Dictionary<char, int> charHolder = new Dictionary<char, int>();
            for(int i = 0; i < str.Length; i++)
            {
                if (charHolder.ContainsKey(str[i]))
                {
                    charHolder[str[i]]++;
                }
                else
                {
                    charHolder.Add(str[i], inc);
                }
            }
            foreach (KeyValuePair<char, int> kvp in charHolder)
            {
                Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
            }
            foreach (KeyValuePair<char, int> kvp in charHolder)
            {
                if (kvp.Value == inc)
                {
                    res = kvp.Key;
                    break;
                }
            }
            Console.Write("Your letter: ");
            return res;
        }
    }
}

/*
 * aaaaafeeeeedrrrrr
 * a : 5
 * f : 1 +
 * e : 5
 * d : 1
 * r : 5
 *
 *
 */
