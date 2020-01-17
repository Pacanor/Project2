using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticOperations.Tests
{
    [TestClass()]
    public class StatisticCalculatorTests
    {

        private readonly double[] arrayB = { 4.2, 4.4, 4.6, 4.4 };
        private readonly int[] arrayA = { 1, 2, 3, 4, 5 };

        [TestMethod()]
        public void StandardDev_Test()
        {
            var finalStandardDev = StatStandardDev.StandardDeviation(arrayA);
            var RoundedStandardDev = Helpers.Rounding.RoundOffTwoPlaces(finalStandardDev);
            Assert.AreEqual(1.41, RoundedStandardDev);
        }

        [TestMethod()]
        public void StandardDevDoubleTest()
        {
            var finalStandardDev = StatStandardDev.StandardDeviation(arrayB);
            var RoundedStandardDev = Helpers.Rounding.RoundOffTwoPlaces(finalStandardDev);
            Assert.AreEqual(0.14, RoundedStandardDev);
        }
    }
}
