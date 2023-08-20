using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge29
{
    internal class Result
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start(); 
                List<int> firstArray = new List<int>();
                int result = 0;
                for (int i = 1; i <= b.Min(); i++)
                {
                    bool isAddA = true;
                    foreach (var item in a)
                    {
                        if (i % item != 0)
                        {
                            isAddA = false;
                            break;
                        }
                    }
                    if (isAddA)
                    {
                        firstArray.Add(i);
                    }
                }
                foreach (var firstItem in firstArray)
                {
                    bool isAddB = true;
                    foreach (var item in b)
                    {
                        if (item % firstItem != 0)
                        {
                            isAddB = false;
                            break;
                        }
                    }
                    if (isAddB)
                    {
                        result++;
                    }
                }
            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.Elapsed;
            Console.WriteLine($"Geçen Süre: {elapsedTime}");
            
            return result;
        }

        public static int GetTotalY(List<int> a, List<int> b)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
                int result = 0;
                for (int i = 1; i <= b.Min(); i++)
                {
                    bool isFactorB = true;
                    foreach (var item in b)
                    {
                        if (item % i != 0)
                        {
                            isFactorB = false;
                            break;
                        }
                    }
                    if (isFactorB)
                    {
                        bool isFactorA = true;
                        foreach (var item in a)
                        {
                            if (i % item != 0)
                            {
                                isFactorA = false;
                                break;
                            }
                        }
                        if (isFactorA)
                        {
                            result++;
                        }
                    }
                }
            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.Elapsed;
            Console.WriteLine($"Geçen Süre: {elapsedTime}");
            return result;
        }
    }
}
