using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int startInd = 0;
            int count = 0;
            while (true)
            {
                int ind = str.IndexOf(word, startInd);
                startInd = ind + 1;
                if (ind != -1)
                    count++;
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}

 