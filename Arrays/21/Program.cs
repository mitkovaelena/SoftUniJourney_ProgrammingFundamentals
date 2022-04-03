using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ').ToArray();
            string[] str2 = Console.ReadLine().Split(' ').ToArray();
            int count1 = CommonEnd( str1,  str2);           
            
            Array.Reverse(str1);
            Array.Reverse(str2);
            int count2 = CommonEnd(str1, str2);
            Console.WriteLine(Math.Max(count1,count2));
        }

        static int CommonEnd (string[] str1, string[] str2)
        {
            int count = 0;
            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                if (str1[i] == str2[i])
                    count++;
                else
                    break;
            }
            return count;
        }
    }
}
