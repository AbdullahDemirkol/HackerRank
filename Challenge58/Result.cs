internal class Result
{
    internal static int NonDivisibleSubset(int k, List<int> s)
    {

        List<Tuple<int, int>> dictionary = new List<Tuple<int, int>>();

        for (int i = 0; i < s.Count; i++)
        {
            for (int j = 0; j < s.Count; j++)
            {
                if (i != j)
                {
                    var firstResult = (s[i] + s[j]) % k;
                    var secondResult = (s[i] % k) + (s[j] % k);
                    if (firstResult == secondResult)
                    {
                        var getDictionaryValue = dictionary.Where(p => p.Item2 == s[i] && p.Item1 == s[j]).Count();
                        if (getDictionaryValue < 1)
                        {
                            dictionary.Add(Tuple.Create(s[i], s[j]));
                        }
                    }
                }
            }
        }
        HashSet<int> result = new HashSet<int>();
        foreach (var item in dictionary)
        {
            result.Add(item.Item1);
            result.Add(item.Item2);
        }


        return result.Count();
    }
}