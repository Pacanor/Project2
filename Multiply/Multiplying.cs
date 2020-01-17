using System;
using BasicOperations;
namespace Multiply
{
    public class Multiplying : IMultiplying
    {
        public dynamic result;
        public dynamic Time(dynamic a, dynamic b)
        {
            result = Multiplication.Multiply(a, b);
            return result;
        }
        public dynamic Time(dynamic a)
        {
            result = Multiplication.Multiply(a);
            return result;
        }
    }
}
