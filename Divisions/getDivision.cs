using System;
using BasicOperations;

namespace Divisions
{
    public class getDivide : IDivide
    {
            public dynamic result;

            public dynamic Divide(dynamic a, dynamic b)
            {
                result = Division.Quotient(a, b);
                return result;
            }

            public dynamic Divide(dynamic a)
            {
                result = Division.Quotient(a);
                return result;
            }
    }
}
