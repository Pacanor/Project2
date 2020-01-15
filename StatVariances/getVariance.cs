using System;
using StatisticOperations;

namespace StatVariances
{
    public class getVariance : IVariance
    {
        public static dynamic result;

        public dynamic Variance(dynamic arrayA)
        {
            result = StatVariance.Variance(arrayA);
            return result;
        }

    }
}
