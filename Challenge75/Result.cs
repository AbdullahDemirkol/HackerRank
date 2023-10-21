using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Challenge75
{
    internal class Result
    {
        internal static long HalloweenParty(int k)
        {
            decimal halfTheNumber = (decimal)k / 2;
            int horizontalCount = (int)halfTheNumber;
            var verticalCount = (int)(halfTheNumber+(halfTheNumber-horizontalCount));
            
            long result = 0;
            int count = 0;

            while (verticalCount != 0)
            {
                if ((verticalCount & 1) == 1)
                {
                    result += (long)horizontalCount << count;
                }
                verticalCount >>= 1;
                count++;
            }

            return result;
        }
    }
}
