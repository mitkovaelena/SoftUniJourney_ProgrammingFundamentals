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
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            long sum = nums.Sum();
            double average = sum/nums.Count;
            bool print = false;
            foreach (var num in nums.OrderByDescending(x => x).Take(5))
            {
                if (num > average)
                {
                    Console.Write( num + " ");
                    print = true;
                }
            }
            if (print == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
