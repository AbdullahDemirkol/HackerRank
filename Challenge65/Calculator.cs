internal class Calculator : AdvancedArithmetic
{
    public int DivisorSum(int n)
    {
        var sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}