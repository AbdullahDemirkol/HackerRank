
internal class Result
{
    internal static int FormingMagicSquare(List<List<int>> s)
    {
        List<List<List<int>>> collections = new List<List<List<int>>>()
            {
                new List<List<int>>() {new List<int>() {8, 1, 6}, new List<int>() {3, 5, 7}, new List<int>() {4, 9, 2}},
                new List<List<int>>() {new List<int>() {6, 1, 8}, new List<int>() {7, 5, 3}, new List<int>() {2, 9, 4}},
                new List<List<int>>() {new List<int>() {4, 9, 2}, new List<int>() {3, 5, 7}, new List<int>() {8, 1, 6}},
                new List<List<int>>() {new List<int>() {2, 9, 4}, new List<int>() {7, 5, 3}, new List<int>() {6, 1, 8}},
                new List<List<int>>() {new List<int>() {8, 3, 4}, new List<int>() {1, 5, 9}, new List<int>() {6, 7, 2}},
                new List<List<int>>() {new List<int>() {4, 3, 8}, new List<int>() {9, 5, 1}, new List<int>() {2, 7, 6}},
                new List<List<int>>() {new List<int>() {6, 7, 2}, new List<int>() {1, 5, 9}, new List<int>() {8, 3, 4}},
                new List<List<int>>() {new List<int>() {2, 7, 6}, new List<int>() {9, 5, 1}, new List<int>() {4, 3, 8}},
            };
        List<int> totalResult = new List<int>();
        foreach (var collection in collections)
        {
            int temp = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp += Math.Abs(s[i][j] - collection[i][j]);
                }
            }
            totalResult.Add(temp);
        }

        return totalResult.Min();
    }
}