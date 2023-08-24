internal class Result
{
    internal static int PickingNumbers(List<int> a)
    {
        int result = 0;
        Dictionary<int,int> numberOfRepeatsInList=new Dictionary<int,int>();
        var nonRepeatableList = a.ToHashSet().ToArray();
        foreach(int nonRepeatableElement in nonRepeatableList) 
        {
            numberOfRepeatsInList.Add(nonRepeatableElement, a.Where(p=>p==nonRepeatableElement).Count());
        }
        for (int i = 0; i < 101; i++)
        {
            var max = 0;
            if (numberOfRepeatsInList.TryGetValue(i, out int value1))
            {
                if (numberOfRepeatsInList.TryGetValue(i+1, out int value2))
                {
                    max=value1+value2;
                }
                else
                {
                    max = value1;
                }
            }
            else
            {
                if (numberOfRepeatsInList.TryGetValue(i + 1, out int value2))
                {
                    max = value2;
                }
            }
            result = Math.Max(result, max);
        }
        return result;
    }
}