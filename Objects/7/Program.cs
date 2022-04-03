using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            string[] Events =
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] Author = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] Cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int ind1 = rnd.Next(0, Phrases.Length);
                int ind2 = rnd.Next(0, Events.Length);
                int ind3 = rnd.Next(0, Author.Length);
                int ind4 = rnd.Next(0, Cities.Length);

                Console.WriteLine($"{Phrases[ind1]} {Events[ind2]} {Author[ind3]} – {Cities[ind4]}");

            }

        }
    }
}
