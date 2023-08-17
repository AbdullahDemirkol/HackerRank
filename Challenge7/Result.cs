using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge7
{
    internal class Result
    {
        public static void StairCase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string spaces = new string(' ', n - (i + 1));
                string hashMarks = new string('#', i + 1);
                Console.WriteLine(spaces + hashMarks);
            }
        }
    }
}
