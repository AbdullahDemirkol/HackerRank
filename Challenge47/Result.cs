internal class Result
{
    internal static int BeautifulDays(int i, int j, int k)
    {
        var result = 0;
        for (int index = i; index <= j; index++)
        {
            int reverse = 0;
            var tempIndex = index;
            while (tempIndex > 0)
            {
                int kalan = tempIndex % 10;
                reverse = reverse * 10 + kalan;
                tempIndex = tempIndex / 10;
            }
            var divisionResult =Convert.ToDouble(Math.Abs(index - reverse))/k;
            if (divisionResult % 1 == 0)
            {
                result++;
            }
        }
        return result;
    }
}