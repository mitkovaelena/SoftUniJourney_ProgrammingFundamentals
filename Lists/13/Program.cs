using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[][] matrix = new string[rc[0]][];
            int count = 0;
            for (int row = 0; row < rc[0]; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').ToArray();
            }
            int j = rc[1] - 1;
            for (int i = 0; i < rc[0]-1; i++)
            {
                for (int k = 0; k < rc[1] - 1; k++)
                {
                    if (matrix[i][k] == matrix[i][k + 1] && matrix[i][k] == matrix[i + 1][k] &&
                        matrix[i + 1][k] == matrix[i + 1][k + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
