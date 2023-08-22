internal class Result
{
    internal static int CountingValleys(int steps, string? path)
    {
        var altitude = 0;
        var valley = 0;
        foreach (char character in path)
        {
            if (character == 'U')
            {
                if (altitude == -1)
                {
                    valley++;
                }
                altitude++;
            }
            else if (character == 'D')
            {

                altitude--;
            }
        }
        return valley;

    }
}