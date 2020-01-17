using Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticOperations.Tests
{
    [TestClass()]
    public class StatVarianceTests
    {
        private readonly int[] arrayA = { 8, 10, 14, 9, 12, 7 };
        private readonly double[] arrayB = { 3.4, 4.2, 1.8, 5, 3.8 };

        [TestMethod()]
        public void Variance_Test()
        {
            var finalVariance = StatVariance.Variance(arrayA);
            Assert.AreEqual(5.67, Helpers.Rounding.RoundOffTwoPlaces(finalVariance));
        }


        [TestMethod()]
        public void VarianceDoubleTest()
        {
            var finalVariance = StatVariance.Variance(arrayB);
            Assert.AreEqual(1.13, Helpers.Rounding.RoundOffTwoPlaces(finalVariance));
        }
    }
}