using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticOperations.Tests
{
    [TestClass()]
    public class StatMedianTests
    {
        [TestMethod()]
        public void MedianIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            var Median = StatMedian.Median(values);
            Assert.AreEqual(3, Median);
        }

        [TestMethod()]
        public void MedianDoubleTest()
        {
            double[] values = { 1.1, 2.4, 3.6, 4.8, 5.5 };
            var Median = StatMedian.Median(values);
            Assert.AreEqual(3.6, Median);
        }

        [TestMethod()]
        public void MedianEvenIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            var Median = StatMedian.Median(values);
            Assert.AreEqual(3.5, Median);
        }

        [TestMethod()]
        public void MedianEvenDoubleTest()
        {
            double[] values = { 1.1, 2.4, 3.6, 4.8, 5.5, 6.6 };
            var Median = StatMedian.Median(values);
            Assert.AreEqual(4.2, Median);
        }
    }
}