using BasicOperations;

namespace SqrRoots
{
    public class getSqrRoots : ISqrRoots
    {
        public dynamic result;

        public dynamic Root(dynamic a)
        {
            result = SquareRoots.Root(a);
            return result;
        }
    }
}