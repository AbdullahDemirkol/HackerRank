using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Challenge25
{
    internal class Result
    {

        public static void MiniMaxSum(List<int> arr)
        {
            long sum = 0;
            foreach (int value in arr)
            {
                sum += value;
            }
            var maxResult = sum - arr.Min();
            var minResult = sum - arr.Max();
            Console.WriteLine(minResult+" "+maxResult);
        }
    }
}
