﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum = {numbers.Sum()}\nMin = {numbers.Min()}\nMax = {numbers.Max()}\nFirst = {numbers.First()}\nLast = {numbers.Last()}\nAverage = {numbers.Average()}");

        }
    }
}
