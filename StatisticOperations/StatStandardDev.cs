using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticOperations
{
    public class StatStandardDev
    {
        public static double result;
        public static double StandardDeviation(double[] arrayA)
        {

            dynamic theVariance = StatVariance.Variance(arrayA);

            double Result1 = Math.Sqrt(theVariance);
            result = Math.Round(Result1, 2, MidpointRounding.ToEven);
            return result;
        }

        public static double StandardDeviation(int[] arrayA)
        {
            dynamic theVariance = StatVariance.Variance(arrayA);

            double Result1 = Math.Sqrt(theVariance);
            result = Math.Round(Result1, 2, MidpointRounding.ToEven);
            return result;
        }
    }
}
