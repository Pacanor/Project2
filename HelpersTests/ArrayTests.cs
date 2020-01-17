using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace Helpers.Tests
{
    [TestClass()]
    public class ArrayTests
    {
        private readonly dynamic[] f = { 30, 3, 2, 5.3, 4.2, 0.3 };

        [TestMethod()]
        public void LengthTest()
        {
            Assert.AreEqual(6, f.Length);
        }
    }
}