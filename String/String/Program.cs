using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            int[] count = new int[input.Max()+1];

            for (int i = 0; i < input.Length; i++)
            {
                count[input[i]]++;                    
            }
            for (int k = 0; k < count.Length; k++)
            {
                if (count[k] > 0)
                {
                    char ch = (char)k;
                    Console.WriteLine($"{ch} -> {count[k]}");
                }
            }
        }
    }
}
