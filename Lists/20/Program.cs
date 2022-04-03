using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            char[] reversed;
            int rev = 0;
            int sum = 0;
            string str;
            for (int i = 0; i < list.Count; i++)
            {
                reversed = list[i].ToCharArray();
                Array.Reverse(reversed);
                str = new string(reversed);
                rev = int.Parse(str);
                sum += rev;

            }
            Console.WriteLine(sum);
        }
    }
}
