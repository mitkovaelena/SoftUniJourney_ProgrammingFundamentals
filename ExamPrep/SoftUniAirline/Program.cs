using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            int flights = int.Parse(Console.ReadLine());
            decimal Overalprofit = 0;

            for (int i = 0; i < flights; i++)
            {
                int adPass = int.Parse(Console.ReadLine());
                decimal adPrice = decimal.Parse(Console.ReadLine());
                int youPass = int.Parse(Console.ReadLine());
                decimal youPrice = decimal.Parse(Console.ReadLine());
                double fuelPrice = double.Parse(Console.ReadLine());
                double fuelCons = double.Parse(Console.ReadLine());
                int hours = int.Parse(Console.ReadLine());

                decimal income = (adPass*adPrice) + (youPass*youPrice);
                decimal expences = (decimal)(hours*fuelCons*fuelPrice);

                Overalprofit += (income - expences);

                if (expences <= income)
                    Console.WriteLine("You are ahead with {0:F3}$.",income-expences);
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", income - expences);
                }
            }
            Console.WriteLine("Overall profit -> {0:F3}$.", Overalprofit);
            Console.WriteLine("Average profit -> {0:F3}$.", Overalprofit/flights);


        }
    }
}
