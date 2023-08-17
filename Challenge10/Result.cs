using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10
{
    internal class Result
    {
        public static int SimpleArraySum(List<int> arr)
        {
            foreach (var item in arr)
            {
                if (item<=0 || item >1000)
                {
                    return 0;
                }
            }
            return arr.Sum();
        }
    }
}
