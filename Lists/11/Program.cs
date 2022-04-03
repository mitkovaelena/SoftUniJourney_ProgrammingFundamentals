using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char one = 'a';
            char two = 'a';


            for (int i = 0; i < rc[0]; i++)
            {
                for (int j = 0; j < rc[1]; j++)
                {
                    Console.Write($"{one}{two}{one} ");
                    two++;
                }
                Console.WriteLine(  );
                two = ++one;
            }


        }
    }
}
