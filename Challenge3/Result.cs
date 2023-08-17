using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Result
    {
        public static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = (meal_cost * tip_percent) / 100;
            double tax = (tax_percent * meal_cost) / 100;
            double total_cost = meal_cost + tip + tax;
            Console.WriteLine(Math.Round(total_cost));
        }
    }
}
