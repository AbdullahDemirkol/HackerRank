using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge9
{
    internal class Result
    {
        public static int BirthdayCakeCandles(List<int> candles)
        {
            foreach (int candle in candles)
            {
                if (candle<=0 || candle>Math.Pow(10, 7))
                {
                    return 0;
                }
            }
            var maxTallesCandle = candles.Max();
            int maxTallesCandleCount=candles.Where(p => p == maxTallesCandle).Count();
            return maxTallesCandleCount;
        }
    }
}
