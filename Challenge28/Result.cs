using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge28
{
    internal class Result
    {

        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 < x2)
            {
                if (v1 <= v2)
                {
                    return "NO";
                }
                else
                {
                    while (true)
                    {
                        x1 += v1;
                        x2 += v2;
                        if (x1==x2)
                        {
                            return "YES";
                        }
                        else if (x1 > x2)
                        {
                            return "NO";
                        }
                    }
                }
            }
            else if (x1 > x2)
            {
                if (v1 >= v2)
                {
                    return "NO";
                }
                while (true)
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1==x2)
                    {
                        return "YES";
                    }
                    else if (x1 < x2)
                    {
                        return "NO";
                    }
                }
            }
            else
            {
                if (v1==v2)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
        }
    }
}
