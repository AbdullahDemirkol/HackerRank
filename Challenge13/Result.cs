using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Challenge13
{
    internal class Result
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            int alicePoint=0, bobPoint=0;
            foreach (var item in a)
            {
                if (item>100 || item<1)
                {
                    return result;
                }
            }
            foreach (var item in b)
            {
                if (item > 100 || item < 1)
                {
                    return result;
                }
            }
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                {
                    alicePoint++;
                }
                else if (a[i] < b[i])
                {
                    bobPoint++;
                }
            }

            result.Add(alicePoint);
            result.Add(bobPoint);
            return result;
        }
    }
}
