using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations
{
   public class Subtraction
    {
        public static double Subtract(double c, double d)
        {
            return c - d;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static double Subtract(double[] a)
        {
            double c = 0.0;
            foreach (double b in a)
            {
                c = Subtract(c, b);
            }
            return c;
        }

        public static int Subtract(int[] a)
        {
            int c = 0;
            foreach (int b in a)
            {
                c = Subtract(c, b);
            }
            return c;
        }
    }
}
