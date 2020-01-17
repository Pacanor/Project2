using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace Helpers.Tests
{
    [TestClass()]
    public class RoundingTests
    {
        private readonly double c = 8.67890;
        private readonly double d = 2.20645;

        [TestMethod()]
        public void RoundOffTwoPlacesTest()
        {
            Assert.AreEqual(2.21, Helpers.Rounding.RoundOffTwoPlaces(d));
        }

        [TestMethod()]
        public void RoundOFFThreePlacesTest()
        {
            Assert.AreEqual(8.679, Helpers.Rounding.RoundOFFThreePlaces(c));
        }
    }
}