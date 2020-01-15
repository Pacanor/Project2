using System;
using BasicOperations;

namespace SquareRoots
{
    public class getSqrRoot : ISqrRoot
    {
        public dynamic result;

        public dynamic SqrRoot(dynamic a)
        {
            result = SquareRoot.Root(a);
            return result;

        }
    }
}
