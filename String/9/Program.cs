using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] charSeparators = new char[] { ' ','.',',', ':', ';', ')','(','[', ']','"', '\'', '\\', '/','!','?'};
            string[] text = Console.ReadLine().ToLower().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            List<string> list = new List<string>();
            foreach (string word in text)
            {
                if(word.Length < 5 )
                    list.Add(word);
            }
            
            list.Sort();
            Console.WriteLine(string.Join(", ",list.Distinct())); 
        }
    }
}
