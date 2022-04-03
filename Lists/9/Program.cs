using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {

            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string[][] matrix = new string[r][];

            for (int i = 0; i < r; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ');
            }

            for (int col = 0; col < c; col++)
            {
                for (int row = r - 1; row >= 0; row--)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
