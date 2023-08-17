using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class Result
    {
        public static List<int> CutTheSticks(List<int> arr)
        {
            List<int> result = new List<int>();

            while (arr.Count > 0)
            {
                result.Add(arr.Count());
                var minElement = arr.Min();
                for (int i = 0; i < arr.Count; i++)
                {
                    arr[i] = arr[i] - minElement;
                }
                foreach (var item in arr.ToList())
                {

                    if (item <= 0)
                    {
                        arr.Remove(item);
                    }
                }
            }
            return result;
        }
    }
}
