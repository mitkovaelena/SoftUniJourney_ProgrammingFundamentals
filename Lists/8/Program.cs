using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            char[][] matrix = new char[r][];
            char letter = 'A';
            for (int i = 0; i < r; i++)
            {
                matrix[i] = new char[c];
                for (int k = 0; k < c; k++)
                {
                    matrix[i][k] = letter++;
                }
            }
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
