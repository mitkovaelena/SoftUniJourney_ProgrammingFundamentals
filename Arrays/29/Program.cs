using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alpha = new char[26];
            char ch = 'a';
            for (int i = 0; i < 26; i++)
            {
                alpha[i] = ch++;
            }

            string str = Console.ReadLine();
            for (int a = 0; a < str.Length; a++)
            {
                int index = alpha.ToList().IndexOf(str[a]);
                Console.WriteLine($"{str[a]} -> {index}");
            }
        }
    }
}
