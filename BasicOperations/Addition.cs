using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations
{
    public class Addition
    {
        public static dynamic Sum(dynamic a, dynamic b)
        {
            return a + b;
        }

        public static dynamic Sum(dynamic arrayA)
        {
            dynamic c = 0;
            foreach (dynamic a in arrayA)
            {
                c = Sum(a, c);
            }
            return c;
        }
    }
}
