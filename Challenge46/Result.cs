internal class Result
{
    internal static string AngryProfessor(int k, List<int> a)
    {
        var inComingTotal = 0;
        foreach (int i in a)
        {
            if (i <= 0)
            {
                inComingTotal++;
            }
            if (inComingTotal == k)
            {
                return "NO";
            }
        }
        return "YES";

    }
}