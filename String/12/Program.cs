using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charSeparators = new char[] {'/'};
            string[] words = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int ind = 0;
            if (words[0][words[0].Length-1] == ':')
            {
                words[0] = words[0].Remove(words[0].Length - 1, 1);
                Console.WriteLine($"[protocol] = \"{words[ind++]}\"");
            }
            else
                Console.WriteLine("[protocol] = \"\"");

            Console.WriteLine($"[server] = \"{words[ind++]}\"");
            if (words.Length == ind+1)
                Console.WriteLine($"[resource] = \"{words[ind]}\"");
            else if (words.Length > ind + 1)
                Console.WriteLine($"[resource] = \"{string.Join("/", words, ind, words.Length - ind)}\"");
            else
                Console.WriteLine("[resource] = \"\"");
        }
    
    }
}
