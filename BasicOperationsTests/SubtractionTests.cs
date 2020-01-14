using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly double c = 5.7;
        private readonly double d = 3.0;
        private readonly int a = 10;
        private readonly int b = 5;
        private readonly double[] e = { 6.02, 1.3, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };
        [TestMethod()]
        public void SubtractDoubleTest()
        {
            Assert.AreEqual(2.7, BasicOperations.Subtraction.Subtract(c, d));
        }

        [TestMethod()]
        public void SubtractIntTest()
        {
            Assert.AreEqual(5, BasicOperations.Subtraction.Subtract(a, b));
        }

        [TestMethod()]
        public void SubtractDoubleArrayTest()
        {
            Assert.AreEqual(-9.82, Subtraction.Subtract(e));
        }

        [TestMethod()]
        public void SubtractIntArrayTest()
        {
            Assert.AreEqual(-40, Subtraction.Subtract(f));
        }
    }
}