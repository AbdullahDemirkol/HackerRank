internal class Result
{
    internal static List<int> CircularArrayRotation(List<int> a, int k, List<int> queries)
    {
        k = k % a.Count();
        int size=a.Count()-1;
        Reverse(a, 0, size);
        Reverse(a, 0, k - 1);
        Reverse(a, k, size);
        var result= new List<int>();
        for (int i = 0; i < queries.Count(); i++)
        {
            result.Add(a[queries[i]]);
        }
        return result;
    }
    static void Reverse(List<int> a,int m, int n)
    {
        while (m<n)
        {
            int temp = a[m];
            a[m] = a[n];
            a[n] = temp;
            m++;
            n--;
        }
    }
}