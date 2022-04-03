using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] delimiters = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, string> NameCoffee = new Dictionary<string, string>();
            Dictionary<string, int> CoffeeCount = new Dictionary<string, int>();
            string[] command1;
            string[] command2;
            string[] command3;
            do
            {
                string comm = Console.ReadLine();
                if (comm == "end of info") break;

                if ((comm.IndexOf(delimiters[0])) > 0)
                {

                    comm = comm.Replace(delimiters[0], "@");
                    command1 = comm.Split('@').ToArray();
                    NameCoffee[command1[0]] = command1[1];
                    CoffeeCount[command1[1]] = 0;
                }

                else if ((comm.IndexOf(delimiters[1])) > 0)
                {

                    comm = Console.ReadLine();
                    comm = comm.Replace(delimiters[1], "@");
                    command2 = comm.Split('@').ToArray();
                    if (CoffeeCount.ContainsKey(command2[1]))
                        CoffeeCount[command2[1]] += 1;
                    else
                    {
                        CoffeeCount[command2[1]] = 1;
                    }
                }

            } while (true);

            while (true)
            {
                string comm = Console.ReadLine();
                if (comm == "end of week") break;

                command3 = comm.Split(' ').ToArray();
                int kafeta = int.Parse(command3[1]);

                CoffeeCount[NameCoffee[command3[0]]] -= kafeta;

            }

            foreach (var pair in CoffeeCount.OrderByDescending(x => x.Value))
            {
                if (pair.Value <= 0)
                {
                    Console.WriteLine("Out of {0}", pair.Key);
                }

            }

            Console.WriteLine("Coffee Left:");
            foreach (var pair in CoffeeCount.OrderByDescending(x => x.Value))
            {
                if (pair.Value > 0)
                {
                    Console.WriteLine("{0} {1}", pair.Key, pair.Value);
                }

            }

            NameCoffee.OrderByDescending(x => x.Key);
            Console.WriteLine("For:");
            foreach (var pair in NameCoffee.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (CoffeeCount[pair.Value] > 0)
                {
                    Console.WriteLine("{0} {1}", pair.Key, pair.Value);
                }

                Console.WriteLine("{0} {1}", pair.Key, pair.Value);
            }

        }
    }
}
