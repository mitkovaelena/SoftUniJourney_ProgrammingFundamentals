using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int second = rnd.Next(0, input.Length);
                string tmp = input[second];
                input[second] = input[i];
                input[i] = tmp;
            }
            foreach (var word in input)
            {
                Console.WriteLine( word);
            }
            
        }
    }
}
