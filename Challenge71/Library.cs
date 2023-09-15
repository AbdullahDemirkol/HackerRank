internal class Library
{
    internal static int CheckDate(int d1, int d2, int m1, int m2, int y1, int y2)
    {
        if (y2 < y1)
        {
            return 10000;
        }
        else if (y1<y2)
        {
            return 0;
        }
        else 
        {
            if (m2 < m1)
            {
                return (m1 - m2) * 500;
            }
            else if (m1<m2)
            {
                return 0;
            }
            else
            {
                if (d2 < d1)
                {
                    return (d1 - d2) * 15;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}