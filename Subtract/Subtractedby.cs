using System;
using BasicOperations;
namespace Subtract
{
    public class Subtractby : ISubtractby
    {
        public dynamic results;
        public dynamic Subtracted(dynamic a, dynamic b)
        {
            results = Subtraction.Subtract(a, b);
            return results;
        }
        public dynamic Subtracted(dynamic a)
        {
            results = Subtraction.Subtract(a);
            return results;
        }
    }
}
