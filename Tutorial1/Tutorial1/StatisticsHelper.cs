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
}