using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge73
{
    internal class Result
    {
        public static int BitwiseAnd(int N, int K)
        {
            var max = int.MinValue;
            for (int i = 1; i < N; i++)
            {
                for (int j = i + 1; j <= N; j++)
                {
                    var cur = i & j;
                    if (cur <= K)
                    {
                        max = Math.Max(max, cur);
                    }
                }
            }
            return max;
        }
    }
}
