using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string two = Console.ReadLine();

            char[] arr = one.ToCharArray();
            string test;
            for (int j = 0; j < one.Length; j++)
            {

                for (int i = 1; i < one.Length-j; i++)
                {
                    test = one.Substring(j, i);
                    if (two.IndexOf(test) >= 0)
                    {
                        Console.WriteLine("yes");
                        return;
                    }
                }
            }
            Console.WriteLine("no");
        }
    }
}
