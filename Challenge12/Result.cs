using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge12
{
    internal class Result
    {
        public static long VeryBigSum(List<long> arr)
        {
            foreach (var item in arr)
            {
                if (item<0 || item> (Math.Pow(10, 10)))
                {
                    return 0;
                }
            }
            long sumArr = arr.Sum();
            return sumArr;
        }
    }
}
