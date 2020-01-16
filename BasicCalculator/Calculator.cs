using System;
using System.Collections.Generic;
using System.Text;
using BasicOperations;
using Divisions;
using Additions;
using Multiply;
using Squared;
using SqrRoots;
using Subtract;
namespace BasicCalculator
{
   public class Calculator: IDividing, ISum, IMultiplying, ISubtracts, ISquaredC, ISqrRoots
    {
        public dynamic result;

        private readonly  getDivision div = new getDivision();
        private readonly getAddition add = new getAddition();
        private readonly Multiplying mul = new Multiplying();
        private readonly SquareC square = new SquareC();
        private readonly getSqrRoots sr = new getSqrRoots();
        private readonly Subtracts sub = new Subtracts();
        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b); //add is a construction//Add is a function Name
            return result;
        }
        public dynamic Add(dynamic a)
        {
            result = add.Add(a); 
            return result;
        }
        public dynamic Quotient(dynamic a, dynamic b)
        {
            result = div.Quotient(a, b);
            return result;
        }
        public dynamic Quotient(dynamic a)
        {
            result = div.Quotient(a);
            return result;
        }


        public dynamic Time(dynamic a, dynamic b)
        {
            result = mul.Time(a, b);
            return result;
        }
        public dynamic Time(dynamic a)
        {
            result = mul.Time(a);
            return result;
        }
        public dynamic Squarea(dynamic a)
        {
            result = square.Squarea(a);
            return result;
        }
        public dynamic Root(dynamic a)
        {
            result = sr.Root(a);
            return result;
        }
        public dynamic Subtracted(dynamic a, dynamic b)
        {
            result = sub.Subtracted(a, b);
            return result;
        }
        public dynamic Subtracted(dynamic a)
        {
            result = sub.Subtracted(a);
            return result;
        }


    }
}
