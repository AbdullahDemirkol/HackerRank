internal class Result
{
    internal static int PageCount(int n, int p)
    {
        if (n % 2 == 0)
        {
            n++;
        }
        if (p % 2 == 0)
        {
            p++;
        }
        var frontDistance = (p - 1) / 2;
        var behindDistance = (n - p) / 2;
        if (frontDistance >= behindDistance)
        {
            return behindDistance;
        }
        else
        {
            return frontDistance;
        }
    }
}