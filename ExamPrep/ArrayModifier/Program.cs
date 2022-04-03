using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] command;
            long[] result = new long[arr.Length];
            do
            {
                command = Console.ReadLine().Split(' ').ToArray();

                switch (command[0])
                {
                    case "swap":
                        result = Swap(command[1], command[2], arr);
                        break;
                    case "multiply":
                        result = Multiply(command[1], command[2], arr);
                        break;
                    case "decrease":
                        result = Decrease(arr);
                        break;
                    default:
                        break;
                }
            } while (command[0] != "end");
            Console.WriteLine(  string.Join(", ", result));

        }

        private static long[] Decrease(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]--;
            }
            return array;
        }

        private static long[] Multiply(string v1, string v2, long[] array)
        {
            int ind1 = int.Parse(v1);
            int ind2 = int.Parse(v2);
            array[ind1] = array[ind1]*array[ind2];
            return array;
        }

        private static long[] Swap(string v1, string v2, long[] array)
        {
            int ind1 = int.Parse(v1);
            int ind2 = int.Parse(v2);
            long a = array[ind1];
            array[ind1] = array[ind2];
            array[ind2] = a;
            return array;
        }
    }
}
