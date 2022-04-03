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

            char[] charSeparators = new char[] { ' ' };
            int[] str = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int count = 1;
            int max = 1;
            int ch = str[0];
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] < str[i + 1])
                {
                    count++;
                    for (int k = i + 1; k < str.Length - 1; k++)
                    {
                        if (str[k] < str[k + 1])
                        {
                            count++;
                            if (max < count)
                            {
                                max = count;
                                ch = k - max+2;
                            }
                        }
                        else
                        {
                            if (max < count)
                            {
                                max = count;
                                ch = k - max+2;
                            }
                            count = 1;
                            break;
                        }
                        i = i + k;
                    }
                }
            }
            for (int r = 0; r < max; r++)
            {
                Console.Write(str[ch] + " ");
                ch++;
            }



        }


    }
}
