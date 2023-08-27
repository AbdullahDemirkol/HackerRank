using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge54
{
    internal class Result
    {
        internal static void ExtraLongFactorials(int n)
        {
            var result= "1";
            for (int i = 2; i <= n; i++)
            {
                result = Multiply(i, result);
            }

            Console.WriteLine(result);
        }

        private static string Multiply(int num1, string num2)
        {
            var result = "";
            int carry = 0;
            for (int i = num2.Length-1;i>=0;i--)
            {
                var temp= Convert.ToInt16(num2[i].ToString()) * num1;
                temp += carry;
                var unitsPlace = temp % 10;
                result = unitsPlace + result;
                
                carry = temp / 10;
            }
            if (carry != 0)
            {
                result = carry + result;
            }
            return result;
        }
    }
}
