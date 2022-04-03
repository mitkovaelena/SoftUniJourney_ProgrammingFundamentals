using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            
           string words = Console.ReadLine();
            int ind1 = 0;
            int ind2 = 0;
            
            string temp;
            string nov;
            for (int i = 0; i < words.Length; i++)
            {
                ind1 = words.IndexOf("<upcase>",i);
                ind2 = words.IndexOf("</upcase>",i);
                if (ind1 != -1 && ind2 != -1)
                {
                    temp = words.Substring(ind1, ind2 - ind1 + 9);
                    nov = words.Substring(ind1 + 8, ind2 - ind1 - 8).ToUpper();
                    words = words.Replace(temp, nov);
                }
            }
            Console.WriteLine(words);

        }
    }
}
