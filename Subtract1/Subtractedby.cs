using System;
using BasicOperations;
namespace Subtract
{
    public class Subtractedby : ISubtractedby
    {
        public dynamic result;
        public dynamic Subtracted(dynamic a, dynamic b)
        {
            result = Subtraction.Subtract(a, b);
            return result;
        }
        public dynamic Subtracted(dynamic a)
        {
            result = Subtraction.Subtract(a);
            return result;
        }
    }
}
