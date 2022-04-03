using System;
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
            string keyW = Console.ReadLine();
            SortedDictionary<string, int> goals = new SortedDictionary<string, int>();
            SortedDictionary<string, int> scores = new SortedDictionary<string, int>();

            while (true)
            {
                string word = Console.ReadLine();
                if (word == "final") break;

                int ind1 = word.IndexOf(keyW, 0);
                int ind2 = word.IndexOf(keyW, ind1+1);
                int ind3 = word.IndexOf(keyW, ind2+1);
                int ind4 = word.IndexOf(keyW, ind3+1);


                var arr1 = word.Substring(ind1 + keyW.Length, ind2 - ind1 - keyW.Length).ToArray();
                Array.Reverse(arr1);
                string otbor1 = string.Join("", arr1).ToUpper();
                var arr2 = word.Substring(ind3 + keyW.Length, ind4 - ind3 - keyW.Length).ToArray();
                Array.Reverse(arr2);
                string otbor2 = string.Join("", arr2).ToUpper();

                string[] wor = word.Substring(ind4, word.Length - ind4).Split(' ').ToArray();
                string[] words = wor[wor.Length - 1].Split(':').ToArray();

                if (goals.ContainsKey(otbor1))
                    goals[otbor1] += int.Parse(words[0]);
                else
                {
                    goals[otbor1] = int.Parse(words[0]);
                }

                if (goals.ContainsKey(otbor2))
                    goals[otbor2] += int.Parse(words[1]);
                else
                {
                    goals[otbor2] = int.Parse(words[1]);
                }

                if (int.Parse(words[0]) > int.Parse(words[1]))
                {
                    if (scores.ContainsKey(otbor1))
                        scores[otbor1] += 3;
                    else
                    {
                        scores[otbor1] = 3;
                    }
                    if (scores.ContainsKey(otbor2))
                        scores[otbor2] += 0;
                    else
                    {
                        scores[otbor2] = 0;
                    }
                }
                else if (int.Parse(words[0]) == int.Parse(words[1]))
                {
                    if (scores.ContainsKey(otbor1))
                        scores[otbor1] += 1;
                    else
                    {
                        scores[otbor1] = 1;
                    }
                    if (scores.ContainsKey(otbor2))
                        scores[otbor2] += 1;
                    else
                    {
                        scores[otbor2] = 1;
                    }
                }
                else
                {
                    if (scores.ContainsKey(otbor2))
                        scores[otbor2] += 3;
                    else
                    {
                        scores[otbor2] = 3;
                    }
                    if (scores.ContainsKey(otbor1))
                        scores[otbor1] += 0;
                    else
                    {
                        scores[otbor1] = 0;
                    }
                }

            }

            Console.WriteLine("League standings:");
            int place = 1;
            foreach (var pair in scores.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{place}. {pair.Key} {pair.Value}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var pair in goals.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine($"- {pair.Key} -> { pair.Value}");
            }
        }
    }
}
