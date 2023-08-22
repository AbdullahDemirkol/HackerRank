internal class Result
{
    internal static List<int> BreakingRecords(List<int> scores)
    {
        List<int> result = new List<int>();
        var minChangeCount = 0;
        var maxChangeCount = 0;
        var maxValue = scores[0];
        var minValue = scores[0];
        foreach (var score in scores)
        {
            if (score<minValue)
            {
                minValue = score;
                minChangeCount++;
            }
            else if (score>maxValue)
            {
                maxValue = score;
                maxChangeCount++;
            }
        }
        result.Add(maxChangeCount);
        result.Add(minChangeCount);
        return result;
    }
}