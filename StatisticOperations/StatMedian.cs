using Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticOperations
{
    public class StatMedian
    {
        public static dynamic Median(int[] values)
        {
            int[] sortedVals = Helpers.Arrays.Sort(values);
            dynamic median;
            int count = values.Length;
            if (count == 0)
            {
                throw new InvalidOperationException("This array is empty");
            }
            else if (count % 2 == 0)
            {
                int a = sortedVals[count / 2 - 1];
                int b = sortedVals[count / 2];
                median = (a + b) / 2.0;
            }
            else
            {
                median = sortedVals[count / 2];
            }
            return median;
        }

        public static double Median(double[] values)
        {
            double [] sortedVals = Helpers.Arrays.Sort(values);
            double median;
            int count = values.Length;
            if (count == 0)
            {
                throw new InvalidOperationException("This array is empty");
            }
            else if (count % 2 == 0)
            {
                double a = sortedVals[count / 2 - 1];
                double b = sortedVals[count / 2];
                median = (a + b) / 2.0;
            }
            else
            {
                median = sortedVals[count / 2];
            }
            return median;
        }
    }
}
