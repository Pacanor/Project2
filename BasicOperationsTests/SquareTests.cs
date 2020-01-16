using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOperations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly double c = 2.5;
        private readonly int a = 4;
        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(6.25, BasicOperations.Square.Squared(c));
        }

        [TestMethod()]
        public void SquaredTest1()
        {
            Assert.AreEqual(16, BasicOperations.Square.Squared(a));
        }
    }
}