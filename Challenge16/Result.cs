using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge16
{
    internal class Result
    {

        public static int Factorial(int n)
        {
            if (n <= 1) 
                return 1;
            
            return n*Factorial(n-1);
        }
    }
}
