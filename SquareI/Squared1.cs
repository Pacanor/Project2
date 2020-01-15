using System;
using BasicOperations;
namespace SquareI
{
    public class Squared1 : ISquared1
    {
        public dynamic result;
        public dynamic Squarea(dynamic a)
        {
            result = Square.Squared(a);
            return result;
        }
    }
}
