using BasicOperations;

namespace Additions
{
    public class getAddition : ISum
    {
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        public dynamic Add(dynamic a)
        {
            result = Addition.Sum(a);
            return result;
        }
    }
}