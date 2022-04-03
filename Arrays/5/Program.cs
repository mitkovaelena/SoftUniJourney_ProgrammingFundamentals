using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool ok = false;
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    sum = num[i] + num[j];
                    if (num.Contains(sum))
                    {
                        Console.WriteLine($"{num[i]} + {num[j]} == {sum}");
                        ok = true;

                    }
                }
            }
            if (ok == false)
                Console.WriteLine("No");
        }
    }
}
