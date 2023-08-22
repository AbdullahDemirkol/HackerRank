internal class Result
{
    internal static int DivisibleSumPairs(int n, int k, List<int> ar)
    {
        int result = 0;
        for (int i = 0; i < n; i++)
        { 
            for (int j = 0; j < n; j++)
            {
                var sum = 0;
                if (i!=j)
                {
                    sum = ar[i] + ar[j];
                    if (sum % k == 0 && sum != 0)
                    {
                        result++;
                    }
                }
            }
        }
        return result/2;
    }
}