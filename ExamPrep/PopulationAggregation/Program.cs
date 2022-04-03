using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command;
            string country ;
            string city;
            long population;
            Dictionary<string, long> cityPop = new Dictionary<string, long>();
            SortedDictionary<string, long> CountryCount = new SortedDictionary<string, long>();
            do
            {
                command = Console.ReadLine().Split('\\').ToArray();
                if (command[0] == "stop")
                    break;

                population = long.Parse(command[2]);
                if (char.IsUpper(command[0][0]))
                {
                    country = command[0];
                    city = command[1];
                }
                else
                {
                   country = command[1];
                    city = command[0];
                }
                country = Decode(country);
                city = Decode(city);

                cityPop[city] = population;

                if(CountryCount.ContainsKey(country))
                CountryCount[country] +=1;
                else
                    CountryCount[country] = 1;

            } while (true);

            foreach (var pair in CountryCount)
            {
                Console.WriteLine( "{0} -> {1}", pair.Key, pair.Value);
            }


            int count = 0;
            foreach (var pair in cityPop.OrderByDescending(x => x.Value))
            {
                if (count >= 3)
                    break;
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                count++;
            }

        }

        private static string Decode(string word)
        {

            char[] charSeparators = new char[] {'@', '#', '$', '&', '0','1','2','3','4','5','6','7','8','9'};
            string[] arr = word.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            word = string.Join("", arr);
            
            return word;
        }
    }
}
