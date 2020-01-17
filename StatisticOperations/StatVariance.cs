using System;

namespace StatisticOperations
{
    public class StatVariance
    {
        public static dynamic result;

        public static dynamic Variance(dynamic arrayA)
        {
            dynamic theMean = StatMean.Mean(arrayA);
            int arrayCount_1 = arrayA.Length;

            dynamic squares = new Array[0];
            dynamic squareSum = 0.0;
            dynamic differences = 0.0;

            foreach (dynamic a in arrayA)
            {
                differences = a - theMean;
                squares = differences * differences;
                squareSum = (squareSum + squares);
            }

            result = squareSum / arrayCount_1;
            return result;
        }
    }
}