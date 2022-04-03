using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Circle
    {
        public Point Center { get; set; }
        public int radius { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] one = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point f = new Point() {X = one[0], Y = one[1]};
            Circle first = new Circle() {Center = f, radius = one[2]};
            int[] two = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point s = new Point() { X = two[0], Y = two[1] };
            Circle second = new Circle() { Center = s, radius = two[2] };

            if(Intersect(first, second) == true)
            {
                Console.WriteLine("Yes");
            }
        else
            {
                Console.WriteLine(  "No");
            }
        }

        private static bool Intersect(Circle first, Circle second)
        {
            double dist = Math.Sqrt((first.Center.X - second.Center.X) * (first.Center.X - second.Center.X) + (first.Center.Y - second.Center.Y) * (first.Center.Y - second.Center.Y));
            if (dist <= first.radius + second.radius)
                return true;
            else return false;

        }
    }
}
