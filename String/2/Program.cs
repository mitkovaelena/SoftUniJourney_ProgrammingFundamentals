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
            decimal total = 0;
            decimal[] num = Console.ReadLine().Split(' ', '\n').Select(decimal.Parse).ToArray();
            Console.WriteLine("/" + new string('-', 22) + "\\");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"| {num[i],20:f2} |");
                total += num[i];
            }
            Console.WriteLine("|" + new string('-', 22) + "|");
            Console.WriteLine($"| Total: {total,13:f2} |", total);
            Console.WriteLine("\\" + new string('-', 22) + "/");
        }
    }
}
