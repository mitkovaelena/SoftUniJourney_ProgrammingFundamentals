using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            int primary = 0;
            int secondary = 0;
            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            int j = n-1;
            for (int i = 0; i < n; i++)
            {
                primary += matrix[i][i];
                secondary += matrix[i][j];
                
                j--;
            }
            Console.WriteLine(Math.Abs(primary-secondary));

        }
    }
}
