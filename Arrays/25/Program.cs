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
            string[] str1 = Console.ReadLine().Split(' ');
            string[] str2 = Console.ReadLine().Split(' ');
            bool ok = false;
            for (int i = 0; i < Math.Min(str1.Length,str2.Length); i++)
            {
                
                if (string.Compare(str1[i], str2[i]) != 0)
                {
                    if (string.Compare(str1[i], str2[i]) > 0)
                        ok = true;
                    break;
                }                    
            }
            
            if ( ok == false && str1.Length <= str2.Length )
            {
                Console.WriteLine(string.Join("", str1));
                Console.WriteLine(string.Join("", str2));
            }
            else 

            {
                Console.WriteLine(string.Join("", str2));
                Console.WriteLine(string.Join("", str1));
            }

        }
    }
}
