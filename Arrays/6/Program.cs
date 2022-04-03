using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            double[] num = str.Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < num.Length; i++)
            {
                double num1 = Math.Round(num[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num[i]} -> {num1}");
            }
        }
    }
}
