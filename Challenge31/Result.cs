internal class Result
{
    internal static int Birthday(List<int> s, int d, int m)
    {
        var result = 0;
        int plus = 0;
        for (int j = 0; j < s.Count - m+1; j++)
        {
            var sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += s[i+plus];
            }
            if (sum == d)
            {
                result++;
            }
            plus++;
        }
        return result;
    }
}