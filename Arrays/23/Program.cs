using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charSeparators = new char[] { ' ' };
            int[] nums = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int len = nums.Length;
            int[] sum = new int[len / 2];
            int m = len/4-1;
            int k = len / 4;
            for (int i = 0; i < len/4; i++)
            {
                sum[i] = nums[m--] + nums[k++];
            }
            k = len-1;
            m = len / 4;
            for (int g = len/2; g < len*3 / 4; g++)
            {
                sum[m++] = nums[g] + nums[k--];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
