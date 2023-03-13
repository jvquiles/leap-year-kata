namespace leap_year_domain;

public static class LeapYear
{
    public static bool IsLeap(int year)
    {
        if (year % 100 == 0)
        {
            return false;
        }
        
        if (year % 4 == 0)
        {
            return true;
        }

        return false;
    }
}