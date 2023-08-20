using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge24
{
    internal class Result
    {

        public static int DiagonalDifference(List<List<int>> arr)
        {
            int firstResult=0, secondResult=0;
            var rowCount = arr[0].Count();
            for (int i = 0; i < arr.Count(); i++)
            {
                for (int j = 0; j < arr[i].Count(); j++)
                {
                    if (i==j)
                    {
                        firstResult += arr[i][j];
                    }
                }
                if (rowCount >= 0)
                {
                    rowCount--;
                    secondResult += arr[i][rowCount];
                }
                Console.WriteLine(firstResult + " " + secondResult);
            }
            var result = firstResult - secondResult;
            if (result < 0)
            {
                result*=-1;
            }
            return result;

        }
    }
}
