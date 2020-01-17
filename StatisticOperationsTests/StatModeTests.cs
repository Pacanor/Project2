using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StatisticOperations.Tests
{
    [TestClass()]
    public class StatModeTests
    {
        [TestMethod()]
        public void ModeIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5, 1 };
            var Mode = StatMode.Mode(values);
            Assert.AreEqual(1, Mode);
        }

        [TestMethod()]
        public void ModeEqualIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };

            try
            {
                var mode = StatMode.Mode(values);
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
            double[] values = { 1.1, 2.4, 3.6, 4.8, 5.5, 2.4 };
            var Mode = StatMode.Mode(values);
            Assert.AreEqual(2.4, Mode);
        }

        [TestMethod()]
        public void ModeEqualDoubleTest()
        {
            double[] values = { 1.1, 2.4, 3.6, 4.8, 5.5 };

            try
            {
                var mode = StatMode.Mode(values);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is OperationCanceledException);
            }
        }
    }
}