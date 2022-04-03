using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] text =Console.ReadLine().Split(' ').ToArray();
            string censored = email;
            int ind = censored.IndexOf('@');
            censored = censored.Remove(0, ind);
            censored = censored.Insert(0, new string('*', ind));
            for (int i = 0; i < text.Length; i++)
            {
            if (string.Compare(email, text[i]) == 0)
                {
                    text[i] = censored;
                }
            }
            Console.WriteLine(  string.Join(" ", text));
        }
    }
}
