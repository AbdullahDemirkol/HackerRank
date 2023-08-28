internal class Result
{
    internal static int LibraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        if (y2 > y1)
        {
            return 0;
        }
        else if (y2 < y1)
        {
            return 10000;
        }
        else if (m2 > m1)
        {
            return 0;
        }
        else if (m2 < m1)
        {
            return ((m1 - m2) * 500);
        }
        else if (d2 > d1)
        {
            return 0;
        }
        else if (d2 < d1)
        {
            return (d1 - d2) * 15;
        }
        return 0;

    }
}