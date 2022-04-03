using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Point
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int width { get; set; }
        public int height { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] one = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] two = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point first = new Point() { X1 = one[0], Y1 = one[1], width = one[2], height = one[3]};
            Point sec = new Point() { X1 = two[0], Y1 = two[1], width = two[2], height = two[3] };
            if (sec.X1 > first.X1 || sec.Y1 < first.Y1 || sec.width < first.width || sec.height < first.height)
            {
                Console.WriteLine("Not inside");
                return;
            }
            if(sec.X1+sec.width < first.X1+first.width || sec.X1 - sec.height > first.X1 - first.height)
            {
                Console.WriteLine("Not inside");
                return;
            }
            Console.WriteLine(  "Inside");

        }
    }
}
