using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoftUniWaterSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            double water = long.Parse(Console.ReadLine());
            double[] bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            long capacity = long.Parse(Console.ReadLine());

            bool ok = true;
            int ind = 0;
            int indEmpty = 0;

            if (water % 2 != 0)
            {
                Array.Reverse(bottles);
            }
            foreach (double bottle in bottles)
            {
                water -= capacity - bottle;
                ind++;
                if (water < 0 && ok == true)
                {
                    indEmpty = bottles.Length - ind + 1;
                    ok = false;
                }
                else if (water == 0 && ok == true)
                {
                    indEmpty = bottles.Length - ind;
                    ok = false;
                }
            }

            if (water >= 0)
            {
                Console.WriteLine("Enough water!\nWater left: {0}l.", water);
                return;
            }
            else
            {
                Console.WriteLine("We need more water!\nBottles left: {0}", indEmpty);
                int[] indexes = new int[indEmpty];

                if (water % 2 == 0)
                {
                    for (int i = 0; i < indexes.Length; i++)
                    {
                        indexes[i] = i;
                    }
                }
                else
                {
                    for (int i = indexes.Length - 1, j = 0; i >= 0; i--, j++)
                    {
                        indexes[j] = i;
                    }
                }

                Console.WriteLine("With indexes: {0}", string.Join(", ", indexes));
                Console.WriteLine("We need {0} more liters!", Math.Abs(water));
            }


        }
    }
}
