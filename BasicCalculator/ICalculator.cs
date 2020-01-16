using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
   public interface ICalculator
    {
        public dynamic Add(dynamic a, dynamic b); //Add is a function from the project Add and Class Sum

        public dynamic Add(dynamic a);

        public dynamic Subtracted(dynamic a, dynamic b);

        public dynamic Subtracted(dynamic a);

        public dynamic Time(dynamic a, dynamic b);

        public dynamic Time(dynamic a);

        public dynamic Quotient(dynamic a, dynamic b);

        public dynamic Quotient(dynamic a);

        public dynamic Root(dynamic a);

        public dynamic Squarea(dynamic a);

    }
}
