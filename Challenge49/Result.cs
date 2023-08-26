internal class Result
{
    internal static int SaveThePrisoner(int n, int m, int s)
    {
        var modResult = m % n;
        var result = 0;
        if (modResult == 0)
        {
            if (s - 1 == 0)
            {
                return n;
            }
            else
            {
                return s - 1;
            }
        }
        else
        {
            result += s + modResult - 1;
            if (result > n)
            {
                result -= n;
            }
            return result;
        }

    }
}