using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            char[] charSeparators = new char[] {'.', '!', '?' };
            char[] charSeparators2 = new char[] { ' ', '.', ',', ':', ';', ')', '(', '[', ']', '"', '\'', '\\', '/', '!', '?' };
            string[] sents = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (string sent in sents)
            {
                string[] words =sent.Split(charSeparators2, StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string word in words)
                {
                    if (word == key)
                    {
                        Console.WriteLine(string.Join(" ", sent));
                    }
                }
            }
        }
    }
}
