using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge15
{
    internal class Result
    {
        public static int MigratoryBirds(List<int> arr)
        {
            HashSet<int> frequentValues = new HashSet<int>();
            foreach (var item in arr)
            {
                frequentValues.Add(item);
            }
            frequentValues.ToList();

            IDictionary<int, int> frequentValuesWithCount = new Dictionary<int, int>();
            foreach (var item in frequentValues)
            {
                frequentValuesWithCount.Add(item, arr.Where(p => p == item).Count());
            }
            var frequentMaxValue = frequentValuesWithCount.Values.Max();
            var frequentMaxValueHasKeys = frequentValuesWithCount.Where(p => p.Value== frequentMaxValue).ToList();
            var result = frequentMaxValueHasKeys.OrderBy(p=>p.Key).First();

            return result.Key;
        }
    }
}
