using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] charSeparators = new char[] { ' ' };
            int[] nums = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] freq = new int[nums.Max()+1];
            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }
            int max = freq.Max();
            for (int k = 0; k < nums.Length; k++)
            {
                if (freq[nums[k]] == max)
                {
                    freq[nums[k]] ++;
                    break;
                }
            }
            max = freq.Max();
            int maxIndex = freq.ToList().IndexOf(max);

            Console.WriteLine(maxIndex);
        }
    }
}
