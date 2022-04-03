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
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] occur = new int[list.Max()];
            list.Sort();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    occur[i]++;
                    list.RemoveAt(i + 1);
                    i = -1;
                }
            }
            for (int n = 0; n < list.Count; n++)
            {            
                Console.WriteLine("{0} -> {1}", list[n], occur[n]+1);
            }
        }
    }
}
