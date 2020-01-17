using BasicCalculator;
using StatMean;
using StatMedian;
using StatMode;
using StatStandardDeviations;
using StatVariances;
using StatZScore;

namespace StatisticsCalculator
{
    public class StatCalculator : Calculator, IFindMean, IFindMode, IFindMedian, IStandardDev, IVariance, IFindZScore
    {
        private readonly FindMean mean = new FindMean();
        private readonly FindMode mode = new FindMode();
        private readonly FindMedian median = new FindMedian();
        private readonly getStandardDev standDev = new getStandardDev();
        private readonly getVariance var = new getVariance();
        private readonly FindZScore z = new FindZScore();

        public dynamic Mean(dynamic values)
        {
            return mean.Mean(values);
        }

        public double ZScore(dynamic score, dynamic values)
        {
            return z.ZScore(score, values);
        }

        public dynamic Mode(dynamic a)
        {
            return mode.Mode(a);
        }

        public dynamic Median(dynamic a)
        {
            return median.Median(a);
        }

        public dynamic StandardDeviation(dynamic arrayA)
        {
            return standDev.StandardDeviation(arrayA);
        }

        public dynamic Variance(dynamic arrayA)
        {
            return var.Variance(arrayA);
        }
    }
}