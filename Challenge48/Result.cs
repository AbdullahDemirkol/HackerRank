internal class Result
{
    internal static int ViralAdvertising(int n)
    {
        var result = 0;
        int firstShared = 5;
        for (int i = 0; i < n; i++)
        {
            var likedCount=(firstShared / 2);
            result += likedCount;
            firstShared = likedCount * 3;
        }
        return result;
    }
}