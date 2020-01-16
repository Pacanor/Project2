﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOperations;
using System;
using System.Collections.Generic;
using System.Text;

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
            dynamic c = SquareRoot.Root(h);
        }

        [TestMethod()]
        public void SqrRootDoubleTest()
        {
            double c = SquareRoot.Root(i);
        }

        [TestMethod()]
        public void SqrRootArrayTest()
        {
            double[] x = { 1.41, 1.73, 2 };
            double[] c = SquareRoot.Root(arrayF);

            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }

        }

        [TestMethod()]
        public void SqrRootDoubleArrayTest()
        {
            double[] x = { 1.2, 2.5, 6.2 };
            double[] c = SquareRoot.Root(arrayE);
            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }
        }
    }
}