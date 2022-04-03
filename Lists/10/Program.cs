using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> str = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;
            int max = 0;
            int ch = str[0];
            for (int i = 0; i < str.Count - 1; i++)
            {
                count = 0;
                while (str[i + count] == str[i + 1 + count])
                {
                    count++;
                    if (i + 1 + count > str.Count - 1)
                    {
                       
                        break;
                    }

                }

                if (max < count)
                {
                    max = count;
                    ch = str[i];
                }


            }
            for (int r = 0; r < max + 1; r++)
            {
                Console.Write(ch + " ");
            }
        }


    }
    }
