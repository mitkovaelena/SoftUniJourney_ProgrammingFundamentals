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
            decimal[] input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
           SortedDictionary<decimal, int> dict = new SortedDictionary<decimal,int>();
            foreach (decimal num in input)
            {
                if (dict.ContainsKey(num))
                    dict[num] += 1;
                else
                    dict[num] = 1;
            }
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key,pair.Value);
            }
        }
    }
}
