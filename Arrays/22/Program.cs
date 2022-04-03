using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charSeparators = new char[] { ' ' };
            int[] nums = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int repeat = int.Parse(Console.ReadLine());
            int[] sum = new int[nums.Length];
            for (int k = 0; k < repeat; k++)
            {

                int last = nums[nums.Length - 1];
                for (int i = nums.Length - 1; i > 0; i--)
                {
                    nums[i] = nums[i - 1];
                    sum[i] += nums[i];
                }
                nums[0] = last;
                sum[0] += nums[0];
            }
            string l = string.Join(" ", sum);
                            Console.WriteLine(l);
            
        }
    }
}
