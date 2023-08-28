internal class Result
{
    internal static int Squares(int a, int b)
    {
        var result = 0;
        for (var i = 0; i < Math.Pow(10,9); i++)
        {
            var square = i * i;
            if (square >= a && square <=  b) result++;
            else if (square > b) break;
        }
        return result;
    }
}