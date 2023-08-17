using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8
{
    internal class Result
    {
        public static void PlusMinus(List<int> array)
        {
            foreach (var item in array)
            {
                if (item > 100 || item <-100)
                {
                    return;
                }
            }
            var positiveNumbers = array.Where(num => num > 0).ToList();
            var negativeNumbers = array.Where(num => num < 0);
            var zeroNumbers = array.Where(num => num == 0);


            Console.WriteLine(Convert.ToDecimal(positiveNumbers.Count()) / array.Count());
            Console.WriteLine(Convert.ToDecimal(negativeNumbers.Count()) / array.Count());
            Console.WriteLine(Convert.ToDecimal(zeroNumbers.Count()) / array.Count());
        }
    }
}
