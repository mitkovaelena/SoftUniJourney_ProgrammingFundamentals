using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(' ').ToArray();
            Array.Reverse(arr);
            str = string.Join(" ",arr);
            Console.WriteLine(str);
        }
    }
}
