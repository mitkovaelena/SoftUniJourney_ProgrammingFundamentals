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
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> roots = new List<int>();
            foreach (int num in list)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                    roots.Add(num);
            }
            roots.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", roots));
        }
    }
}
