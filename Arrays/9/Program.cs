using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = nums.Length - 1;
            for (int i = 0; i < len; i++)
            {
                nums[i] = nums[i] + nums[i + 1];
                if ( i == len-1)
                {
                    i = -1;
                    len--; ;
                }
            }
            Console.WriteLine(nums[0]);
        }
    }
}
