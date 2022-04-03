using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int[] path = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int sum = 0;
            for (int i = 0; i < path.Length; i++)
            {
                sum += matrix[start][path[i]];
                start = path[i];
            }
            Console.WriteLine(sum);
        }
    }
}
