using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string num in input)
            {
                if (dict.ContainsKey(num))
                    dict[num] += 1;
                else
                    dict[num] = 1;
            }
            List<string> list = new List<string>();
            foreach (var pair in dict)
            {
                if (pair.Value%2 == 1)
                    list.Add(pair.Key);
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
