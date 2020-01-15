using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations.Tests
{

    [TestClass()]
    public class MultiplicationTests
    {
        private readonly double c = 8.6;
        private readonly double d = 2.2;
        private readonly int a = 10;
        private readonly int b = 3;
        private readonly double[] arrayA = { 3.0, 12.5, 6.0, 2.5 };
        private readonly int[] arrayB = { 15, 5, 6, 3 };
        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Assert.AreEqual(18.92, BasicOperations.Multiplication.Multiply(c, d));
        }

        [TestMethod()]
        public void MultiplyIntTest1()
        {
            Assert.AreEqual(30, BasicOperations.Multiplication.Multiply(a, b));
        }

        [TestMethod()]
        public void MultiplyDoubleArrayTest2()
        {
            Assert.AreEqual(562.5, Multiplication.Multiply(arrayA));
        }

        [TestMethod()]
        public void MultiplyIntArrayTest3()
        {
            Assert.AreEqual(1350, Multiplication.Multiply(arrayB));
        }
    }
}