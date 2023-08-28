internal class Result
{
    internal static string AppendAndDelete(string? s, string? t, int k)
    {
        if(k>s.Length+t.Length)
        {
            return "Yes";
        }
        int same = 0;
        for (int i = 0; i < Math.Min(s.Length,t.Length); i++)
        {
            same = i;
            if (s[i] != t[i])
            {
                break;
            }
        }
        k -= (s.Length - same);
        k -= (t.Length - same);
        return (k >= 0 && k%2==0)? "Yes":"No";
    }
}
