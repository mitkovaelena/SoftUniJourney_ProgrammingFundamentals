using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charSeparators = new char[] { ' ', ',', '.', '?', '!' };
            string[] words = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string reverse;
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                char[] arr = word.ToCharArray();
                Array.Reverse(arr);
                reverse = string.Join("", arr);
                if (reverse == word && !result.Contains(word))
                {
                 result.Add(word);   
                }
            }
            result.Sort();
            Console.WriteLine(  string.Join(", ", result));
        }
    }
}
