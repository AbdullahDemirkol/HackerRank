using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge27
{
    internal class Result
    {

        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var betweenApple = 0;
            var betweenOrange = 0;
            foreach (var apple in apples)
            {
                var applePosition = a + apple;
                if (s <= applePosition && t >= applePosition)
                {
                    betweenApple++;
                }
            }
            foreach (var orange in oranges)
            {
                var orangePosition = b + orange;
                if (s <= orangePosition && t >= orangePosition)
                {
                    betweenOrange++;
                }
            }
            Console.WriteLine(betweenApple+"\n"+betweenOrange);
        }
    }
}
