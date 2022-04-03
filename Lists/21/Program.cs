using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bomb[0])
                {
                    if (i >= bomb[1])
                    {
                        if (i < list.Count - bomb[1])
                        {
                            list.RemoveRange(i - bomb[1], 2*bomb[1] + 1);
                            i=-1;

                        }
                        else
                        {
                            list.RemoveRange(i - bomb[1],list.Count - i +bomb[1]);
                            i=-1;


                        }

                    }
                    else
                    {
                        if (i < list.Count - bomb[1])
                        {
                            list.RemoveRange(0, i + bomb[1]+1);
                            i=-1;

                        }
                        else
                        {
                            Console.WriteLine("0");
                            return;
                        }
                    }
                } 
                 
            }
            
            int sum = 0;
            for (int d = 0; d < list.Count; d++)
            {
                sum += list[d];
            }
            Console.WriteLine(sum);
        }
    }
}
