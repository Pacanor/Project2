using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumbers.Tests
{
    [TestClass()]
    public class RandomGenTests
    {
        [TestMethod()]
        public void RandomIntTest()
        {
            int a = RandomGen.RandomInt();
            Assert.AreNotEqual(a, 2);
        }

        [TestMethod()]
        public void RandomDoubleTest()
        {
            double a = RandomGen.RandomDouble();
            Assert.AreNotEqual(a, 2);
        }
        
        [TestMethod()]
        public void RandomNumberIntTest()
        {
            int a = RandomGen.RandomNumber(2, 68);
            Assert.IsTrue(a<68 || a>2);
        }
        
        [TestMethod()]
        public void RandomNumberDoubleTest()
        {
            double a = RandomGen.RandomNumber(2.4, 68.4);
            Assert.IsTrue(a < 68.4 || a > 2.4);
        }

        [TestMethod()]
        public void RandomDoublesTest()
        {
            double[] a = RandomGen.RandomDoubles(3);
            double[] b = { 1.1, 2.2, 3.3 };
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreNotEqual(a[i], b[i]);
            }
        }
        
        [TestMethod()]
        public void RandomIntsTest()
        {
            int[] a = RandomGen.RandomInts(3);
            int[] b = { 1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreNotEqual(a[i], b[i]);
            }
        }
        
        [TestMethod()]
        public void RandomDoublesRangeTest()
        {
            double[] a = RandomGen.RandomDoubles(30, 2.4, 20.4);
            for (int i = 0; i < a.Length; i++)
            {
                Assert.IsTrue(a[i] < 20.4 || a[i] > 2.4);
            }
        }

        [TestMethod()]
        public void RandomIntsRangeTest()
        {
            int[] a = RandomGen.RandomInts(30, 2, 20);
            for(int i = 0; i<a.Length; i++)
            {
                Assert.IsTrue(a[i] < 20 || a[i] > 2);
            }
            
        }
                        
    }
}