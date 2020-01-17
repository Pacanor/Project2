using System;

namespace BasicOperations
{
    public class Division
    {
        public static double Quotient(double a, double b)
        {
            double c = a / b;
            return c;
        }

        public static double Quotient(int a, int b)
        {
            double c = a / b;
            return c;
        }

        public static double Quotient(double[] arrayA)
        {
            double c = arrayA[0];

            foreach (double a in arrayA)
            {
                c = Quotient(c, a);
            }
            double d2 = c * arrayA[0];
            double d = Math.Round(d2, 2, MidpointRounding.ToEven);
            return d;
        }

        public static double Quotient(int[] arrayB)
        {
            double d = arrayB[0];

            for (int i = 1; i < arrayB.Length; i++)
            {
                d = Quotient(d, arrayB[i]);
            }
            return d;
        }
    }
}