using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        private readonly double c = 10.01;
        private readonly double d = 20.02;
        private readonly double[] arrayC = { 20.0, 2.5, 4.1 };
        private readonly int[] arrayD = { 16, 2, 2 };

        [TestMethod()]
        public void DivideTest()
        {
            double c = Division.Quotient(b, a);
            Assert.AreEqual(2, c);
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            double a = Division.Quotient(d, c);
            Assert.AreEqual(2, a);
        }

        [TestMethod()]
        public void DivideArrayTest()
        {
            double c = Division.Quotient(arrayD);
            Assert.AreEqual(4, c);
        }

        [TestMethod()]
        public void DivideDoubleArrayTest()
        {
            double a = Division.Quotient(arrayC);
            Assert.AreEqual(1.95, a);
        }
    }
}