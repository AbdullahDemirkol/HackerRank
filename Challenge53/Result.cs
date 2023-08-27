internal class Result
{
    internal static int FindDigits(int n)
    {
        int result = 0;
        int number = n;
        
        
        while (n > 0)
        {
            var digit = n % 10;
            if (digit != 0 && number % digit == 0) 
            {
                result++;
            }
            n /= 10;
        }
        return result;
    }
}