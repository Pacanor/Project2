using StatisticOperations;

namespace StatStandardDeviation
{
    public class GetStandardDev : IStandardDev
    {
        public static double result;

        public dynamic StandardDeviation(dynamic arrayA)
        {
            result = StatStandardDev.StandardDeviation(arrayA);
            return result;
        }
    }
}
