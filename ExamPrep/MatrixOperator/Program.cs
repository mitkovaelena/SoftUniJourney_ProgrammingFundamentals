using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < r; i++)
            {
                matrix.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            }
            string[] command;
            do
            {
                command = Console.ReadLine().Split(' ');

                switch (command[0])
                {
                    case "remove":
                        matrix = Rem(matrix, command);
                        break;
                    case "swap":
                        matrix = Swap(matrix, command);
                        break;
                    case "insert":
                        matrix = Ins(matrix, command);
                        break;
                    case "end":
                        break;
                }

            } while (command[0] != "end");

            for (int i = 0; i < r; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }

        }


        private static List<List<int>> Rem(List<List<int>> matrix, string[] command)
        {
            switch (command[1])
            {
                case "positive":
                    if (command[2] == "row")
                    {
                        int red = int.Parse(command[3]);
                        matrix[red] = matrix[red].Where(x => x < 0).ToList();
                    }
                    else
                    {
                        int col = int.Parse(command[3]);
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            if (matrix[i].Count > col && matrix[i][col] > 0)
                            {
                                matrix[i].RemoveAt(col);
                            }
                        }
                    }
                    break;

                case "negative":
                    if (command[2] == "row")
                    {
                        int red = int.Parse(command[3]);
                        matrix[red] = matrix[red].Where(x => x > 0).ToList();
                    }
                    else
                    {
                        int col = int.Parse(command[3]);
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            if (matrix[i].Count > col && matrix[i][col] < 0)
                            {
                                matrix[i].RemoveAt(col);
                            }
                        }
                    }
                    break;

                case "odd":
                    if (command[2] == "row")
                    {
                        int red = int.Parse(command[3]);
                        matrix[red] = matrix[red].Where(x => x % 2 == 0).ToList();
                    }
                    else
                    {
                        int col = int.Parse(command[3]);
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            if (matrix[i].Count > col && matrix[i][col] % 2 != 0)
                            {
                                matrix[i].RemoveAt(col);
                            }
                        }
                    }
                    break;

                case "even":
                    if (command[2] == "row")
                    {
                        int red = int.Parse(command[3]);
                        matrix[red] = matrix[red].Where(x => x % 2 != 0).ToList();
                    }
                    else
                    {
                        int col = int.Parse(command[3]);
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            if (matrix[i].Count > col && matrix[i][col] % 2 == 0)
                            {
                                matrix[i].RemoveAt(col);
                            }
                        }
                    }
                    break;
            }
            return matrix;
        }


        private static List<List<int>> Ins(List<List<int>> matrix, string[] command)
        {

            int row = int.Parse(command[1]);
            int num = int.Parse(command[2]);
            matrix[row].Insert(0, num);
            return matrix;
        }

        private static List<List<int>> Swap(List<List<int>> matrix, string[] command)
        {
            int first = int.Parse(command[1]);
            int sec = int.Parse(command[2]);
            List<int> temp = matrix[first];
            matrix[first] = matrix[sec];
            matrix[sec] = temp;
            return matrix;
        }
    }
}
