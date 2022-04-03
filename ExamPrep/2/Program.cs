using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < n; i++)
            {

                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string date = Console.ReadLine();
                DateTime orderDate = DateTime.ParseExact(date, "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal price = ((daysInMonth*capsulesCount)*pricePerCapsule);
                total += price;
                Console.WriteLine("The price for the coffee is: ${0:F2}", price);
            }
            Console.WriteLine("Total: ${0:F2}", total);
        }
    }
}
