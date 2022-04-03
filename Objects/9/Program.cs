using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double Average { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Student> uchenici = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                double[] grades = new double[input.Length-1];
                double average = 0;
                for (int j = 1; j < input.Length; j++)
                {
                    grades[j - 1] = double.Parse(input[j]);
                    average += double.Parse(input[j]);
                }
                average /= grades.Length;
                Student add = new Student() { Name = name, Grades = grades, Average = average};
                uchenici.Add(add);
            }
            foreach (var student in uchenici.OrderBy(x=>x.Name).ThenBy(x=> - x.Average))
            {
               if(student.Average >= 5)
                   Console.WriteLine($"{student.Name} -> {student.Average:F2}"); 
            }
        }
    }
}
