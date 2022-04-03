using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] nums = new long[n];
            nums[0] = 1;
            
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i; j >= i-k && j >=0 ; j--)
                {
                    sum += nums[j];
                }
                nums[i] = sum; 
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
