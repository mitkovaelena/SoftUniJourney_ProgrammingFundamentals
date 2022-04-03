using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = rc[0];
            int c = rc[1];
            long[][] matrix = new long[r][];
            

            for (int i = 0; i < r; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            }

            int[] ind = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ind1 = ind[0];
            int ind2 = ind[1];

            long sum = matrix[ind1 - 1][ind2 - 1] + matrix[ind1 - 1][ind2] + matrix[ind1 - 1][ind2 + 1] +
                       matrix[ind1][ind2 - 1] + matrix[ind1][ind2 + 1] +
                       matrix[ind1 + 1][ind2 - 1] + matrix[ind1 + 1][ind2] + matrix[ind1 + 1][ind2 + 1];

            matrix[ind1 - 1][ind2 - 1] *= matrix[ind1][ind2];
            matrix[ind1 - 1][ind2] *= matrix[ind1][ind2];
            matrix[ind1 - 1][ind2 + 1] *= matrix[ind1][ind2];
            matrix[ind1][ind2 - 1] *= matrix[ind1][ind2];
            matrix[ind1][ind2 + 1] *= matrix[ind1][ind2];
            matrix[ind1 + 1][ind2 - 1] *= matrix[ind1][ind2];
            matrix[ind1 + 1][ind2] *= matrix[ind1][ind2];
            matrix[ind1 + 1][ind2 + 1] *= matrix[ind1][ind2];

            matrix[ind1][ind2] *= sum;

            for (int i = 0; i < r; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
            
        }
    }
}
