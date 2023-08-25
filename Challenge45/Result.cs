internal class Result
{
    internal static int UtopianTree(int n)
    {
        var caseJob = "secondJob";
        var result = 1;
        for (int i = 0; i < n; i++)
        {
            switch (caseJob)
            {
                case "firstJob":
                    result += 1;
                    caseJob = "secondJob";
                    break;
                case "secondJob":
                    result *= 2;
                    caseJob = "firstJob";
                    break;
            }
        }
        return result;
    }
}