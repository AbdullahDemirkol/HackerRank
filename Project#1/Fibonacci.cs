using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Fibonacci
    {
        internal int[] FibonacciToCreate(int param)
        {
            var fibonacciResults = new int[param];
            fibonacciResults[0] = 1;
            fibonacciResults[1] = 1;
            for (int i = 2; i < param; i++)
            {
                var fibonacciResult = fibonacciResults[i - 2] + fibonacciResults[i - 1];
                fibonacciResults[i] = fibonacciResult;
            }
            return fibonacciResults;
        }
    }
}
