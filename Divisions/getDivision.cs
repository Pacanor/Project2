using System;
using BasicOperations;

namespace Divisions
{
    public class getDivision : IDividing
    {
            public dynamic result;

            public dynamic Quotient(dynamic a, dynamic b)
            {
                result = Division.Quotient(a, b);
                return result;
            }

            public dynamic Quotient(dynamic a)
            {
                result = Division.Quotient(a);
                return result;
            }
    }
}
