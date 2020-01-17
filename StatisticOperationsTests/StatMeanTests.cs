using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticOperations.Tests
{
    [TestClass()]
    public class StatMeanTests
    {
        [TestMethod()]
        public void MeanIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var mean = StatMean.Mean(values);
            Assert.AreEqual(3, mean);
        }

        [TestMethod()]
        public void MeanDoubleTest()
        {
            double[] values = { 1.1, 2.4, 3.6, 4.8, 5.5 };
            var mean = StatMean.Mean(values);
            Assert.AreEqual(3.48, mean);
        }
    }
}