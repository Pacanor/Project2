using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        private readonly int a = 15;
        private readonly int b = 3;
        private readonly double c = 7.5;
        private readonly double d = 3.4;
        private readonly double[] e = { 6.2, 1.5, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };
        private readonly double[] g = { 23.25, 2.5, 6.2 };
        private readonly int[] h = { 30, 3, 2, 5 };
        private readonly double i = 6.8;
        private readonly double j = 3.4;

        private readonly Calculator calc = new Calculator();
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(18, calc.Add(a, b));
            Assert.AreEqual(10.9, calc.Add(c, d));
        }

        [TestMethod()]
        public void AddArrayTest1()
        {
            Assert.AreEqual(10.2, calc.Add(e));
            Assert.AreEqual(40, calc.Add(f));
        }

        [TestMethod()]
        public void QuotientTest()
        {
            Assert.AreEqual(5, calc.Quotient(a, b));
            Assert.AreEqual(2, calc.Quotient(i, j));
        }

        [TestMethod()]
        public void QuotientArrayTest1()
        {
            Assert.AreEqual(1.5, calc.Quotient(g));
            Assert.AreEqual(1, calc.Quotient(h));
        }

        public void TimeTest()
        {
            Assert.AreEqual(45, calc.Time(a, b));
            Assert.AreEqual(25.5, calc.Time(c, d));
        }

        [TestMethod()]
        public void TimeArrayTest1()
        {
            Assert.AreEqual(23.25, calc.Time(e));
            Assert.AreEqual(900, calc.Time(f));
        }

        [TestMethod()]
        public void SquareaTest()
        {
            int y = a * a;
            int z = calc.Squarea(a);
            Assert.AreEqual(y, z);
        }

        [TestMethod()]
        public void SubtractedTest()
        {
            Assert.AreEqual(12, calc.Subtracted(a, b));
            Assert.AreEqual(4.1, calc.Subtracted(c, d));
        }

        [TestMethod()]
        public void SubtractedArrayTest1()
        {
            Assert.AreEqual(-10.2, calc.Subtracted(e));
            Assert.AreEqual(-40, calc.Subtracted(f));
        }
    }
}