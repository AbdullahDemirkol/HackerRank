using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge34
{
    internal class Result
    {
        public static void BonAppetit(List<int> bill, int k, int b)
        {
            bill.Remove(bill[k]);
            var halfSum=bill.Sum()/2;
            if (halfSum == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b-halfSum);
            }
        }
    }
}
