using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge74
{
    internal class Result
    {
        internal static void DecentNumber(int n)
        {
            var result = string.Empty;
            if (n < 3 || n == 4 || n == 7)
            {
                Console.WriteLine("-1");
                return;
            }

            while (n % 3 != 0)
            {
                result += "33333";
                n -= 5;
            }

            while (n > 0)
            {
                result = "555" + result;
                n -= 3;
            }

            Console.WriteLine(result);
        }
    }
}
