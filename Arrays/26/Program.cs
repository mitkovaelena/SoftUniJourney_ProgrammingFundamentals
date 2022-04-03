using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int count = 1;
            int max = 1;
            string ch = str[0];
            for (int i = 0; i < str.Length-1 ; i++)
            {
                count = 0;
                while (str[i + count] == str[i + 1 + count])
                {
                    count++;
                    if (i + 1 + count > str.Length - 1)
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