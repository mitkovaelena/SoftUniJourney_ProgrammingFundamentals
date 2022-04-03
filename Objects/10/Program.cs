using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>();
            Dictionary<string,DateTime> dict = new Dictionary<string, DateTime>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Book add = new Book();
                add.Title = input[0];
                add.Author = input[1];
                add.Publisher = input[2];
                add.ReleaseDate = DateTime.ParseExact(input[3], "d.M.yyyy", CultureInfo.InvariantCulture);
                add.ISBN = input[4];
                add.price = double.Parse(input[5]);
                library.Add(add);
                
                
                    dict[input[0]] = DateTime.ParseExact(input[3], "d.M.yyyy", CultureInfo.InvariantCulture);

            }
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            foreach (var author in dict.OrderBy(x =>x.Value).ThenBy(x => x.Key))
            {
                if(author.Value > date)
                Console.WriteLine($"{author.Key} -> {author.Value:dd.MM.yyyy}");
            }
        }
    }
}
