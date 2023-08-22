internal class Result
{
    internal static string DayOfProgrammer(int year)
    {
        if (year == 1918)
        {
            return "26.09." + year;
        }
        if (year % 400 == 0)
        {
            return "12.09." + year;
        }
        else if (year % 100 != 0)
        {
            if (year % 4 == 0)
            {
                return "12.09." + year;
            }
            return "13.09." + year;
        }
        if (year < 2000)
        {
            return "12.09." + year;
        }
        else
        {
            return "13.09." + year;
        }
    }
}