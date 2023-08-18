using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge21
{
    internal class Result
    {
        public static void PrintArray<T>(T[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
