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
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string,double> dict = new SortedDictionary<string,double>();
            for (int i = 0; i < n; i++)
            {
                string[] grad = Console.ReadLine().Split(' ').ToArray();
                double income = double.Parse(grad[2])*double.Parse(grad[3]);
                if (dict.ContainsKey(grad[0]))
                    dict[grad[0]] += income;
                else
                {
                    dict[grad[0]] = income;
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key:F2} -> {pair.Value:F2}");
            }
        }
    }
}
