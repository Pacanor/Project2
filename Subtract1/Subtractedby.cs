using System;
using BasicOperations;
namespace Subtract1
{
    public class Subtractedby : ISubtractedby
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
