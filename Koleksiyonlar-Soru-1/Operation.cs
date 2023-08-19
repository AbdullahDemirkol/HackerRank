using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    internal class Operation
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        internal static void Print(List<int> numberList, string description)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(description);
            numberList.OrderBy(p => p).ToList().ForEach(number => Console.WriteLine(number));
        }
    }
}
