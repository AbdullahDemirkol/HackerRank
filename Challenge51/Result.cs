internal class Result
{
    internal static List<int> PermutationEquation(List<int> p)
    {
        var results= new List<int>();
        for (int i = 0; i < p.Count(); i++)
        {
            var index = p.FindIndex(x => x == i+1)+1;
            var result=p.FindIndex(x => x == index)+1;
            results.Add(result);
        }
        return results;
    }
}