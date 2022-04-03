using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static long TmpSum(int[][] matrix, int row, int col)
        {
            long sum = 0;
            for (int tmpRow = row; tmpRow < row + 3; tmpRow++)
            {
                for (int tmpCol = col; tmpCol < col + 3; tmpCol++)
                {
                    sum += matrix[tmpRow][tmpCol];
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[][] matrix = new int[rc[0]][];
            long max = long.MinValue;
            long sum = 0;
            int maxi = 0;
            int maxk = 0;
            for (int row = 0; row < rc[0]; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            for (int i = 0; i < rc[0] - 2; i++)
            {
                for (int k = 0; k < rc[1] - 2; k++)
                {

                    sum = TmpSum(matrix, i, k);
                    if (max < sum)
                    {
                        max = sum;
                        maxi = i;
                        maxk = k;
                    }
                }
            }
            Console.WriteLine(max);
            long[] arr = new long[3];
            for (int i = 0; i < 3; i++)
            {
                Array.Copy(matrix[maxi], maxk, arr, 0, 3);
                Console.WriteLine(string.Join(" ", arr));
                maxi++;
            }

        }
    }
}
