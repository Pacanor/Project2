using System;

namespace Helpers
{
    public class Arrays
    {
        public static int Length(dynamic array)
        {

            int length = array.Length();
            return length;
        }

        public static int[] Sort(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        public static double[] Sort(double[] array)
        {
            Array.Sort(array);
            return array;
        }
    }
}
