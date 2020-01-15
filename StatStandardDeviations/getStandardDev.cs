using System;
using System.Collections.Generic;
using System.Text;
using StatisticOperations;

namespace StatStandardDeviations
{
    public class getStandardDev: IStandardDev
    {
        public static double result;

        public dynamic StandardDeviation(dynamic arrayA)
        {
            result = StatStandardDev.StandardDeviation(arrayA);
            return result;
        }
    }
}
