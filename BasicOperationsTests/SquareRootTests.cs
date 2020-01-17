using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly int h = 144;
        private readonly double i = 2.25;
        private readonly double[] arrayE = { 1.44, 6.25, 38.44 };
        private readonly int[] arrayF = { 2, 3, 4 };

        [TestMethod()]
        public void SqrRootIntTest()
        {
            dynamic c = SquareRoots.Root(h);
        }

        [TestMethod()]
        public void SqrRootDoubleTest()
        {
            double c = SquareRoots.Root(i);
        }

        [TestMethod()]
        public void SqrRootArrayTest()
        {
            double[] x = { 1.41, 1.73, 2 };
            double[] c = SquareRoots.Root(arrayF);

            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }
        }

        [TestMethod()]
        public void SqrRootDoubleArrayTest()
        {
            double[] x = { 1.2, 2.5, 6.2 };
            double[] c = SquareRoots.Root(arrayE);
            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }
        }
    }
}