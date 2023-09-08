using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Avarage
    {
        internal void AvarageOfFibonacci(int[] fibonacciResults)
        {
            var result = fibonacciResults.Average();
            Console.WriteLine(result);
        }
    }
}
