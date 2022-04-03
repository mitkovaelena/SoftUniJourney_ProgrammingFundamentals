using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                text = text.Replace(words[i], new string('*', words[i].Length));
            }
           
            Console.WriteLine(text);
        }
    }
}

