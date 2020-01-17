using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatCalculatorTests
    {
        private readonly StatCalculator statCalc = new StatCalculator();
        private readonly int[] values = { 1, 2, 3, 4, 5 };
        private readonly int[] values2 = { 1, 2, 3, 4, 5, 2 };
        private readonly int score = 4;
        private readonly double[] doubleVal = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        private readonly double[] doubleVal2 = { 1.1, 2.2, 3.3, 4.4, 5.5, 5.5 };
        private readonly double doubleScore = 2.2;

        [TestMethod()]
        public void MeanIntTest()
        {
            var mean = statCalc.Mean(values);
            Assert.AreEqual(3, mean);
        }

        [TestMethod()]
        public void ModeIntFailTest()
        {
            try
            {
                var mode = statCalc.Mode(values);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is OperationCanceledException);
            }
        }

        [TestMethod()]
        public void ModeIntTest()
        {
            var mode = statCalc.Mode(values2);
            Assert.AreEqual(2, mode);
        }

        [TestMethod()]
        public void MedianIntTest()
        {
            var median = statCalc.Median(values);
            Assert.AreEqual(3, median);
        }

        [TestMethod()]
        public void VarianceIntTest()
        {
            var variance = statCalc.Variance(values);
            Assert.AreEqual(2, Helpers.Rounding.RoundOffTwoPlaces(variance));
        }

        [TestMethod()]
        public void StandDevIntTest()
        {
            var standDev = statCalc.StandardDeviation(values);
            Assert.AreEqual(1.41, Helpers.Rounding.RoundOffTwoPlaces(standDev));
        }

        [TestMethod()]
        public void ZScoreIntTest()
        {
            var z = statCalc.ZScore(score, values);
            Assert.AreEqual(0.71, Helpers.Rounding.RoundOffTwoPlaces(z));
        }

        [TestMethod()]
        public void MeanDoubleTest()
        {
            var mean = statCalc.Mean(doubleVal);
            Assert.AreEqual(3.3, mean);
        }

        [TestMethod()]
        public void ModeDoubleFailTest()
        {
            try
            {
                var mode = statCalc.Mode(doubleVal);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is OperationCanceledException);
            }
        }

        [TestMethod()]
        public void ModeDoubleTest()
        {
            var mode = statCalc.Mode(doubleVal2);
            Assert.AreEqual(5.5, mode);
        }

        [TestMethod()]
        public void MedianDoubleTest()
        {
            var median = statCalc.Median(doubleVal);
            Assert.AreEqual(3.3, median);
        }

        [TestMethod()]
        public void VarianceDoubleTest()
        {
            var variance = statCalc.Variance(doubleVal);
            Assert.AreEqual(2.42, Helpers.Rounding.RoundOffTwoPlaces(variance));
        }

        [TestMethod()]
        public void StandDevDoubleTest()
        {
            var standDev = statCalc.StandardDeviation(doubleVal);
            Assert.AreEqual(1.56, Helpers.Rounding.RoundOffTwoPlaces(standDev));
        }

        [TestMethod()]
        public void ZScoreDoubleTest()
        {
            var z = statCalc.ZScore(doubleScore, doubleVal);
            Assert.AreEqual(-0.71, Helpers.Rounding.RoundOffTwoPlaces(z));
        }
    }
}