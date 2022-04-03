using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();
            list.Reverse();
            foreach (string str in list)
            {
                List<string> nums = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }
            Console.WriteLine(string.Join(" ", result));            
        }
    }
}
