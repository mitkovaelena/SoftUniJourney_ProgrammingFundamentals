using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double berries = double.Parse(Console.ReadLine());
            double price;
            int portions;

            if (guests%6 == 0)
                portions = guests/6;
            else
                portions = (guests / 6) +1;
            price = (2*bananas + 4*eggs + 0.2*berries)*portions;

            if(price <= cash)
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", price);
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", price-cash);
            }
        
        }
    }
}
