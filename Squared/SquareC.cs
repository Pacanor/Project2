using BasicOperations;

namespace Squared
{
    public class SquareC : ISquaredC
    {
        public dynamic result;

        public dynamic Squarea(dynamic a)
        {
            result = Square.Squared(a);
            return result;
        }
    }
}