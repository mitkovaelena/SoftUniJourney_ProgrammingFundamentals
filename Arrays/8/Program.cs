using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] num2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lenmax = Math.Max(num1.Length, num2.Length);
            int[] num3 = new int[lenmax];
            int k = 0;
            if (num1.Length > num2.Length)
            {
                for (int i = 0; i < lenmax; i++, k++)
                {
                    if (k < num2.Length)
                        num3[i] = num2[k];
                    else
                    {
                        k = -1;
                        i--;
                    }
                }
                for (int c = 0; c < lenmax; c++)
                {
                    Console.Write($"{num1[c] + num3[c]} ");
                }
                
            }
            else
            {
                for (int i = 0; i < lenmax; i++, k++)
                {
                    if (k < num1.Length)
                        num3[i] = num1[k];
                    else
                    {
                        k = -1;
                        i--;
                    }
                }
                for (int c = 0; c < lenmax; c++)
                {
                    Console.Write($"{num2[c] + num3[c]} ");
                }
            }           
        }
    }
}
