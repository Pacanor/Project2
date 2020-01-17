using BasicOperations;

namespace StatisticOperations
{
    public class StatStandardDev
    {
        public static double result;

        public static double StandardDeviation(double[] arrayA)
        {
            double theMean = StatMean.Mean(arrayA);
            int arrayCount_1 = arrayA.Length;

            double squareSum = 0.0;
            foreach (double a in arrayA)
            {
                double differences = Subtraction.Subtract(a, theMean);
                double squares = differences * differences;
                squareSum += squares;
            }

            double Result1 = Division.Quotient(squareSum, arrayCount_1);
            result = SquareRoots.Root(Result1);
            return result;
        }

        public static double StandardDeviation(int[] arrayA)
        {
            double theMean = StatMean.Mean(arrayA);
            int arrayCount_1 = arrayA.Length;

            double squareSum = 0.0;
            foreach (int a in arrayA)
            {
                double differences = Subtraction.Subtract(a, theMean);
                double squares = differences * differences;
                squareSum += squares;
            }

            double variance = Division.Quotient(squareSum, arrayCount_1);
            result = SquareRoots.Root(variance);
            return result;
        }
    }
}