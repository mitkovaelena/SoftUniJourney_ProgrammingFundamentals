using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Razstoqnie
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public double dist { get; set; }
       
    }
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Point> tochki = new List<Point>();
            Razstoqnie temp = new Razstoqnie();
            Razstoqnie min = new Razstoqnie();
            for (int i = 0; i < n; i++)
            {
                int[] one = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Point add = new Point() {X = one[0], Y = one[1]};
                tochki.Add(add);
            }
            min = Distance(tochki[0], tochki[1]);
            for (int i = 0; i < tochki.Count; i++)
            {
                for (int j = i+1; j < tochki.Count; j++)
                {
                    temp = Distance(tochki[i], tochki[j]);
                    if (temp.dist < min.dist)
                    {
                        min = temp;
                    }
                }
            }
            
            Console.WriteLine("{0:F3}", min.dist);
            Console.WriteLine("({0}, {1})", min.X1, min.Y1);
            Console.WriteLine("({0}, {1})", min.X2, min.Y2);

        }

        private static Razstoqnie Distance(Point a, Point b)
        {
            Razstoqnie raz = new Razstoqnie() {X1 = a.X, Y1 = a.Y, X2=b.X, Y2 = b.Y};
            
            double dis = Math.Sqrt((a.X - b.X)*(a.X - b.X) + (a.Y - b.Y)*(a.Y - b.Y));
            raz.dist = dis;
            return raz;
        }
    }
}
