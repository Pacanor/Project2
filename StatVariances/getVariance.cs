using StatisticOperations;

namespace StatVariances
{
    public class GetVariance : IVariance
    {
        public static dynamic result;

        public dynamic Variance(dynamic arrayA)
        {
            result = StatVariance.Variance(arrayA);
            return result;
        }
    }
}