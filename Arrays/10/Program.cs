using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = nums.Length;
            if (len == 1)
                Console.WriteLine($"{{ {nums[0]} }}");
            else if (len % 2 == 0)
            {
                Console.WriteLine($"{{ {nums[len/2-1]}, {nums[(len/2)]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {nums[len / 2-1]}, {nums[len / 2]}, {nums[len / 2 + 1]} }}");
            }
        }
    }
}
