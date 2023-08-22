internal class Result
{
    internal static int SockMerchant(int n, List<int> ar)
    {
        int result = 0;
        HashSet<int> set = new HashSet<int>();
        foreach (int i in ar)
        {
            set.Add(i);
        }
        foreach (int i in set)
        {
            var pairsCount=ar.Where(p=>p.Equals(i)).Count();
            result += pairsCount / 2;
        }
        return result;
    }
}