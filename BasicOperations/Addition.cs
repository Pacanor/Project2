using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations
{
    public class Addition
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double[] arrayA)
        {
            double c = 0;
            foreach (double a in arrayA)
            {
                c = Sum(a, c);
            }
            return c;
        }

        public static int Sum(int[] arrayA)
        {
            int c = 0;
            foreach (int a in arrayA)
            {
                c = Sum(a, c);
            }
            return c;
        }

    }
}
