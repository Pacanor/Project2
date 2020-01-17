using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace RandomGen.Tests
{
    [TestClass()]
    public class RandomGenTests
    {
        [TestMethod()]
        public void RandomIntTest()
        {
            int a = RandomGen.RandomInt();
            Debug.Write("The random int is " + a);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void RandomDoubleTest()
        {
            double a = RandomGen.RandomDouble();
            Debug.Write("The random double is " + a);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void RandomNumberIntTest()
        {
            int a = RandomGen.RandomNumber(2, 68);
            Debug.Write("The following is true: 2 < " + a + " < 68");
            Assert.IsTrue(a <= 68 && a >= 2);
        }

        [TestMethod()]
        public void RandomNumberDoubleTest()
        {
            double a = RandomGen.RandomNumber(2.4, 68.4);
            Debug.Write("The following is true: 2.4 < " + a + " < 68.4");
            Assert.IsTrue(a <= 68.4 && a >= 2.4);
        }

        [TestMethod()]
        public void RandomDoublesTest()
        {
            double[] a = RandomGen.RandomDoubles(3);
            int j;
            for (int i = 0; i < a.Length; i++)
            {
                j = i + 1;
                Debug.Write("Double " + j + " is " + a[i] + Environment.NewLine);
                Assert.IsNotNull(a[i]);
            }
        }

        [TestMethod()]
        public void RandomIntsTest()
        {
            int[] a = RandomGen.RandomInts(3);
            int j;
            for (int i = 0; i < a.Length; i++)
            {
                j = i + 1;
                Debug.Write("Double " + j + " is " + a[i] + Environment.NewLine);
                Assert.IsNotNull(a[i]);
            }
        }

        [TestMethod()]
        public void RandomDoublesRangeTest()
        {
            double[] a = RandomGen.RandomDoubles(30, 2.4, 20.4);
            Debug.Write("The following is true for the next 30 numbers: 2.4 < x < 20.4" + Environment.NewLine);
            for (int i = 0; i < a.Length; i++)
            {
                int j = i + 1;
                Debug.Write(j + ". " + a[i] + Environment.NewLine);
                Assert.IsTrue(a[i] <= 20.4 && a[i] >= 2.4);
            }
        }

        [TestMethod()]
        public void RandomIntsRangeTest()
        {
            int[] a = RandomGen.RandomInts(30, 2, 20);
            Debug.Write("The following is true for the next 30 numbers: 2 < x < 20" + Environment.NewLine);
            for (int i = 0; i < a.Length; i++)
            {
                int j = i + 1;
                Debug.Write(j + ". " + a[i] + Environment.NewLine);
                Assert.IsTrue(a[i] <= 20 && a[i] >= 2);
            }
        }
    }
}