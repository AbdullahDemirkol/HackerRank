using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge19
{
    internal class Calculator
    {
        public static int Power(int n,int p)
        {
            if(n>=0 && p >= 0)
            {
                return Convert.ToInt32(Math.Pow(n,p));
            }
            throw new Exception("n and p should be non-negative");
        }
    }
}
