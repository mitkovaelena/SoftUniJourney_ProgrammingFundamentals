using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] charSeparators = new char[] { ' ' };
            int[] nums = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == n)
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
