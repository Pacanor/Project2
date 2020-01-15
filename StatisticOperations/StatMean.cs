
namespace StatisticOperations
{
    public class StatMean
    {
        public static dynamic Mean(int[] values)
        {
            var sum = 0;
            foreach(int a in values)
            {
                sum += a;
            }
            var mean = sum/ values.Length;
            return mean;
        }

        public static dynamic Mean(double[] values)
        {
            var sum = 0.0;
            foreach (double a in values)
            {
                sum += a;
            }
            var mean = sum / values.Length;
            return mean;
        }
    }
}