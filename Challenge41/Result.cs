using System.Collections.Generic;

internal class Result
{
    internal static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
    {
        List<int> results = new List<int>();

        var scores = ranked.ToHashSet().ToArray();
        int i = scores.Length - 1;

        for (int j = 0; j < player.Count; j++)
        {
            bool rankFound = false;
            while (!rankFound && i >= 0)
            {
                if (player[j] < scores[i])
                {
                    results.Add(i + 2);
                    rankFound = true;
                }
                else if (player[j] == scores[i])
                {
                    results.Add(i + 1);
                    rankFound = true;
                }
                else
                {
                    i--;
                }
            }

            if (!rankFound)
            {
                results.Add(1);
            }
        }

        return results;

    }
}