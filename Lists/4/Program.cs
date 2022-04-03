using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        enum WordType { Upper, Lower, Mixed };
        static void Main(string[] args)
        {
 
            char[] charSeparators = new char[] { ' ',':', ',', ';', ':', '.', '!','(', ')',
                '"', '\'', '\\', '/', '[', ']' };    
           

            List<string> words = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lower = new List<string>();
            List<string> mixed = new List<string>();
            List<string> upper = new List<string>();
            foreach (string word in words)
            {
                WordType w = GetWordType(word);
                if (w == WordType.Upper)
                    upper.Add(word);
                else if (w == WordType.Lower)
                    lower.Add(word);
                else
                    mixed.Add(word);
            }
            Console.WriteLine("Lower-case: {0}", string.Join(" ", lower));
            Console.WriteLine("Mixed-case: {0}", string.Join(" ", mixed));
            Console.WriteLine("Upper-case: {0}", string.Join(" ", upper));
        }

        private static WordType GetWordType(string word)
        {
            int low = 0, up = 0;
            foreach (char letter in word)
            {
                if (char.IsUpper(letter))
                    up++;
                else if (char.IsLower(letter))
                    low++;
            }
            if (up == word.Length)
                return WordType.Upper;
            else if (low == word.Length)
                return WordType.Lower;
            else
                return WordType.Mixed;


        }
    }
}
