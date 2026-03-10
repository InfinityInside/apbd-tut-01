namespace Tutorial1;

public class StatisticsHelper
{
    static double CalculateAverage(int[] vals)
    {
        if (vals.Length == 0)
            return 0;
        return vals.Average();
    }

    static double CalculateSum(int[] vals)
    {
        if (vals.Length == 0)
            return 0;
        return vals.Sum();
    }

    static double CalculateMax(int[] vals)
    {
        if (vals.Length == 0)
            return 0;
        return vals.Max();
    }

    static double CalculateMin(int[] vals)
    {
        if (vals.Length == 0)
            return 0;
        return vals.Min();
    }

    static double CalculateCount(int[] vals)
    {
        return vals.Length;
    }
}