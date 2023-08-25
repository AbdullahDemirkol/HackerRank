internal class Result
{
    internal static int HurdleRace(int k, List<int> height)
    {

        int maxValue = height.Max();
        var result = maxValue - k; 
        if (result<=0) { return 0; }
        return result;
    }
}