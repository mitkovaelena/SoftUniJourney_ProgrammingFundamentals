using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            long health = long.Parse(Console.ReadLine());
            int[] rc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = rc[0];
            int cols = rc[1];
            char[][] matrix = new char[rows][];


            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            List<char> path = new List<char>();
            List<int> rr = new List<int>();
            List<int> cc = new List<int>();


            for (int col = 0; col < cols; col++)
            {
                if (col%2 == 0)
                {
                    
                    for (int row = 0; row < rows; row++)
                    {
                        path.Add(matrix[row][col]);
                        rr.Add(row);
                        cc.Add(col);
                    }
                    
                }
                else
                {
                    for (int row = rows-1; row >= 0; row--)
                    {
                        path.Add(matrix[row][col]);
                        rr.Add(row);
                        cc.Add(col);
                    }
                }

            }

            int numTurns = 0;
            int moves = 0;
            int[] curCell = new int[2];
            curCell[0] = 0;
            curCell[1] = 0;
            

            foreach (char obst in path)
            {
                switch (obst)
                {
                    case 'F':
                        health -= numTurns/2;
                        numTurns++;
                        moves++;
                        break;
                    case 'H':
                        health += numTurns / 3;
                        numTurns++;
                        moves++;
                        break;
                    case 'T':
                        numTurns+=3;
                        moves++;
                        break;
                    case 'E':
                        numTurns++;
                        moves++;
                        break;
                }
                if (health <= 0)
                {
                    numTurns--;
                    moves--;
                    break;
                }
            }

            if (health > 0)
            {
                Console.WriteLine($"Quest completed!\nHealth: {health}\nTurns: {numTurns}");
            }

            else
            {
                Console.WriteLine($"Died at: [{rr[moves]}, {cc[moves]}]");
            }

        }
    }
}
