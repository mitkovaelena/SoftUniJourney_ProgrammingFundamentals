using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday","Friday", "Saturday", "Sunday"};
            if (day >0 && day <8)
            Console.WriteLine(weekdays[day-1]);
            else
                Console.WriteLine("Invalid Day!");
        }
    }
}
