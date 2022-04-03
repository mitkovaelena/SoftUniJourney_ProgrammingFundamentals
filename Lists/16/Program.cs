using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string type = input[0].ToUpper();
            int rows = int.Parse(input[1]);
            int cols = int.Parse(input[2]);


            switch (type)
            {
                case "A":
                    MatrixA(rows, cols);
                    break;
                case "B":
                    MatrixB(rows, cols);
                    break;
                case "C":
                    MatrixC(rows, cols);
                    break;
                case "D":
                    MatrixD(rows, cols);
                    break;
            }

        }

        private static void MatrixA(int rows, int cols)
        {

            int c = 1;
            int d = 1;
            for (int i = 0; i < rows; i++)
            {
                c = d;
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(c + " ");
                    c += rows;
                }
                d++;
                Console.WriteLine();

            }

        }

        private static void MatrixB(int rows, int cols)
        {
            int[][] matrix = new int[rows][];
            int a = 1;


            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = a++;
                }
                if (row % 2 == 1)
                {
                    Array.Reverse(matrix[row]);
                }
            }


            for (int c = 0; c < cols; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    Console.Write(matrix[r][c] + " ");
                }
                Console.WriteLine();

            }


        }

        private static void MatrixC(int rows, int cols)
        {

        }

        private static void MatrixD(int rows, int cols)
        {
          
        }
    }
}
