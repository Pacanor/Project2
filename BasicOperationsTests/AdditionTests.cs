using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        private readonly double c = 10.01;
        private readonly double d = 20.02;
        private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07 };
        private readonly int[] arrayB = { 1, 2, 3, 4, 5 };

        [TestMethod()]
        public void AddTest()
        {
            int c = Addition.Sum(a, b);
            Assert.AreEqual(30, c);
        }

        [TestMethod()]
        public void AddDoubleTest()
        {
            double a = Addition.Sum(c, d);
            Assert.AreEqual(30.03, a);
        }

        [TestMethod()]
        public void AddArrayTest()
        {
            int c = Addition.Sum(arrayB);
            Assert.AreEqual(15, c);
        }

        [TestMethod()]
        public void AddDoubleArrayTest()
        {
            double a = Addition.Sum(arrayA);
            Assert.AreEqual(10.18, a);
        }
    }
}