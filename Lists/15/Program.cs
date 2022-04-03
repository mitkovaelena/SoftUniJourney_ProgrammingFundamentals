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
                    if ((tmpRow == row + 1 && tmpCol == col) || tmpRow == row + 1 && tmpCol == col + 2)
                        continue;
                    sum += matrix[tmpRow][tmpCol];
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[][] matrix = new int[6][];
            long max = long.MinValue;
            long sum = 0;
            int maxi = 0;
            int maxk = 0;
            for (int row = 0; row < 6; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            for (int i = 0; i <6 - 2; i++)
            {
                for (int k = 0; k < 6 - 2; k++)
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
           
        }
    }
}
